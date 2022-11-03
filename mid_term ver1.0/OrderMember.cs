﻿using System;
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
            string strSQL = "select  mo.memberOrder_ID as '訂單編號', mo.memberOrder_delivery as '取貨方式', mo.memberOrder_address as '地址', mo.memberOrder_payment as '付款方式' , mo.memberOrder_package as '包裝', mo.memberOrder_totalPrice as '訂單總價' from memberOrder mo full JOIN dessertOrder do on mo.memberOrder_ID = do.dessertOrder_ID full JOIN puffOrder po on mo.memberOrder_ID = po.puffOrder_ID where (mo.member_ID = @MID) and (do.dessert_ID > 0 or po.puffFlavor_ID > 0) order by memberOrder_time desc;";
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
           
        }
    }
}
