namespace mid_term_ver1._0
{
    partial class OrderALL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderALL));
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.lb_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_orderS0 = new System.Windows.Forms.Button();
            this.btn_orderS1 = new System.Windows.Forms.Button();
            this.btn_orderS2 = new System.Windows.Forms.Button();
            this.btn_orderS1to2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_order
            // 
            this.dgv_order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Location = new System.Drawing.Point(248, 238);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersWidth = 62;
            this.dgv_order.RowTemplate.Height = 31;
            this.dgv_order.Size = new System.Drawing.Size(1218, 734);
            this.dgv_order.TabIndex = 0;
            this.dgv_order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellClick);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("微軟正黑體", 28F);
            this.lb_title.Image = ((System.Drawing.Image)(resources.GetObject("lb_title.Image")));
            this.lb_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_title.Location = new System.Drawing.Point(257, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(1056, 117);
            this.lb_title.TabIndex = 17;
            this.lb_title.Text = "　　　　會員資料";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_orderS0
            // 
            this.btn_orderS0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_orderS0.BackgroundImage")));
            this.btn_orderS0.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_orderS0.Location = new System.Drawing.Point(248, 159);
            this.btn_orderS0.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orderS0.Name = "btn_orderS0";
            this.btn_orderS0.Size = new System.Drawing.Size(300, 75);
            this.btn_orderS0.TabIndex = 44;
            this.btn_orderS0.Text = "所有訂單";
            this.btn_orderS0.UseVisualStyleBackColor = true;
            this.btn_orderS0.Click += new System.EventHandler(this.btn_orderS0_Click);
            // 
            // btn_orderS1
            // 
            this.btn_orderS1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_orderS1.BackgroundImage")));
            this.btn_orderS1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_orderS1.Location = new System.Drawing.Point(556, 159);
            this.btn_orderS1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orderS1.Name = "btn_orderS1";
            this.btn_orderS1.Size = new System.Drawing.Size(300, 75);
            this.btn_orderS1.TabIndex = 44;
            this.btn_orderS1.Text = "未出貨訂單";
            this.btn_orderS1.UseVisualStyleBackColor = true;
            this.btn_orderS1.Click += new System.EventHandler(this.btn_orderS1_Click);
            // 
            // btn_orderS2
            // 
            this.btn_orderS2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_orderS2.BackgroundImage")));
            this.btn_orderS2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_orderS2.Location = new System.Drawing.Point(864, 159);
            this.btn_orderS2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orderS2.Name = "btn_orderS2";
            this.btn_orderS2.Size = new System.Drawing.Size(300, 75);
            this.btn_orderS2.TabIndex = 44;
            this.btn_orderS2.Text = "已出貨訂單";
            this.btn_orderS2.UseVisualStyleBackColor = true;
            this.btn_orderS2.Click += new System.EventHandler(this.btn_orderS2_Click);
            // 
            // btn_orderS1to2
            // 
            this.btn_orderS1to2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_orderS1to2.BackgroundImage")));
            this.btn_orderS1to2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_orderS1to2.Location = new System.Drawing.Point(1166, 988);
            this.btn_orderS1to2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orderS1to2.Name = "btn_orderS1to2";
            this.btn_orderS1to2.Size = new System.Drawing.Size(300, 75);
            this.btn_orderS1to2.TabIndex = 44;
            this.btn_orderS1to2.Text = "出貨";
            this.btn_orderS1to2.UseVisualStyleBackColor = true;
            this.btn_orderS1to2.Click += new System.EventHandler(this.btn_orderS1to2_Click);
            // 
            // OrderALL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1512, 1094);
            this.Controls.Add(this.btn_orderS1to2);
            this.Controls.Add(this.btn_orderS2);
            this.Controls.Add(this.btn_orderS1);
            this.Controls.Add(this.btn_orderS0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.dgv_order);
            this.Name = "OrderALL";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_orderS0;
        private System.Windows.Forms.Button btn_orderS1;
        private System.Windows.Forms.Button btn_orderS2;
        private System.Windows.Forms.Button btn_orderS1to2;
    }
}