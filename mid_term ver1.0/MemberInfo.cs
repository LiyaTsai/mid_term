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
using System.Data.SqlClient;
using System.Xml.Linq;

namespace mid_term_ver1._0
{
    public partial class MemberInfo : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        public MemberInfo()
        {
            InitializeComponent();
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            //連接momoDB
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            cbox_search.Items.Add("姓名");
            cbox_search.Items.Add("手機");
            cbox_search.Items.Add("地址");
            cbox_search.Items.Add("信箱");

            allMemberList();
        }

        void allMemberList()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select member_ID, member_account as 會員帳號, member_name as 姓名, member_phone as 手機,member_address as 地址, 　member_email as 信箱, member_point as 點數 from momo_member where member_available = 1"; 
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv_allMemberList.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dgv_allMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv_allMemberList.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelID);

                if (isID)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from momo_member where member_ID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lb_ID.Text = reader["member_ID"].ToString();
                        txt_name.Text = reader["member_name"].ToString();
                        txt_phone.Text = reader["member_phone"].ToString();
                        Console.WriteLine(Convert.ToDateTime(reader["member_birthday"]).ToString("yyyyMMdd"));
                        dtp_birthday.Value = Convert.ToDateTime(reader["member_birthday"]); ;
                        txt_email.Text = reader["member_email"].ToString();
                        txt_point.Text = reader["member_point"].ToString();
                        txt_address.Text = reader["member_address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        //清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "update momo_member set member_available = 0; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
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
            txt_phone.Text = "";
            dtp_birthday.Value = DateTime.Now;
            txt_email.Text = "";
            txt_point.Text = "";
            txt_address.Text = "";
            txt_search.Text = "";
            cbox_search.SelectedIndex = -1;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string column = "";
            if(cbox_search.SelectedIndex == 0)
            {
                column = "member_name";
            }
            else if(cbox_search.SelectedIndex == 1)
            {
                column = "member_phone";
            }
            else if(cbox_search.SelectedIndex ==2 )
            {
                column = "member_address";
            }
            else if(cbox_search.SelectedIndex == 3 )
            {
                column = "member_email";
            }
            
            if ((txt_search.Text != "") && (cbox_search.SelectedIndex != -1))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from momo_member where " + column+ " like @search;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@search", "%" + txt_search.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["member_ID"]);
                    lb_ID.Text = reader["member_ID"].ToString();
                    txt_name.Text = reader["member_name"].ToString();
                    txt_phone.Text = reader["member_phone"].ToString();
                    dtp_birthday.Value = Convert.ToDateTime(reader["member_birthday"]); ;
                    txt_email.Text = reader["member_email"].ToString();
                    txt_point.Text = reader["member_point"].ToString();
                    txt_address.Text = reader["member_address"].ToString();
                }
                reader.Close();
                con.Close();

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lb_ID.Text, out intID);

            if ((intID > 0) && (txt_name.Text != "") && (txt_phone.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update momo_member set member_name=@NewName, member_phone=@NewPhone,member_address=@NewAddress, member_email=@NewEmail, member_birthday=@NewBirthday,  member_point=@NewPoints where member_ID=@SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt_name.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt_address.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txt_email.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp_birthday.Value);
                int intPoints = 0;
                Int32.TryParse(txt_point.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints", intPoints);
                cmd.Parameters.AddWithValue("@SearchId", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("異動成功, {0} 個資料列受到影響", rows));
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            allMemberList();
            clear();
        }
    }
}
