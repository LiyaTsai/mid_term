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
    public partial class Order : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            //連接momoDB
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            allOrderList();
        }
        void allOrderList()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select mo.memberOrder_ID as '訂單編號', mo.member_ID as '會員編號', mo.memberOrder_delivery as '取貨方式', mo.memberOrder_address as '地址', mo.memberOrder_payment as '付款方式' , mo.memberOrder_package as '包裝', do.dessert_ID as '甜點品項編號' ,po.puffFlavor_ID as '泡芙品項編號', mo.memberOrder_totalPrice as '訂單總價' from memberOrder mo full JOIN dessertOrder do on mo.memberOrder_ID = do.dessertOrder_ID full JOIN puffOrder po on mo.memberOrder_ID = po.puffOrder_ID where (mo.member_ID > 0) and (do.dessert_ID > 0 or po.puffFlavor_ID > 0)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv_order.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
    }
}
