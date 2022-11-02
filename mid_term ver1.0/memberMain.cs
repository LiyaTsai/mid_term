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
    public partial class memberMain : Form
    {
        public memberMain()
        {
            InitializeComponent();
        }

        private void memberMain_Load(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            CenterToScreen();

        }

        private void lb_goBuySweetPage_Click(object sender, EventArgs e)
        {
            BuySweetPage buySweetPage = new BuySweetPage();
            buySweetPage.Show();
        }

        private void lb_goBuyPuffPage_Click(object sender, EventArgs e)
        {
            BuyPuffPage buyPuffPage = new BuyPuffPage();
            buyPuffPage.Show();
        }

        private void lb_orderlist_Click(object sender, EventArgs e)
        {
            OrderMember orderMember = new OrderMember();
            orderMember.Show();
        }
    }
}
