using System;
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
    public partial class puffList : Form
    {
        string strMyDBConnectionString = "";
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();

        public puffList()
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

            mymomoDB();
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
                image_name = reader["dessert_image"].ToString();
                imgList.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }
    }
}
