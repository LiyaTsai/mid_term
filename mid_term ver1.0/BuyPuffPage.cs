using System;
using System.Collections;
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
    public partial class BuyPuffPage : Form
    {
        public BuyPuffPage()
        {
            InitializeComponent();
        }

        private void BuyPuff_Load(object sender, EventArgs e)
        {

        }

        private void btn_addpuff_Click(object sender, EventArgs e)
        {//選購泡芙

            //紀錄口味
            ArrayList buypuff = new ArrayList();
            string myflavor = "";
            if (ckb_strawberrycheese.Checked == true)
            {
                myflavor += ("[草莓起司]");
            }
            if (ckb_earlgrey.Checked == true)
            {
                myflavor += ("[伯爵茶]");
            }
            if (ckb_vanilla.Checked == true)
            {
                myflavor += ("[香草奶油]");
            }
            if (ckb_chocolate.Checked == true)
            {
                myflavor += ("[香濃可可]");
            }

            if ((ckb_chocolate.Checked == true) && (ckb_earlgrey.Checked == true) && (ckb_strawberrycheese.Checked == true) && (ckb_vanilla.Checked == true))
            {
                MessageBox.Show("至多選3種口味喔");
                puff_rbtn_clean();
            }
            else if ((ckb_chocolate.Checked == false) && (ckb_earlgrey.Checked == false) && (ckb_strawberrycheese.Checked == false) && (ckb_vanilla.Checked == false))
            {
                MessageBox.Show("沒有選擇泡芙口味喔");
            }
            else
            {
                //儲存泡芙口味到global var
                buypuff.Add(myflavor);
                GlobalVar.G_puff.Add(buypuff);

                //計價 
                lb_puffamount.Text = string.Format("已選購{0}盒泡芙，共{1}元", GlobalVar.G_puff.Count, 400 * (GlobalVar.G_puff.Count));
                puff_rbtn_clean();
            }

            lbox_cartPuff.Items.Clear();
            foreach (ArrayList BuyPuff in GlobalVar.G_puff)
            {
                string Flavor = (string)BuyPuff[0];
                string selected = string.Format("第{0}盒泡芙：{1}",lbox_cartPuff.Items.Count+1, Flavor);
                lbox_cartPuff.Items.Add(selected);
            }

        }

        void puff_rbtn_clean()
        {//清除泡芙選項

            ckb_vanilla.Checked = false;
            ckb_chocolate.Checked = false;
            ckb_earlgrey.Checked = false;
            ckb_strawberrycheese.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //檢查未買

            //轉跳到甜點
            BuySweetPage buySweetPage = new BuySweetPage();
            buySweetPage.Show();
            this.Close();
        }
    }
}
