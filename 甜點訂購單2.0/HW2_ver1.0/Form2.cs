using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HW2_ver1._0
{
    public partial class Form2 : Form
    {
        List<string> Payment = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (ArrayList customerInfo in codes.customerInfo)
            {//訂購人資訊

                string name = (string)customerInfo[0];
                string phone = (string)customerInfo[1];
                string package = (string)customerInfo[2];
                string delivery = (string)customerInfo[3];

                lb_name.Text = string.Format("姓名 {0}", name);
                lb_phone.Text = string.Format("手機 {0}", phone);
                lb_delivery.Text = string.Format("取貨方式 {0}", delivery);
                lb_package.Text = string.Format("包裝方式 {0}", package);
            }
            if(codes.BuyPuffs.Count > 0)
            {//泡芙訂單
                foreach (ArrayList BuyPuff in codes.BuyPuffs)
                {
                    string Flavor = (string)BuyPuff[0];
                    string selected = string.Format("泡芙口味：{0}", Flavor);
                    lbox_cartPuff.Items.Add(selected);
                }
            }
            
            if(codes.BuySweets.Count > 0)
            {//甜點訂單
                foreach (ArrayList buysweets in codes.BuySweets)
                {
                    string product = (string)buysweets[0];
                    int price = (int)buysweets[1];
                    int amount = (int)buysweets[2];
                    string selected = string.Format("{0} 數量{1}  總價{2}", product, amount, price * amount);
                    lbox_cartSweet.Items.Add(selected);
                }
            }
            
            //記總價
            cost_total(100);
        }

        void cost_total(int a)
        {//記總價

            int total = 0;

            if (codes.BuyPuffs.Count > 0)
            {
                total = codes.BuyPuffs.Count * 400; 
            }

            if (codes.BuySweets.Count > 0)
            {
                foreach (ArrayList buysweets in codes.BuySweets)
                {
                    int price = (int)buysweets[1];
                    int amount = (int)buysweets[2];

                    total += (price*amount);
                }
            }
            total = total + codes.additionPurchase;

            //折扣
            total = total * a / 100;
            lb_total.Text = total.ToString();
        }

        private void brtn_RemoveOne_Click(object sender, EventArgs e)
        {//清除一個品項

            if (lbox_cartPuff.SelectedIndex != -1)
            {
                int selindex = lbox_cartPuff.SelectedIndex;
                codes.BuyPuffs.RemoveAt(selindex);
                lbox_cartPuff.Items.RemoveAt(selindex);
                cost_total(100);
            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }
            
            if (lbox_cartSweet.SelectedIndex != -1)
            {
                int selindex = lbox_cartSweet.SelectedIndex;

                codes.BuySweets.RemoveAt(selindex);
                lbox_cartSweet.Items.RemoveAt(selindex);

                cost_total(100);
            }
            else
            {
                //MessageBox.Show("請選擇移除品項");
            }
            
            bool lboxchk = (lbox_cartPuff.Items.Count > 0) || (lbox_cartSweet.Items.Count > 0);
            if (lboxchk)
            {

            }
            else
            {
                MessageBox.Show("無選購任何商品，請重新填寫訂購單");
                codes.additionPurchase = 0;
                cost_total(100);
            }
        }

        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {//清除全部品項

            lbox_cartPuff.Items.Clear();
            lbox_cartSweet.Items.Clear();
            codes.BuyPuffs.Clear();
            codes.BuySweets.Clear();
            codes.additionPurchase = 0;
            cost_total(100);
            //MessageBox.Show("無選購任何商品，請重新填寫訂購單");
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {//折扣，僅得擇一折扣碼

            if (lb_total.Text != "0")
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
                if (txt_discount.Text == DateTime.Now.Month.ToString())
                {//我知道整數會無條件退位

                    MessageBox.Show("已獲得95折優惠");
                    cost_total(95);
                }
                if((txt_discount.Text != "好吃不胖") && (txt_discount.Text != "凸凸可愛") && (txt_discount.Text != "栗子可愛") && (txt_discount.Text != "巧克力球") && (txt_discount.Text != "金光閃閃巧克力球") && (txt_discount.Text != DateTime.Now.Month.ToString()))
                {
                    MessageBox.Show("折扣碼有誤");
                    cost_total(100);
                }
            }
            else
            {
                MessageBox.Show("無選購任何商品，請重新填寫訂購單");
            }

            
        }

        private void btn_order_Click(object sender, EventArgs e)
        {//送出訂單

            bool lboxchk = (lbox_cartPuff.Items.Count > 0)||(lbox_cartSweet.Items.Count > 0);
            bool rbtnchk = (rbtn_linepay.Checked == true)||(rbtn_trans.Checked == true)||(rbtn_cash.Checked == true);
            if(rbtnchk && lboxchk)
            { 
                MessageBox.Show("已收到您的訂單");
            }
            else if(rbtnchk == true && lboxchk == false)
            {
                MessageBox.Show("無選購任何商品，請重新填寫訂購單");
                codes.additionPurchase = 0;
                cost_total(100);
            }
            else if(lboxchk == true && rbtnchk == false)
            {
                MessageBox.Show("未選擇付款方式");
            }
            else
            {
                MessageBox.Show("請重新填寫訂購單");
                codes.additionPurchase = 0;
                cost_total(100);
            }
        }
    }
}
