using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_ver1._0
{
    public partial class Form1 : Form
    {
        //表單設計依據我的真實需求再做調整
        Dictionary<string, int> sweetProduct = new Dictionary<string, int>();
        //List<string> product = new List<string>();
        //List<int> price = new List<int>();
        List<string> delivery = new List<string>();

        public string myname ;
        public string myphone ;
        //public string myflavor;
        public string myproduct = "未選購甜點";
        public int myprice = 0;
        public string mydelivery = "未選擇取貨方式";
        public string mypackage = "基本包裝";
        public int myamount = 1;

        int sweetprice = 0;
        int puffprice;
        int additionPurchase;
        int sweet_total = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //甜點清單//我成功換成dictionary了!!!
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

            //取貨方式
            delivery.Add("到店自取");
            delivery.Add("宅配到府$100");
            delivery.Add("冷凍宅配$200");


            foreach(KeyValuePair<string, int> kvp in sweetProduct)
            {
                string kvpsp = kvp.Key + "         $" + kvp.Value;
                lbox_product.Items.Add(kvpsp);
            }

            foreach (string item in delivery)
            {//取貨選單

                cbox_delivery.Items.Add(item);
            }
        }
            
        void cost()
        {//計價

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
                mypackage = "提袋$20";
                additionPurchase = additionPurchase + 20;
            }
            if (rbtn_giftbox.Checked)
            {
                mypackage = "禮盒$100";
                additionPurchase = additionPurchase + 100;
            }
            puffprice = 400 * (codes.BuyPuffs.Count);

            //計算甜點
            int product_index = lbox_product.SelectedIndex;
            if (product_index == -1)
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
            lb_total1.Text = Convert.ToString(additionPurchase + puffprice + sweet_total + sweetprice );
        }
          
        private void cbox_delivery_SelectedIndexChanged(object sender, EventArgs e)
        {//選擇配送方法
            cost();
        }
        private void rbtn_giftbag_CheckedChanged(object sender, EventArgs e)
        {//加購提袋
            cost();
        }

        private void rbtn_giftbox_CheckedChanged(object sender, EventArgs e)
        {//加購禮盒
            cost();
        }

        private void lbox_product_SelectedIndexChanged(object sender, EventArgs e)
        {//選擇甜點品項並計價

            if(lbox_product.SelectedIndex != -1)
            {                 
                lb_unitprice.Text = String.Format($"{sweetProduct.ElementAt(lbox_product.SelectedIndex).Value}");
                cost();
            }            
        }

        private void num_productamount_ValueChanged(object sender, EventArgs e)
        {//選擇甜點數量

            cost();
        }

        private void btn_addpuff_Click(object sender, EventArgs e)
        {//選購泡芙

            //紀錄口味
            ArrayList buypuff = new ArrayList();
            string  myflavor = "";
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
                codes.BuyPuffs.Add(buypuff);

                //計價 
                puffprice = 400 * (codes.BuyPuffs.Count);

                cost();
                lb_puffamount.Text = string.Format("已選購{0}盒泡芙，共{1}元", codes.BuyPuffs.Count, puffprice);
                puff_rbtn_clean();
            }
        }
        
        void puff_rbtn_clean()
        {//清除泡芙選項

            ckb_vanilla.Checked = false;
            ckb_chocolate.Checked = false;
            ckb_earlgrey.Checked = false;
            ckb_strawberrycheese.Checked = false;
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            bool sweetchk = (lbox_product.SelectedIndex != -1) && (num_productamount.Value != 0);

            if (sweetchk)
            {//紀錄甜點

                myproduct = sweetProduct.ElementAt(lbox_product.SelectedIndex).Key;
                myprice = sweetProduct.ElementAt(lbox_product.SelectedIndex).Value;
                myamount = Convert.ToInt32(num_productamount.Value);
                sweet_total = Convert.ToInt32(lb_total1.Text) - puffprice - additionPurchase;

                //global var
                ArrayList buySweets = new ArrayList();
                buySweets.Add(myproduct);
                buySweets.Add(myprice);
                buySweets.Add(myamount);
                codes.BuySweets.Add(buySweets);
            }
            else
            {
                MessageBox.Show("未選購甜點"); 
            }

            //清空選單
            sweet_choice_clean();
        }

        void sweet_choice_clean()
        {
            num_productamount.Value = 0;
            lbox_product.SelectedIndex = -1;
            lb_subtotal.Text = "";
            lb_unitprice.Text = "";
            num_productamount.Value = 1;
        }

        private void btn_form2_Click(object sender, EventArgs e)
        {//準備開form2

            //儲存訂購人資訊
            myname = txt_name.Text;
            myphone = txt_phone.Text;
            if (cbox_delivery.SelectedIndex == 0)
            {
                mydelivery = "到店自取";
            }
            else if (cbox_delivery.SelectedIndex == 1)
            {
                mydelivery = "宅配到府$100";
            }
            else if (cbox_delivery.SelectedIndex == 2)
            {
                mydelivery = "冷凍宅配$200";
            }
            else
            {
                mydelivery = "未選擇運送方式";
            }

            //global var
            ArrayList customerInfo = new ArrayList();
            customerInfo.Add(myname);
            customerInfo.Add(myphone);
            customerInfo.Add(mypackage);
            customerInfo.Add(mydelivery);
            codes.customerInfo.Add(customerInfo);
            codes.additionPurchase = additionPurchase;

            //忘記加入購物車//多了直接加入購物車的功能
            while (true)
            {
                bool PuffToCart = ((ckb_chocolate.Checked == false) && (ckb_earlgrey.Checked == false) && (ckb_strawberrycheese.Checked == false) && (ckb_vanilla.Checked == false));
                bool SweetToCart = (lbox_product.SelectedIndex == -1) && (num_productamount.Value == 1);

                if (PuffToCart == false)
                {
                    DialogResult R;
                    R = MessageBox.Show("勾選的泡芙似乎未加入購物車～\n是否要加入購物車", "購物車確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        btn_addpuff_Click(null, null);
                    }
                    else
                    {
                        puff_rbtn_clean();
                    }
                }
                if (SweetToCart == false)
                {
                    DialogResult R;
                    R = MessageBox.Show("選擇的甜點似乎未加入購物車～\n是否要加入購物車", "購物車確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        btn_addproduct_Click(null, null);
                    }
                    else
                    {
                        sweet_choice_clean();
                    }
                }
                if (PuffToCart && SweetToCart)
                {
                    blankschk_form2();
                    break;
                }
            }
        }
            
        

        void blankschk_form2()//先關掉防呆檢查，只留開form2
        {//防呆檢查後開form2

            /*string blankmsg = "";
            bool namechk = (txt_name.Text != "");
            bool phonechk = Regex.IsMatch(txt_phone.Text, @"^09[0-9]{8}$");
            bool deliverychk = (cbox_delivery.SelectedIndex != -1);
            bool packagechk = (radioButton1.Checked == true) || (rbtn_giftbag.Checked == true) || (rbtn_giftbox.Checked == true);

            if (namechk)
            {

            }
            else
            {
                blankmsg += "請輸入姓名\n";
            }
            if (phonechk)
            {

            }
            else
            {
                blankmsg += "手機號碼不正確\n";
            }
            if (deliverychk)
            {

            }
            else
            {
                blankmsg += "請選擇取貨方式\n";
            }
            if (packagechk)
            {

            }
            else
            {
                blankmsg += "請選擇包裝方式\n";
            }
            if (blankmsg != "")
            {
                MessageBox.Show(blankmsg);
            }
            else
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }*/
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
