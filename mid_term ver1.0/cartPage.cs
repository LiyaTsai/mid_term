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
    public partial class cartPage : Form
    {

        List<string> delivery = new List<string>();
        int additionPurchase = 0;
        public cartPage()
        {
            InitializeComponent();
        }

        private void cartPage_Load(object sender, EventArgs e)
        {
            //puff
            foreach (ArrayList BuyPuff in GlobalVar.G_puff)
            {
                string Flavor = (string)BuyPuff[0];
                string selected = string.Format("泡芙：{0}", Flavor);
                //lbox_cartPuff.Items.Add(selected);
                                lbox_cartSweet.Items.Add(selected);
            }

            //sweet
            foreach (ArrayList buysweets in GlobalVar.G_sweet)
            {
                string product = (string)buysweets[0];
                int price = (int)buysweets[1];
                int amount = (int)buysweets[2];
                string selected = string.Format("{0} 數量{1}  總價{2}", product, amount, price * amount);
                lbox_cartSweet.Items.Add(selected);
            }
            GlobalVar.G_user_info.Add("name", "mario");
            GlobalVar.G_user_info.Add("phone", "0987666444");

            lb_name.Text = GlobalVar.G_user_info["name"].ToString();
            lb_phone.Text = GlobalVar.G_user_info["phone"].ToString();

            //取貨方式
            delivery.Add("到店自取");
            delivery.Add("宅配到府$100");
            delivery.Add("冷凍宅配$200");

            foreach (string item in delivery)
            {//取貨選單
                cbox_delivery.Items.Add(item);
            }

            cost_total(100);
        }


        void cost_total(int a)
        {//記總價

            //計算加購
            additionPurchase = 0;
            if (cbox_delivery.SelectedIndex == 1)
            {
                additionPurchase = additionPurchase + 100;
            }
            if (cbox_delivery.SelectedIndex == 2)
            {
                additionPurchase = additionPurchase + 200;
            }
            if (rbtn_giftbag.Checked)
            {
                additionPurchase = additionPurchase + 20;
            }
            if (rbtn_giftbox.Checked)
            {
                additionPurchase = additionPurchase + 100;
            }

            int total = 0;
            if (GlobalVar.G_puff.Count > 0)
            {
                total = GlobalVar.G_puff.Count * 400;
            }

            if (GlobalVar.G_puff.Count > 0)
            {
                foreach (ArrayList buysweets in GlobalVar.G_sweet)
                {
                    int price = (int)buysweets[1];
                    int amount = (int)buysweets[2];

                    total += (price * amount);
                }
            }
            total = total + additionPurchase;

            //折扣
            total = total * a / 100;
            lb_total.Text = total.ToString();
        }

        private void brtn_RemoveOne_Click(object sender, EventArgs e)
        {//清除一個品項

            cost_total(100);
            if ((lbox_cartPuff.SelectedIndex == -1) && (lbox_cartSweet.SelectedIndex == -1))
            {
                MessageBox.Show("請選擇移除品項");
            }
            if ((lbox_cartPuff.SelectedIndex != -1) && (lbox_cartSweet.SelectedIndex != -1))
            {
                MessageBox.Show("您同時選擇泡芙及甜點了!!!");
                lbox_cartPuff.SelectedIndex = -1;
                lbox_cartSweet.SelectedIndex = -1;
            }
            if (lbox_cartPuff.SelectedIndex != -1)
            {
                int selindex = lbox_cartPuff.SelectedIndex;
                GlobalVar.G_puff.RemoveAt(selindex);
                lbox_cartPuff.Items.RemoveAt(selindex);
                cost_total(100);
            }
            if (lbox_cartSweet.SelectedIndex != -1)
            {
                int selindex = lbox_cartSweet.SelectedIndex;

                GlobalVar.G_sweet.RemoveAt(selindex);
                lbox_cartSweet.Items.RemoveAt(selindex);

                cost_total(100);
            }

            bool lboxchk = (lbox_cartPuff.Items.Count > 0) || (lbox_cartSweet.Items.Count > 0);
            if (lboxchk)
            {

            }
            else
            {
                MessageBox.Show("無選購任何商品，請重新填寫訂購單");
                additionPurchase = 0;
                cost_total(100);
            }
        }

        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {//清除全部品項

            lbox_cartPuff.Items.Clear();
            lbox_cartSweet.Items.Clear();
            GlobalVar.G_puff.Clear();
            GlobalVar.G_sweet.Clear();
            additionPurchase = 0;
            cost_total(100);
            //MessageBox.Show("無選購任何商品，請重新填寫訂購單");

        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            //折扣，僅得擇一折扣碼

            if (lb_total.Text != "0")
            {

                if ((txt_discount.Text != "好吃不胖") && (txt_discount.Text != "凸凸可愛") && (txt_discount.Text != "栗子可愛") && (txt_discount.Text != "巧克力球") && (txt_discount.Text != "金光閃閃巧克力球") && (txt_discount.Text != String.Format("{0}95", DateTime.Now.Month)))
                {
                    MessageBox.Show("折扣碼有誤");
                    cost_total(100);
                    txt_discount.Text = "";
                }
                else
                {
                    if (txt_discount.Text == "好吃不胖")
                    {
                        MessageBox.Show("已獲得9折優惠");
                        cost_total(90);
                    }
                    if (txt_discount.Text == "凸凸可愛")
                    {
                        MessageBox.Show("已獲得9折優惠");
                        cost_total(90);
                    }
                    if (txt_discount.Text == "栗子可愛")
                    {//私心，不解釋

                        MessageBox.Show("已獲得5折優惠");
                        cost_total(50);
                    }
                    if (txt_discount.Text == "巧克力球")
                    {
                        MessageBox.Show("已獲得9折優惠");
                        cost_total(90);
                    }
                    if (txt_discount.Text == "金光閃閃巧克力球")
                    {
                        MessageBox.Show("已獲得8折優惠");
                        cost_total(80);
                    }
                    if (txt_discount.Text == String.Format("{0}95", DateTime.Now.Month))
                    {//我知道整數會無條件退位

                        MessageBox.Show("已獲得95折優惠");
                        cost_total(95);
                    }
                    txt_discount.Text = "";
                }
            }
            else
            {
                MessageBox.Show("無選購任何商品，請重新填寫訂購單");
            }
        }

        private void cbox_delivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            cost_total(100);
        }

        private void rbtn_linepay_CheckedChanged(object sender, EventArgs e)
        {
            cost_total(100);
        }

        private void rbtn_trans_CheckedChanged(object sender, EventArgs e)
        {
            cost_total(100);
        }

        private void rbtn_cash_CheckedChanged(object sender, EventArgs e)
        {
            cost_total(100);
        }

        private void rbtn_basicPackage_CheckedChanged(object sender, EventArgs e)
        {
            cost_total(100);
        }

        private void rbtn_giftbag_CheckedChanged(object sender, EventArgs e)
        {
            cost_total(100);
        }

        private void rbtn_giftbox_CheckedChanged(object sender, EventArgs e)
        {
            cost_total(100);
        }


    }
}
