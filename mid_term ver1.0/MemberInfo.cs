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

            allMemberList();
        }

        void allMemberList()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select member_ID, member_account as 會員帳號, member_name as 姓名, member_phone as 手機,　member_email as 信箱, member_point as 點數 from momo_member where member_available = 1"; 
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
            lb_ID.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            dtp_birthday.Value = DateTime.Now;
            txt_email.Text = "";
            txt_point.Text = "";
            txt_address.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            allMemberList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_phoneSearch_Click(object sender, EventArgs e)
        {
            if(txt_phone.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from momo_member where member_phone like @searchPhone;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchPhone", "%" + txt_phone.Text + "%");
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

        private void btn_emailSearch_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from momo_member where member_email like @searchemail;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchemail", "%" + txt_email.Text + "%");
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
    }
}
