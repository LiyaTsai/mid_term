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
            this.SuspendLayout();
            // 
            // lb_goBuySweetPage
            // 
            this.lb_goBuySweetPage.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_goBuySweetPage.Image = ((System.Drawing.Image)(resources.GetObject("lb_goBuySweetPage.Image")));
            this.lb_goBuySweetPage.Location = new System.Drawing.Point(39, 38);
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
            this.lb_goBuyPuffPage.Location = new System.Drawing.Point(512, 38);
            this.lb_goBuyPuffPage.Name = "lb_goBuyPuffPage";
            this.lb_goBuyPuffPage.Size = new System.Drawing.Size(450, 450);
            this.lb_goBuyPuffPage.TabIndex = 1;
            this.lb_goBuyPuffPage.Text = "買泡芙";
            this.lb_goBuyPuffPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_goBuyPuffPage.Click += new System.EventHandler(this.lb_goBuyPuffPage_Click);
            // 
            // memberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1512, 1094);
            this.Controls.Add(this.lb_goBuyPuffPage);
            this.Controls.Add(this.lb_goBuySweetPage);
            this.Name = "memberMain";
            this.Text = "memberMain";
            this.Load += new System.EventHandler(this.memberMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_goBuySweetPage;
        private System.Windows.Forms.Label lb_goBuyPuffPage;
    }
}