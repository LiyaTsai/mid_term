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
    public partial class BuySweetPage : Form
    {
        Dictionary<string, int> sweetProduct = new Dictionary<string, int>();
        public int myprice = 0;
        public int myamount = 1;
        public string myproduct = "未選購甜點";
        int sweetprice = 0;
        int sweet_total = 0;
        public BuySweetPage()
        {
            InitializeComponent();
        }

        private void BuySweetPage_Load(object sender, EventArgs e)
        {
            //甜點品項
            sweetProduct.Add("cheese餅餅(罐)", 220);
            sweetProduct.Add("波卡米餅(罐)", 200);
            sweetProduct.Add("蔓越莓司康(6入)", 350);
            sweetProduct.Add("百香可可旅人蛋糕(5入)", 350);
            sweetProduct.Add("裝熟乳酪(5入)", 350);
            sweetProduct.Add("金光閃閃巧克力球(10入)", 250);
            sweetProduct.Add("粉紅泡泡巧克力球(10入)", 300);
            sweetProduct.Add("天使之鈴可麗露(6入)", 450);
            sweetProduct.Add("檸夏檸檬塔(顆)", 90);
            sweetProduct.Add("檸檬瑪德蓮(6入)", 270);
            sweetProduct.Add("酒鬼先生提拉米蘇", 520);
            sweetProduct.Add("芒果乳酪蛋糕盒", 450);

            foreach (KeyValuePair<string, int> kvp in sweetProduct)
            {
                string kvpsp = kvp.Key + "         $" + kvp.Value;
                lbox_product.Items.Add(kvpsp);
            }
        }
        void cost()
        {
            if (lbox_product.SelectedIndex == -1)
            {
                sweetprice = 0;
            }
            else
            {
                myproduct = sweetProduct.ElementAt(lbox_product.SelectedIndex).Key;
                myprice = sweetProduct.ElementAt(lbox_product.SelectedIndex).Value;
                myamount = Convert.ToInt32(num_productamount.Value);
                sweetprice = sweetProduct.ElementAt(lbox_product.SelectedIndex).Value * Convert.ToInt32(num_productamount.Value);
            }
            lb_subtotal.Text = Convert.ToString(sweetprice);
            lb_total1.Text = Convert.ToString(400 * (GlobalVar.G_puff.Count) + sweet_total + sweetprice);
        }

        private void lbox_product_SelectedIndexChanged(object sender, EventArgs e)
        {//選擇甜點品項並計價

            if (lbox_product.SelectedIndex != -1)
            {
                lb_unitprice.Text = String.Format($"{sweetProduct.ElementAt(lbox_product.SelectedIndex).Value}");
                cost();
            }
        }

        private void num_productamount_ValueChanged(object sender, EventArgs e)
        {
            cost();
        }

        private void btn_addsweet_Click(object sender, EventArgs e)
        {
            bool sweetchk = (lbox_product.SelectedIndex != -1) && (num_productamount.Value != 0);

            if (sweetchk)
            {//紀錄甜點

                myproduct = sweetProduct.ElementAt(lbox_product.SelectedIndex).Key;
                myprice = sweetProduct.ElementAt(lbox_product.SelectedIndex).Value;
                myamount = Convert.ToInt32(num_productamount.Value);
                sweet_total = Convert.ToInt32(lb_total1.Text) - 400*(GlobalVar.G_puff.Count);

                //global var
                ArrayList buySweets = new ArrayList();
                buySweets.Add(myproduct);
                buySweets.Add(myprice);
                buySweets.Add(myamount);
                GlobalVar.G_sweet.Add(buySweets);
            }
            else
            {
                MessageBox.Show("未選購甜點");
            }

            //清空選單
            sweet_choice_clean();

            lbox_cartSweet.Items.Clear();
            foreach (ArrayList buysweets in GlobalVar.G_sweet)
            {
                string product = (string)buysweets[0];
                int price = (int)buysweets[1];
                int amount = (int)buysweets[2];
                string selected = string.Format("{0} 數量{1}  總價{2}", product, amount, price * amount);
                lbox_cartSweet.Items.Add(selected);
            }
        }

        void sweet_choice_clean()
        {
            num_productamount.Value = 0;
            lbox_product.SelectedIndex = -1;
            lb_subtotal.Text = "";
            lb_unitprice.Text = "";
            num_productamount.Value = 1;
        }

        private void btn_puffPage_Click(object sender, EventArgs e)
        {
            while (true)
            {
                bool SweetToCart = (lbox_product.SelectedIndex == -1);

                if (SweetToCart == false)
                {
                    DialogResult R;
                    R = MessageBox.Show("選擇的甜點似乎未加入購物車～\n是否要加入購物車", "購物車確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        btn_addsweet_Click(null, null);
                    }
                    else
                    {
                        sweet_choice_clean();
                    }
                }
                if (SweetToCart)
                {
                    BuyPuffPage buyPuffPage = new BuyPuffPage();
                    buyPuffPage.Show();
                    this.Close();

                    break;
                }
            }



        }
    }
}
