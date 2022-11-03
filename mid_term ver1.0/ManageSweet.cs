using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_term_ver1._0
{
    public partial class addSweet : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        public addSweet()
        {
            InitializeComponent();
        }

        private void AddSweet_Load(object sender, EventArgs e)
        {
            //連接momoDB
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            allSweetList();
        }


        void allSweetList()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select dessert_ID as '編號', dessert_name as '品名',dessert_price as '價格' ,dessert_description as '說明' from dessert where dessert_available = 1";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv_allSweetList.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dgv_allSweetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv_allSweetList.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelID);

                if (isID)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from dessert where dessert_ID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lb_ID.Text = reader["dessert_ID"].ToString();
                        txt_name.Text = reader["dessert_name"].ToString();
                        txt_price.Text = reader["dessert_price"].ToString();
                        txt_desc.Text = reader["dessert_description"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此甜點");
                        //清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lb_ID.Text, out intID);

            if ((intID > 0) && (txt_name.Text != "") && (txt_price.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update dessert set dessert_name=@NewName, dessert_price=@NewPrice,dessert_description=@NewDesc where dessert_ID=@SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt_name.Text);
                cmd.Parameters.AddWithValue("@NewPrice", txt_price.Text);
                cmd.Parameters.AddWithValue("@NewDesc", txt_desc.Text);
                cmd.Parameters.AddWithValue("@SearchId", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("異動成功, {0} 個資料列受到影響", rows));
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            allSweetList();
            clear();
        }

        private void btn_deleteSweet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "update dessert set dessert_available = 0 where dessert_ID = @ID; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", lb_ID.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            lb_ID.Text = "";
            txt_name.Text = "";
            txt_price.Text = "";
            txt_desc.Text = "";
        }

        private void btn_addSweet_Click(object sender, EventArgs e)
        {
            addSweets addSweets = new addSweets();
            addSweets.Show();
        }
    }   
}
