namespace mid_term_ver1._0
{
    partial class OrderMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMember));
            this.lb_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.lbox_order = new System.Windows.Forms.ListBox();
            this.lb_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("微軟正黑體", 28F);
            this.lb_title.Image = ((System.Drawing.Image)(resources.GetObject("lb_title.Image")));
            this.lb_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_title.Location = new System.Drawing.Point(255, 106);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(1056, 117);
            this.lb_title.TabIndex = 20;
            this.lb_title.Text = "　　　　會員資料";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_order
            // 
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Location = new System.Drawing.Point(251, 317);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersWidth = 62;
            this.dgv_order.RowTemplate.Height = 31;
            this.dgv_order.Size = new System.Drawing.Size(1228, 630);
            this.dgv_order.TabIndex = 21;
            // 
            // lbox_order
            // 
            this.lbox_order.FormattingEnabled = true;
            this.lbox_order.ItemHeight = 18;
            this.lbox_order.Location = new System.Drawing.Point(12, 264);
            this.lbox_order.Name = "lbox_order";
            this.lbox_order.Size = new System.Drawing.Size(100, 76);
            this.lbox_order.TabIndex = 22;
            // 
            // lb_ID
            // 
            this.lb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.lb_ID.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(1029, 238);
            this.lb_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(450, 68);
            this.lb_ID.TabIndex = 23;
            // 
            // OrderMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1512, 1060);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.lbox_order);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderMember";
            this.Text = "OrderMember";
            this.Load += new System.EventHandler(this.OrderMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.ListBox lbox_order;
        private System.Windows.Forms.Label lb_ID;
    }
}