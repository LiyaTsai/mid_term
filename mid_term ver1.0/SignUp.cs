using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_term_ver1._0
{
    public partial class SignUp : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = ""; 
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            foreach(List<string> signUp in GlobalVar.G_member_SignUp)
            {
                string account = (string)signUp[0];
                string password = (string)signUp[1];

                txt_account.Text = account;
                txt_password.Text = password;
            }

            //連接momoDB
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

        }
               

        private void btn_signup_Click(object sender, EventArgs e)
        {
           blankchk(out int a);
           if(a==1)
           {//存到資料庫
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                
                //先檢查帳號是否已存在
                string strSQL2 = "select * from momo_member where member_account= @account and member_available = 1";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@account", txt_account.Text);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                Console.WriteLine("檢查帳號是否已存在");

                if (reader2.HasRows)
                {//帳號已存在
                    MessageBox.Show("此帳號已存在");
                    reader2.Close();
                }
                else
                {
                    reader2.Close();
                    string strSQL = "insert momo_member(member_account,member_password,member_name,member_phone,member_birthday,member_email,member_address,member_marriage) values (@NewAccount, @NewPassword, @NewName, @Newphone, @NewBirthday, @NewEmail, @NewAddress, @NewMarriage)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewAccount", txt_account.Text);
                    cmd.Parameters.AddWithValue("@NewPassword", txt_password.Text);
                    cmd.Parameters.AddWithValue("@NewName", txt_name.Text);
                    cmd.Parameters.AddWithValue("@Newphone", txt_phone.Text);
                    cmd.Parameters.AddWithValue("@NewBirthday", dtp_birthday.Value);
                    cmd.Parameters.AddWithValue("@NewEmail", txt_email.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", txt_address.Text);
                    int marriage = 0; //要先賦值
                    if (rbtn_marriaged.Checked)
                    {
                        marriage = 1;
                    }
                    else if (rbtn_single.Checked)
                    {
                        marriage = 0;
                    }
                    cmd.Parameters.AddWithValue("@NewMarriage", marriage);
                    Console.WriteLine("新會員創建成功");

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("資料儲存成功, 影響" + rows + "筆資料", "註冊成功");

                    //MessageBox.Show("註冊成功，請登入會員","註冊成功");

                }
                con.Close();
            }

        }

        void blankchk(out int a)
        {
            string blankmsg = "";
            DateTime age12 = DateTime.Now.AddYears(-12);
            bool accountchk = (txt_account.Text != "");
            bool passwordchk = Regex.IsMatch(txt_password.Text, @"\w{4}");
            bool namechk = (txt_name.Text != "") ;
            bool phonechk = Regex.IsMatch(txt_phone.Text, @"^09[0-9]{8}$");
            bool birthdaychk = dtp_birthday.Value <= age12;
            bool emailchk = Regex.IsMatch(txt_email.Text, @"^([\w\.\-]+)@([\w\.\-]+)\.[a-zA-Z]{2,5}$");
            bool addresschk = Regex.IsMatch(txt_address.Text, @"^\w+[縣市]\w+[路街道巷弄]*[0-9]{1,}[號]");
            bool marriagechk = (rbtn_single.Checked == true) || (rbtn_marriaged.Checked == true);

            if (accountchk)
            {

            }
            else
            {
                blankmsg += "請輸入帳號\n";
            }
            if (passwordchk)
            {

            }
            else
            {
                blankmsg += "密碼應為8-20個大小寫字母及數字\n";
            }
            if (namechk)
            {

            }
            else
            {
                blankmsg += "請輸入姓字\n";
            }
            if (phonechk)
            {

            }
            else
            {
                blankmsg += "手機號碼格式不正確\n";
            }
            if (birthdaychk)
            {

            }
            else
            {
                blankmsg += "須年滿12歲\n";
            }
            if (emailchk)
            {

            }
            else
            {
                blankmsg += "email格式不正確\n";
            }
            if (addresschk)
            {

            }
            else
            {
                blankmsg += "地址格式不正確\n";
            }
            if (marriagechk)
            {

            }
            else
            {
                blankmsg += "請選擇婚姻狀態\n";
            }
            if(blankmsg =="")
            {
                a = 1;
            }
            else
            {
                a = 0;
                MessageBox.Show(blankmsg);
            }
        }
    }
}
