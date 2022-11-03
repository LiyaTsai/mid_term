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
    public partial class addSweets : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        public addSweets()
        {
            InitializeComponent();
        }


        private void addSweets_Load(object sender, EventArgs e)
        {
            //連接momoDB
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            showSweet();
        }

        void showSweet()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from dessert where dessert_ID = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", lb_ID.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lb_ID.Text = reader["dessert_ID"].ToString();
                txt_name.Text = reader["dessert_name"].ToString();
                txt_price.Text = reader["dessert_price"].ToString();
                txt_desc.Text = reader["dessert_description"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btn_selectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                Console.WriteLine(image_name);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool namechk = txt_name.Text != "";
            bool pricechk = txt_price.Text != "" && Convert.ToInt32(txt_price.Text) >= 70;
            bool picchk = pictureBox2.Image != null;

            if (namechk && pricechk && picchk)
            {
                pictureBox2.Image.Save(image_dir + image_name);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert dessert (dessert_name ,dessert_price , dessert_description, dessert_image) values (@dessert_name ,@dessert_price , @dessert_description, @dessert_image);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@dessert_name", txt_name.Text);
                int intPrice = 0;
                Int32.TryParse(txt_price.Text, out intPrice);
                cmd.Parameters.AddWithValue("@dessert_price", intPrice);
                cmd.Parameters.AddWithValue("@dessert_description", txt_desc.Text);
                cmd.Parameters.AddWithValue("@dessert_image", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功, 影響" + rows + "筆資料");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            txt_desc.Clear();
            txt_name.Clear();
            txt_price.Clear();
        }
    }
}
