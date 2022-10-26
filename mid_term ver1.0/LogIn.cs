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
using System.Text.RegularExpressions;
using System.Collections;

namespace mid_term_ver1._0
{
    public partial class LogIn : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //驗證碼
            create_checkNum();

            //連接momoDB
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

        }

        void MemberLogInChk()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL2 = "select * from momo_member where member_account= @account and member_available = 1";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            cmd2.Parameters.AddWithValue("@account", txtaccount.Text);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.HasRows)
            {
                reader2.Close();
                string strSQL3 = "select * from momo_member where member_account= @account2 and member_password=@password2 and member_available = 1";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@account2", txtaccount.Text);
                cmd3.Parameters.AddWithValue("@password2", txtpassword.Text);
                SqlDataReader reader3 = cmd3.ExecuteReader();

                if (reader3.HasRows)
                {
                    MessageBox.Show("成功登入");
                    GlobalVar.G_user_permission = 1;
                    GlobalVar.G_user_info.Add("ID", reader3["member_ID"].ToString());
                    GlobalVar.G_user_info.Add("phone", reader3["member_phone"].ToString());

                }
                else
                {
                    MessageBox.Show("Member密碼有誤");
                    clear();
                }
                reader3.Close();
            }
            else
            {
                MessageBox.Show("無此Member帳號");
                clear();
            }
            reader2.Close();
            con.Close();
        }

        void ClerkLogInChk(out int a)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from momo_clerk_account where Clerk_account= @account and Clerk_password= @password and Clerk_available=1";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@account", txtaccount.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {//成功登入
                Console.WriteLine("clerk log in");
                MemberInfo memberInfo = new MemberInfo();
                memberInfo.Show();
                GlobalVar.G_user_permission = 2;
                a = 1;
            }
            else
            {
                Console.WriteLine("not clerk");
                a = 0;
            }
            reader.Close();
            con.Close();
        }

        void clear()
        {//清除txt、換驗證碼

            txtaccount.Text = "";
            txtpassword.Text = "";
            txtchkNum.Text = "";
            create_checkNum();
        }

        private void btn_changeChkNum_Click(object sender, EventArgs e)
        {
            create_checkNum();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            List<string> ActNPsw = new List<string>();
            ActNPsw.Add(txtaccount.Text);
            ActNPsw.Add(txtpassword.Text);
            GlobalVar.G_member_SignUp.Add(ActNPsw);
            SignUp SignUp = new SignUp();
            SignUp.ShowDialog();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            bool txtaccountchk = (txtaccount.Text != "");
            bool txtpasswordchk = (txtpassword.Text != "") && (txtpassword.Text.Length>=8);
            //Ismatch_checkNum();
            if(txtaccountchk && txtpasswordchk)
            {
                ClerkLogInChk(out int a);
                if (a == 0)
                {
                    Console.WriteLine("即將進入memberLohInChk"+a);
                    MemberLogInChk();
                }
                
            }
            else
            {
                MessageBox.Show("帳密有誤");
            }            
        }

        void Ismatch_checkNum()
        {//檢查驗證碼

            if(lblchkNum.Text != txtchkNum.Text)
            {
                MessageBox.Show("驗證碼錯誤");
                txtchkNum.Text = "";
                create_checkNum();
            }
            else
            {

            }
        }

        void create_checkNum()
        {//產生新的驗證碼

            Random rnd = new Random();
            lblchkNum.Text = rnd.Next(1001, 9998).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("是否要進入員工登入頁面", "員工登入", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                //員工登入
            }
        }

        
    }
}
