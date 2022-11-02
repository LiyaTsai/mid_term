namespace mid_term_ver1._0
{
    partial class memberMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memberMain));
            this.lb_goBuySweetPage = new System.Windows.Forms.Label();
            this.lb_goBuyPuffPage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_orderlist = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_goBuySweetPage
            // 
            this.lb_goBuySweetPage.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_goBuySweetPage.Image = ((System.Drawing.Image)(resources.GetObject("lb_goBuySweetPage.Image")));
            this.lb_goBuySweetPage.Location = new System.Drawing.Point(516, 330);
            this.lb_goBuySweetPage.Name = "lb_goBuySweetPage";
            this.lb_goBuySweetPage.Size = new System.Drawing.Size(450, 450);
            this.lb_goBuySweetPage.TabIndex = 1;
            this.lb_goBuySweetPage.Text = "買甜甜";
            this.lb_goBuySweetPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_goBuySweetPage.Click += new System.EventHandler(this.lb_goBuySweetPage_Click);
            // 
            // lb_goBuyPuffPage
            // 
            this.lb_goBuyPuffPage.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_goBuyPuffPage.Image = ((System.Drawing.Image)(resources.GetObject("lb_goBuyPuffPage.Image")));
            this.lb_goBuyPuffPage.Location = new System.Drawing.Point(1016, 330);
            this.lb_goBuyPuffPage.Name = "lb_goBuyPuffPage";
            this.lb_goBuyPuffPage.Size = new System.Drawing.Size(450, 450);
            this.lb_goBuyPuffPage.TabIndex = 1;
            this.lb_goBuyPuffPage.Text = "買泡芙";
            this.lb_goBuyPuffPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_goBuyPuffPage.Click += new System.EventHandler(this.lb_goBuyPuffPage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lb_orderlist
            // 
            this.lb_orderlist.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orderlist.Image = ((System.Drawing.Image)(resources.GetObject("lb_orderlist.Image")));
            this.lb_orderlist.Location = new System.Drawing.Point(16, 330);
            this.lb_orderlist.Name = "lb_orderlist";
            this.lb_orderlist.Size = new System.Drawing.Size(450, 450);
            this.lb_orderlist.TabIndex = 1;
            this.lb_orderlist.Text = "訂單";
            this.lb_orderlist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_orderlist.Click += new System.EventHandler(this.lb_orderlist_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("微軟正黑體", 28F);
            this.lb_title.Image = ((System.Drawing.Image)(resources.GetObject("lb_title.Image")));
            this.lb_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_title.Location = new System.Drawing.Point(257, 108);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(1056, 117);
            this.lb_title.TabIndex = 18;
            this.lb_title.Text = "　　　　會員資料";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1512, 1060);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_goBuyPuffPage);
            this.Controls.Add(this.lb_orderlist);
            this.Controls.Add(this.lb_goBuySweetPage);
            this.Name = "memberMain";
            this.Text = "memberMain";
            this.Load += new System.EventHandler(this.memberMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_goBuySweetPage;
        private System.Windows.Forms.Label lb_goBuyPuffPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_orderlist;
        private System.Windows.Forms.Label lb_title;
    }
}