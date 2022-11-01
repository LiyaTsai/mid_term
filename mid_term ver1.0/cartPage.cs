using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_term_ver1._0
{
    public partial class cartPage : Form
    {
        string strMyDBConnectionString = "";
        List<string> delivery = new List<string>();
        int additionPurchase = 0;
        int PID = 0;
        int discount = 100;
        List<string> Flavor = new List<string>();
        //List<string> listPuffFlavor = new List<string>();
        
        int M_ID = (int)GlobalVar.G_user_info["ID"];
        string PuffOID = "";
        string SweetOID = "";


        public cartPage()
        {
            InitializeComponent();
        }

        private void cartPage_Load(object sender, EventArgs e)
        {
            Console.WriteLine("CartPage");
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();

            //puff
            foreach (ArrayList BuyPuff in GlobalVar.G_puff)
            {
                string Flavor = (string)BuyPuff[0];
                string selected = string.Format("泡芙：{0}", Flavor);
                //lbox_cartPuff.Items.Add(selected);
                lbox_cartPuff.Items.Add(selected);
            }
            

            //sweet
            foreach (ArrayList buysweets in GlobalVar.G_sweet)
            {
                string product = (string)buysweets[1];
                int price = (int)buysweets[2];
                int amount = (int)buysweets[3];
                string selected = string.Format("{0} 數量{1}  總價{2}", product, amount, price * amount);
                lbox_cartSweet.Items.Add(selected);                
            }

            lb_name.Text = GlobalVar.G_user_info["name"].ToString();
            lb_phone.Text = GlobalVar.G_user_info["phone"].ToString();
            txt_address.Text = GlobalVar.G_user_info["address"].ToString();
            lb_address.Visible=false;
            txt_address.Visible=false;

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
                total = GlobalVar.G_puff.Count * 400 * a / 100;
            }

            if (GlobalVar.G_sweet.Count > 0)
            {
                foreach (ArrayList buysweets in GlobalVar.G_sweet)
                {
                    int price = (int)buysweets[2];
                    int amount = (int)buysweets[3];

                    int sub = (price * amount);
                    total = total + (sub * a / 100);

                    Console.WriteLine("sub * discount: " + sub * a / 100);
                }
            }
            total = total + additionPurchase;

            //折扣
            lb_total.Text = total.ToString();

        }

        private void brtn_RemoveOne_Click(object sender, EventArgs e)
        {//清除一個品項

            cost_total(100);
            if ((lbox_cartPuff.SelectedIndex == -1)&&(lbox_cartSweet.SelectedIndex == -1))
            {
                MessageBox.Show("請選擇移除品項");
            }
            else if ((lbox_cartPuff.SelectedIndex != -1)&& (lbox_cartSweet.SelectedIndex != -1))
            {
                MessageBox.Show("一次移除一個品項");
            }
            else if (lbox_cartSweet.SelectedIndex != -1)
            {
                int selindex = lbox_cartSweet.SelectedIndex;

                GlobalVar.G_sweet.RemoveAt(selindex);
                lbox_cartSweet.Items.RemoveAt(selindex);

                cost_total(100);
            }
            else if (lbox_cartPuff.SelectedIndex != -1)
            {
                int selindex = lbox_cartPuff.SelectedIndex;

                GlobalVar.G_puff.RemoveAt(selindex);
                lbox_cartPuff.Items.RemoveAt(selindex);

                cost_total(100);
            }

            bool lboxchk = (lbox_cartSweet.Items.Count > 0)|| (lbox_cartPuff.Items.Count > 0);
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
                        discount = 90;
                    }
                    if (txt_discount.Text == "凸凸可愛")
                    {
                        MessageBox.Show("已獲得9折優惠");
                        cost_total(90);
                        discount = 90;
                    }
                    if (txt_discount.Text == "栗子可愛")
                    {//私心，不解釋

                        MessageBox.Show("已獲得5折優惠");
                        cost_total(50);
                        discount = 50;
                    }
                    if (txt_discount.Text == "巧克力球")
                    {
                        MessageBox.Show("已獲得9折優惠");
                        cost_total(90);
                        discount = 90;
                    }
                    if (txt_discount.Text == "金光閃閃巧克力球")
                    {
                        MessageBox.Show("已獲得8折優惠");
                        cost_total(80);
                        discount = 80;
                    }
                    if (txt_discount.Text == String.Format("{0}95", DateTime.Now.Month))
                    {//我知道整數會無條件退位

                        MessageBox.Show("已獲得95折優惠");
                        cost_total(95);
                        discount = 95;
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
            if (cbox_delivery.SelectedIndex > 0)
            {
                txt_address.Text = GlobalVar.G_user_info["address"].ToString();
                lb_address.Visible = true;
                txt_address.Visible = true;
                txt_address.Enabled = true;
            }
            if (cbox_delivery.SelectedIndex == 0)
            {
                txt_address.Text = "甜點工作室在橋頭";
                txt_address.Enabled = false;
                lb_address.Visible = true;
                txt_address.Visible = true;
            }
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

        void order_chk( out int a)
        {
            a = 0;
            bool deliverychk = (cbox_delivery.SelectedIndex != -1) && (txt_address.Text != "");
            bool paymentchk = (rbtn_cash.Checked = true) || (rbtn_linepay.Checked = true) || (rbtn_trans.Checked = true);
            bool packagechk = (rbtn_basicPackage.Checked = true) || (rbtn_giftbag.Checked = true) || (rbtn_giftbox.Checked = true);
            string chkmsg = "";
            if(deliverychk)
            {

            }else
            {
                chkmsg += "請選擇取貨方式";
            }
            if(paymentchk)
            { }
            else
            {
                chkmsg += "請選擇付款方式";
            }
            if(packagechk)
            {

            }
            else
            {
                chkmsg += "請選擇包裝";
            }
            if (chkmsg == "")
            {
                a = 1;
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            order_chk(out int a);
            if(a == 1)
            {
                DateTime dateTime = DateTime.Now;
                string order_id = dateTime.ToString("yyyyMMddHHmmssff");
                Random rndguid = new Random(Guid.NewGuid().GetHashCode());
                order_id = order_id + rndguid.Next(1000, 9999).ToString();
                GlobalVar.G_order_id = order_id;

                puffOrder();
                dessertOrder();

                strDelivery(out string strdelivery);
                strPayment(out string strpayment);
                strPackage(out string strpackage);

                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                Console.WriteLine("memberOrder");
                string strSQL = @"insert memberOrder (memberOrder_ID, member_ID, memberOrder_delivery, memberOrder_address, memberOrder_payment, memberOrder_package, memberOrder_totalPrice ) values (@memberOrder_ID, @member_ID, @memberOrder_delivery, @memberOrder_address, @memberOrder_payment, @memberOrder_package, @memberOrder_totalPrice)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@memberOrder_ID", order_id);
                cmd.Parameters.AddWithValue("@member_ID", M_ID);
                cmd.Parameters.AddWithValue("@memberOrder_delivery", strdelivery);
                cmd.Parameters.AddWithValue("@memberOrder_address", txt_address.Text);
                cmd.Parameters.AddWithValue("@memberOrder_payment", strpayment);
                cmd.Parameters.AddWithValue("@memberOrder_package", strpackage);
                cmd.Parameters.AddWithValue("@memberOrder_totalPrice", lb_total.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    MessageBox.Show("訂購完成");
                    btn_RemoveAll_Click(null, null);
                }
                reader.Close();
                con.Close();
            }
            this.Close();
        }

        void strDelivery(out string strdelivery)
        {
            string _strdelivery = "";
            if (cbox_delivery.SelectedIndex == 0)
            {
                _strdelivery = "到店自取";
            }
            if (cbox_delivery.SelectedIndex == 1)
            {
                _strdelivery = "宅配到府$100";
            }
            if (cbox_delivery.SelectedIndex == 2)
            {
                _strdelivery = "冷凍宅配$200";
            }
            strdelivery = _strdelivery;
        }

        void strPayment(out string strpayment)
        {
            string _strpayment = "";
            if (rbtn_cash.Checked == true)
            {
                _strpayment = "付現";
            }
            if (rbtn_linepay.Checked == true)
            {
                _strpayment = "Line Pay";
            }
            if (rbtn_trans.Checked == true)
            {
                _strpayment = "匯款";
            }
            strpayment = _strpayment;
        }

        void strPackage(out string strpackage)
        {
            string _strpackage = "";
            if (rbtn_basicPackage.Checked == true)
            {
                _strpackage = "基本包裝";
            }
            if (rbtn_giftbag.Checked == true)
            {
                _strpackage = "禮物袋";
            }
            if (rbtn_giftbox.Checked == true)
            {
                _strpackage = "禮物盒";
            }
            strpackage = _strpackage;
        }


        void puffOrder()
        {
            string order_id = GlobalVar.G_order_id;

            if (lbox_cartPuff.Items.Count > 0)
            {
                foreach (ArrayList BuyPuff in GlobalVar.G_puff)
                {
                    string Flavor = (string)BuyPuff[0];
                    int PID = (int)BuyPuff[2];
                    int puffOrder_dis_price = 400 * discount / 100;

                    //Console.WriteLine("foreach:" + Flavor);
                    SqlConnection con = new SqlConnection(strMyDBConnectionString);
                    con.Open();
                    Console.WriteLine("Con.open");
                    string strSQL = "insert puffOrder( puffOrder_ID, member_ID, puffFlavor_ID, puffOrder_flavor, puffOrder_dis_price) values ( @puffOrder_ID, @member_ID, @puffFlavor_ID, @puffOrder_flavor, @puffOrder_dis_price)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@puffOrder_ID", order_id);
                    cmd.Parameters.AddWithValue("@puffOrder_flavor", Flavor);
                    cmd.Parameters.AddWithValue("@member_ID", M_ID);
                    cmd.Parameters.AddWithValue("@puffFlavor_ID", PID);
                    cmd.Parameters.AddWithValue("@puffOrder_dis_price", puffOrder_dis_price);
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    con.Close();
                }
            }
        }

        void dessertOrder()
        {
            string order_id = GlobalVar.G_order_id;
            if (lbox_cartSweet.Items.Count > 0)
            {
                Console.WriteLine("there is sweets in cart");

                foreach (ArrayList BuySweet in GlobalVar.G_sweet)
                {

                    int SweetID = (int)BuySweet[0];
                    int d_price = (int)BuySweet[2] * discount / 100;
                    int D_amount = (int)BuySweet[3];
                    Console.WriteLine("foreach sweetID: " + SweetID);
                    Console.WriteLine("foreach price: " + d_price);

                    SqlConnection con = new SqlConnection(strMyDBConnectionString);
                    con.Open();
                    Console.WriteLine("Con.open");
                    string strSQL = @"insert dessertOrder( dessertOrder_ID, member_ID, dessert_ID, dessert_amount, dessert_dis_price) values ( @dessertOrder_ID, @member_ID, @dessert_ID, @dessert_amount, @dessert_dis_price)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@dessertOrder_ID", order_id);
                    cmd.Parameters.AddWithValue("@member_ID", M_ID);
                    cmd.Parameters.AddWithValue("@dessert_ID", SweetID);
                    cmd.Parameters.AddWithValue("@dessert_amount", D_amount);
                    cmd.Parameters.AddWithValue("@dessert_dis_price", d_price);
                    //cmd.Parameters.AddWithValue("@puffFlavor_ID", 0);                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                    }
                    reader.Close();
                    con.Close();
                }
            }
        }


    }
}
