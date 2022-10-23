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
    public partial class Form1 : Form
    {
        string strMyDBConnectionString = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //驗證碼
            create_checkNum();

            //連接momoDB
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();
        }

        void connectSQL()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select * from momo_member where member_account= @account;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@account", txtaccount.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                
            }
            else
            {
                MessageBox.Show("查無此人");
            }

            reader.Close();
            con.Close();
        }
        void clear()
        {

        }

        private void btn_changeChkNum_Click(object sender, EventArgs e)
        {
            //create_checkNum();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            // Ismatch_checkNum();
            SignUp SignUp = new SignUp();
            SignUp.ShowDialog();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            //Ismatch_checkNum();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
