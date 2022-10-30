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

        private void btn_order_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            DateTime dateTime = DateTime.Now;
            string order_id = "";
            order_id = dateTime.Year.ToString() + dateTime.Month.ToString() + dateTime.Day.ToString() + dateTime.Hour.ToString() + dateTime.Minute.ToString() + dateTime.Second.ToString() + random.Next(1000 + 9999).ToString();
            Console.WriteLine(order_id);

            if (lbox_cartPuff.Items.Count > 0)
            {
                //先把泡芙放到甜點裡
                Console.WriteLine("there is puff in cart");
                ArrayList buySweets = new ArrayList();
                buySweets.Add(101);
                buySweets.Add("泡芙(綜合)");
                buySweets.Add(400);
                buySweets.Add(lbox_cartPuff.Items.Count);
                GlobalVar.G_sweet.Add(buySweets);


                foreach (ArrayList BuyPuff in GlobalVar.G_puff)
                {
                    string Flavor = (string)BuyPuff[0];
                    Console.WriteLine("foreach:" + Flavor);
                    SqlConnection con = new SqlConnection(strMyDBConnectionString);
                    con.Open();
                    Console.WriteLine("Con.open");
                    string strSQL = @"select * from puffFlavor where puffFlavor_name = '@myflavor'";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@myflavor", Flavor);
                    SqlDataReader reader = cmd.ExecuteReader();
                    

                    while (reader.Read())
                    {
                        PID = Convert.ToInt32(reader["puffFlavor_ID"]);
                        Console.WriteLine( "PID: " + PID);
                    }
                    reader.Close();
                    con.Close();
                }
            }

            if (lbox_cartSweet.Items.Count > 0)
            {
                Console.WriteLine("there is sweets in cart");
                

                foreach (ArrayList BuySweet in GlobalVar.G_sweet)
                {
                    
                    int SweetID = (int)BuySweet[0];
                    int d_price = (int)BuySweet[2] * discount;
                    Console.WriteLine("foreach sweetID: " + SweetID);
                    Console.WriteLine("foreach price: " + d_price);

                    SqlConnection con = new SqlConnection(strMyDBConnectionString);
                    con.Open();
                    Console.WriteLine("Con.open");
                    string strSQL = @"insert dessertOrder( dessertOrder_ID, member_ID, dessert_ID, dessert_amount, dessert_price, puffFlavor_ID, puffFlavor) values ( @dessertOrder_ID, @member_ID, @dessert_ID, @dessert_amount, @dessert_price, @puffFlavor_ID, @puffFlavor)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@dessertOrder_ID", order_id);
                    cmd.Parameters.AddWithValue("@member_ID", GlobalVar.G_user_info[0]);
                    cmd.Parameters.AddWithValue("@dessert_ID", SweetID);
                    cmd.Parameters.AddWithValue("@dessert_amount", GlobalVar.G_user_info[3]);
                    cmd.Parameters.AddWithValue("@dessert_price", d_price);
                    cmd.Parameters.AddWithValue("@puffFlavor_ID", PID);
                    //cmd.Parameters.AddWithValue("@puffFlavor", );

                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    con.Close();
                }
            }


            /*
            string strSQL2 = @"insert dessertOrder( dessertOrder_ID, member_ID, dessert_ID, dessert_price, puffFlavor_ID, puffFlavor) values ( '@dessertOrder_ID', @member_ID, @dessert_ID, @dessert_price, @puffFlavor_ID, @puffFlavor)";
                        SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                        cmd2.Parameters.AddWithValue("@dessertOrder_ID", random);
                        cmd2.Parameters.AddWithValue("@member_ID", GlobalVar.G_user_info[0]);
                        cmd2.Parameters.AddWithValue("@dessert_ID", );
                        cmd2.Parameters.AddWithValue("@dessertOrder_ID", Flavor);
                        Console.WriteLine("com:" + Flavor);
                        SqlDataReader reader2 = cmd2.ExecuteReader();

                        int rows = cmd2.ExecuteNonQuery();
                        MessageBox.Show("加入" + rows + "盒泡芙", "訂單");
                        reader2.Close();
                        con.Close();
                    }

                }
            }*/
            
            

            /*SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "insert dessertOrder( dessertOrder_ID, member_ID, dessert_ID, dessert_price,) values ( @dessertOrder_ID, @member_ID, @dessert_ID, @dessert_price )";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@dessertOrder_ID", order_id);
            cmd.Parameters.AddWithValue("@member_ID", GlobalVar.G_user_info[0]);
            cmd.Parameters.AddWithValue("@dessert_ID", GlobalVar.G_sweet[0]);
            cmd.Parameters.AddWithValue("@dessert_price", GlobalVar.G_sweet[2]);



            int rows = cmd.ExecuteNonQuery();
            MessageBox.Show("資料儲存成功, 影響" + rows + "筆資料", "註冊成功");

            //MessageBox.Show("註冊成功，請登入會員","註冊成功");

            con.Close();       */    

        }
    }
}
