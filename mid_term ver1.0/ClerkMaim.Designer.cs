namespace mid_term_ver1._0
{
    partial class ClerkMaim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClerkMaim));
            this.lb_goMemberInfo = new System.Windows.Forms.Label();
            this.lb_orderlist = new System.Windows.Forms.Label();
            this.lb_goManage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_goMemberInfo
            // 
            this.lb_goMemberInfo.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_goMemberInfo.Image = ((System.Drawing.Image)(resources.GetObject("lb_goMemberInfo.Image")));
            this.lb_goMemberInfo.Location = new System.Drawing.Point(1038, 330);
            this.lb_goMemberInfo.Name = "lb_goMemberInfo";
            this.lb_goMemberInfo.Size = new System.Drawing.Size(450, 450);
            this.lb_goMemberInfo.TabIndex = 22;
            this.lb_goMemberInfo.Text = "會員管理";
            this.lb_goMemberInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_goMemberInfo.Click += new System.EventHandler(this.lb_goMemberInfo_Click);
            // 
            // lb_orderlist
            // 
            this.lb_orderlist.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orderlist.Image = ((System.Drawing.Image)(resources.GetObject("lb_orderlist.Image")));
            this.lb_orderlist.Location = new System.Drawing.Point(38, 330);
            this.lb_orderlist.Name = "lb_orderlist";
            this.lb_orderlist.Size = new System.Drawing.Size(450, 450);
            this.lb_orderlist.TabIndex = 23;
            this.lb_orderlist.Text = "訂單";
            this.lb_orderlist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_orderlist.Click += new System.EventHandler(this.lb_orderlist_Click);
            // 
            // lb_goManage
            // 
            this.lb_goManage.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_goManage.Image = ((System.Drawing.Image)(resources.GetObject("lb_goManage.Image")));
            this.lb_goManage.Location = new System.Drawing.Point(534, 330);
            this.lb_goManage.Name = "lb_goManage";
            this.lb_goManage.Size = new System.Drawing.Size(450, 450);
            this.lb_goManage.TabIndex = 24;
            this.lb_goManage.Text = "甜點管理";
            this.lb_goManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_goManage.Click += new System.EventHandler(this.lb_goManage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("微軟正黑體", 28F);
            this.lb_title.Image = ((System.Drawing.Image)(resources.GetObject("lb_title.Image")));
            this.lb_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_title.Location = new System.Drawing.Point(279, 108);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(1056, 117);
            this.lb_title.TabIndex = 25;
            this.lb_title.Text = "　　　　後台功能頁";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClerkMaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1512, 1094);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_goMemberInfo);
            this.Controls.Add(this.lb_orderlist);
            this.Controls.Add(this.lb_goManage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClerkMaim";
            this.Text = "ClerkMaim";
            this.Load += new System.EventHandler(this.ClerkMaim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_goMemberInfo;
        private System.Windows.Forms.Label lb_orderlist;
        private System.Windows.Forms.Label lb_goManage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_title;
    }
}