using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_term_ver1._0
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            

        }

        void blankchk()
        {
            string blankmsg = "";
            DateTime age12 = DateTime.Now.AddYears(-12);
            bool accountchk = (txt_account.Text != "");
            bool passwordchk = Regex.IsMatch(txt_password.Text,@"\w{8}");
            bool namechk = (txt_FirstName.Text != "") && (txt_LastName.Text != "");
            bool phonechk = Regex.IsMatch(txt_phone.Text, @"^09[0-9]{8}$");
            bool birthdaychk = dtp_birthday.Value <= age12;
            bool emailchk = Regex.IsMatch(txt_email.Text, @"^([\w\.\-]+)@([\w\.\-]+)\.[0-9a-zA-Z]{2,}$");
            bool addresschk = Regex.IsMatch(txt_address.Text, @"^\w+[縣市]\w+[路]*[0-9]{1,}[號]");
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
                blankmsg += "請輸入姓氏及名字\n";
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
            MessageBox.Show(blankmsg);
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            blankchk();
        }
    }
}
