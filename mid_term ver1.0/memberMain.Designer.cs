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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_goBuySweetPage
            // 
            this.lb_goBuySweetPage.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_goBuySweetPage.Image = ((System.Drawing.Image)(resources.GetObject("lb_goBuySweetPage.Image")));
            this.lb_goBuySweetPage.Location = new System.Drawing.Point(344, 220);
            this.lb_goBuySweetPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_goBuySweetPage.Name = "lb_goBuySweetPage";
            this.lb_goBuySweetPage.Size = new System.Drawing.Size(300, 300);
            this.lb_goBuySweetPage.TabIndex = 1;
            this.lb_goBuySweetPage.Text = "買甜甜";
            this.lb_goBuySweetPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_goBuySweetPage.Click += new System.EventHandler(this.lb_goBuySweetPage_Click);
            // 
            // lb_goBuyPuffPage
            // 
            this.lb_goBuyPuffPage.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_goBuyPuffPage.Image = ((System.Drawing.Image)(resources.GetObject("lb_goBuyPuffPage.Image")));
            this.lb_goBuyPuffPage.Location = new System.Drawing.Point(677, 220);
            this.lb_goBuyPuffPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_goBuyPuffPage.Name = "lb_goBuyPuffPage";
            this.lb_goBuyPuffPage.Size = new System.Drawing.Size(300, 300);
            this.lb_goBuyPuffPage.TabIndex = 1;
            this.lb_goBuyPuffPage.Text = "買泡芙";
            this.lb_goBuyPuffPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_goBuyPuffPage.Click += new System.EventHandler(this.lb_goBuyPuffPage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(11, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 300);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂單";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // memberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1008, 707);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_goBuyPuffPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_goBuySweetPage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
    }
}