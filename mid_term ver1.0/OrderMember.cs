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
    public partial class OrderMember : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        int MID = (int)GlobalVar.G_user_info["ID"];
        public OrderMember()
        {
            InitializeComponent();
        }

        private void OrderMember_Load(object sender, EventArgs e)
        {
            //連接momoDB
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymomo";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            allOrderList();
            Console.WriteLine("orderMember PAGE");
        }

        void allOrderList()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select  mo.memberOrder_ID as '訂單編號', mo.memberOrder_delivery as '取貨方式', mo.memberOrder_address as '地址', mo.memberOrder_payment as '付款方式' , mo.memberOrder_package as '包裝', mo.memberOrder_totalPrice as '訂單總價' from memberOrder mo full JOIN dessertOrder do on mo.memberOrder_ID = do.dessertOrder_ID full JOIN puffOrder po on mo.memberOrder_ID = po.puffOrder_ID where (mo.member_ID = @MID) and (do.dessert_ID > 0 or po.puffFlavor_ID > 0)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@MID", MID);
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

        private void dgv_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv_order.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine("str"+strSelectedID);
                ulong intSelID = 0;
                //bool isID = ulong.TryParse(strSelectedID, out intSelID);
                bool isID = strSelectedID!="";
                //Console.WriteLine("ulong" + intSelID);
                Console.WriteLine(isID);

                if (isID)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from memberOrder mo full JOIN dessertOrder do on mo.memberOrder_ID = do.dessertOrder_ID full JOIN puffOrder po on mo.memberOrder_ID = po.puffOrder_ID JOIN dessert d on do.dessert_ID = d.dessert_ID　where(mo.mid = @SearchID)　";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", strSelectedID);
                    cmd.Parameters.AddWithValue("@MID", MID);
                    Console.WriteLine("intSelID: "+ strSelectedID + "\nMID: "+ MID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader.Read());
                        string dd = "";
                        string pd = "";
                        lb_ID.Text = strSelectedID;
                        string dName = reader["d.dessert_name"].ToString();
                        string dAmount = (reader["do.dessert_amount"]).ToString();
                        int dPrice = Convert.ToInt32(reader["do.dessert_dis_price"]);
                        string pName = reader["po.puffOrder_flavor"].ToString();
                        int pPrice = Convert.ToInt32(reader["po.puffOrder_dis_price"]);

                        dd = String.Format("{0}數量{1}價格{2}", dName.PadRight(13, '　'), dAmount.PadRight(3, ' '), dPrice);
                        pd = String.Format("{0}價格{1}", pName.PadRight(16, ' '), dPrice);
                        Console.WriteLine("dd: " + dd + "\npd: " + pd);

                        lbox_order.Items.Add(dd);
                            lbox_order.Items.Add(pd);
                        Console.WriteLine(dd+"\n"+pd);
                    }

                    reader.Close();
                    con.Close();
                }
            }*/
        }
    }
}
