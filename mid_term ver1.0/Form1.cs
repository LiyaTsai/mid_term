using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_term_ver1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            create_checkNum();
        }

        private void btn_changeChkNum_Click(object sender, EventArgs e)
        {
            create_checkNum();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            Ismatch_checkNum();
            SignUp SignUp = new SignUp();
            SignUp.ShowDialog();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            Ismatch_checkNum();
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
