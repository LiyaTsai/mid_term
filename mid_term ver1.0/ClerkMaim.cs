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
    public partial class ClerkMaim : Form
    {
        public ClerkMaim()
        {
            InitializeComponent();
        }

        private void ClerkMaim_Load(object sender, EventArgs e)
        {

        }

        private void lb_orderlist_Click(object sender, EventArgs e)
        {
            OrderALL orderALL = new OrderALL();
            orderALL.ShowDialog(); 
        }

        private void lb_goBuyPuffPage_Click(object sender, EventArgs e)
        {

        }



        private void lb_goMemberInfo_Click(object sender, EventArgs e)
        {
            MemberInfo memberInfo = new MemberInfo();
            memberInfo.ShowDialog();
        }

        private void lb_goManage_Click(object sender, EventArgs e)
        {
             addSweet addSweet = new addSweet();
            addSweet.Show();
        }
    }
}
