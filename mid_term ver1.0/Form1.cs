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

namespace mid_term_ver1._0
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        public Form1()
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

        void LogInChk()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from momo_member_account where member_account= @account and member_available == 1";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@account", txtaccount.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                reader.Close();
                string strSQL2 = "select * from momo_member_account where member_account= @account2 and member_password= @password2 ";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@account2", txtaccount.Text);
                cmd2.Parameters.AddWithValue("@password2", txtpassword.Text);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                if( reader2.HasRows)
                {
                    MessageBox.Show("成功登入");
                }
                else
                {
                    MessageBox.Show("密碼有誤");
                    clear();
                }
                reader2.Close();
            }
            else
            {
                MessageBox.Show("無此帳號");
                clear();
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
            bool txtpasswordchk = (txtpassword.Text != "");
            //Ismatch_checkNum();
            if(txtaccountchk && txtpasswordchk)
            {
                LogInChk();
            }
            else
            {
                MessageBox.Show("請輸入帳密");
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
