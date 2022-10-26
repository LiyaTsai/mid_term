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
            string strSQL = "select member_ID, member_account as 會員帳號, (member_lastName + ' ' + member_firstName) as 姓名, member_phone as 手機,　member_email as 信箱, member_point as 點數 from momo_member where member_available = 1"; 
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
                        txt_ID.Text = reader["member_ID"].ToString();
                        txt_account.Text = reader["member_account"].ToString();
                        txt_LastName.Text = reader["member_lastName"].ToString();
                        txt_FirstName.Text = reader["member_firstName"].ToString();
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

        }
    }
}
