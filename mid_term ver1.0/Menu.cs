using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_term_ver1._0
{
    public partial class Menu : Form
    {
        string strMyDBConnectionString = "";
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();
        List<string> listPdesc = new List<string>();

        public Menu()
        {
            InitializeComponent();
        }

        private void puffList_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();
            int p = GlobalVar.G_user_permission;
            if (p == 1)
            {
                btn_addDessert.Visible = false;
                btn_Reload.Visible = false;
            }

            mymomoDB();
            ListView_IMG();

        }

        void mymomoDB()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select top 100 * from dessert;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\"; //圖檔目錄;
            string image_name = ""; //圖檔名稱;
            int i = 0;

            while (reader.Read())
            {
                listId.Add((int)reader["dessert_ID"]);
                listPname.Add(reader["dessert_name"].ToString());
                listPrice.Add((int)reader["dessert_price"]);
                listPdesc.Add(reader["dessert_description"].ToString());
                image_name = reader["dessert_image"].ToString();
                imgList.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }

        void ListView_IMG()
        {
            lv_dessert.Clear();
            lv_dessert.View = View.LargeIcon; //LargeIcon, SmallIcon, List, Tile;
            imgList.ImageSize = new Size(256,256);
            lv_dessert.LargeImageList = imgList; //LargeIcon, Tile
            lv_dessert.SmallImageList = imgList; //SmallIcon, List

            for (int i = 0; i < imgList.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listPname[i] + " " + listPrice[i] + "元";
                item.Tag = listId[i];
                lv_dessert.Items.Add(item);
            }

        }

        private void btn_listMode_Click(object sender, EventArgs e)
        {
            ListView_list();
        }

        void ListView_list()
        {
            lv_dessert.Clear();
            lv_dessert.LargeImageList = null;
            lv_dessert.SmallImageList = null;
            lv_dessert.View = View.Details;
            lv_dessert.Columns.Add("id", 40);
            lv_dessert.Columns.Add("商品名稱", 200);
            lv_dessert.Columns.Add("商品價格", 60);
            lv_dessert.Columns.Add("商品說明", 800);
            lv_dessert.FullRowSelect = true;
            lv_dessert.GridLines = true;

            for (int i = 0; i < listId.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listId[i].ToString();
                item.SubItems.Add(listPname[i]);
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listPdesc[i].ToString());
                item.Tag = listId[i];

                lv_dessert.Items.Add(item);
            }
        }

        private void btn_imageMode_Click(object sender, EventArgs e)
        {
            ListView_IMG();
        }

        private void btn_addDessert_Click(object sender, EventArgs e)
        {//新增商品
            
        }
    }
}
