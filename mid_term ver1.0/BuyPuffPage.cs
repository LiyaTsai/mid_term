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
    public partial class BuyPuffPage : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";

        public BuyPuffPage()
        {
            InitializeComponent();
        }

        private void BuyPuff_Load(object sender, EventArgs e)
        {
            
            //連接momoDB
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            foreach (ArrayList BuyPuff in GlobalVar.G_puff)
            {
                string Flavor = (string)BuyPuff[0];
                string selected = string.Format("泡芙：{0}", Flavor);
                //lbox_cartPuff.Items.Add(selected);
                lbox_cartPuff.Items.Add(selected);
            }

        }

        private void btn_addpuff_Click(object sender, EventArgs e)
        {//選購泡芙

            //紀錄口味
            ArrayList buypuff = new ArrayList();
            string myflavor = "";
            int myflavorCount=0;//口味數


            if (ckb_strawberrycheese.Checked == true)
            {
                myflavor += ("[草莓起司]");
                myflavorCount++;
            }
            if (ckb_earlgrey.Checked == true)
            {
                myflavor += ("[伯爵茶]");
                myflavorCount++;

            }
            if (ckb_vanilla.Checked == true)
            {
                myflavor += ("[香草奶油]");
                myflavorCount++;
            }
            if (ckb_chocolate.Checked == true)
            {
                myflavor += ("[香濃可可]");
                myflavorCount++;
            }

            Console.WriteLine(myflavor);
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
                //甜點品項
                int PID = 0;
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                Console.WriteLine(myflavor);
                string strSQL = @"select * from puffFlavor where puffFlavor_name = @myflavor ;"; 
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@myflavor", myflavor);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PID = (int)reader["puffFlavor_ID"];
                    //當目前沒有資料時，嘗試讀取無效
                }
                Console.WriteLine("PID: "　+ PID);

                //儲存泡芙口味到global var
                Console.WriteLine(myflavor);
                buypuff.Add(myflavor);
                buypuff.Add(myflavorCount);
                buypuff.Add(PID);
                GlobalVar.G_puff.Add(buypuff);

                //計價 
                lb_puffamount.Text = string.Format("已選購{0}盒泡芙，共{1}元", GlobalVar.G_puff.Count, 400 * (GlobalVar.G_puff.Count));
                puff_rbtn_clean();
            }

            lbox_cartPuff.Items.Clear();
            foreach (ArrayList BuyPuff in GlobalVar.G_puff)
            {
                string Flavor = (string)BuyPuff[0];
                int flavorCount = (int)BuyPuff[1];
                string selected = string.Format("第{0}盒泡芙，共{1}種口味: {2}",lbox_cartPuff.Items.Count+1,flavorCount, Flavor);
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


        private void sweetPage_Click(object sender, EventArgs e)
        {
            //檢查未買
            while (true)
            {
                bool PuffToCart = ((ckb_chocolate.Checked == false) && (ckb_earlgrey.Checked == false) && (ckb_strawberrycheese.Checked == false) && (ckb_vanilla.Checked == false));

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

                if (PuffToCart)
                {
                    //轉跳到甜點
                    BuySweetPage buySweetPage = new BuySweetPage();
                    buySweetPage.Show();
                    this.Close();

                    break;
                }
            }
        }

        
        private void btn_menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void btn_goToCart_Click(object sender, EventArgs e)
        {
            while (true)
            {
                bool PuffToCart = ((ckb_chocolate.Checked == false) && (ckb_earlgrey.Checked == false) && (ckb_strawberrycheese.Checked == false) && (ckb_vanilla.Checked == false));

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

                if (PuffToCart)
                {
                    //轉跳到甜點
                    cartPage cartPage = new cartPage();
                    cartPage.ShowDialog();
                    this.Close();

                    break;
                }
            }
        }
    }
}
