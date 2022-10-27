namespace mid_term_ver1._0
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lv_dessert = new System.Windows.Forms.ListView();
            this.btn_imageMode = new System.Windows.Forms.Button();
            this.btn_addDessert = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_listMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 28F);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(207, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "商品列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lv_dessert
            // 
            this.lv_dessert.HideSelection = false;
            this.lv_dessert.Location = new System.Drawing.Point(21, 171);
            this.lv_dessert.Name = "lv_dessert";
            this.lv_dessert.Size = new System.Drawing.Size(624, 513);
            this.lv_dessert.TabIndex = 16;
            this.lv_dessert.UseCompatibleStateImageBehavior = false;
            // 
            // btn_imageMode
            // 
            this.btn_imageMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imageMode.BackgroundImage")));
            this.btn_imageMode.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_imageMode.Location = new System.Drawing.Point(807, 442);
            this.btn_imageMode.Margin = new System.Windows.Forms.Padding(2);
            this.btn_imageMode.Name = "btn_imageMode";
            this.btn_imageMode.Size = new System.Drawing.Size(190, 53);
            this.btn_imageMode.TabIndex = 29;
            this.btn_imageMode.Text = "圖片模式";
            this.btn_imageMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imageMode.UseVisualStyleBackColor = true;
            this.btn_imageMode.Click += new System.EventHandler(this.btn_imageMode_Click);
            // 
            // btn_addDessert
            // 
            this.btn_addDessert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addDessert.BackgroundImage")));
            this.btn_addDessert.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_addDessert.Location = new System.Drawing.Point(807, 574);
            this.btn_addDessert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addDessert.Name = "btn_addDessert";
            this.btn_addDessert.Size = new System.Drawing.Size(190, 53);
            this.btn_addDessert.TabIndex = 29;
            this.btn_addDessert.Text = "新增商品";
            this.btn_addDessert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addDessert.UseVisualStyleBackColor = true;
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reload.BackgroundImage")));
            this.btn_Reload.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_Reload.Location = new System.Drawing.Point(807, 631);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(190, 53);
            this.btn_Reload.TabIndex = 29;
            this.btn_Reload.Text = "重新載入";
            this.btn_Reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reload.UseVisualStyleBackColor = true;
            // 
            // btn_listMode
            // 
            this.btn_listMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_listMode.BackgroundImage")));
            this.btn_listMode.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_listMode.Location = new System.Drawing.Point(806, 499);
            this.btn_listMode.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listMode.Name = "btn_listMode";
            this.btn_listMode.Size = new System.Drawing.Size(190, 53);
            this.btn_listMode.TabIndex = 29;
            this.btn_listMode.Text = "列表模式";
            this.btn_listMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_listMode.UseVisualStyleBackColor = true;
            this.btn_listMode.Click += new System.EventHandler(this.btn_listMode_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1008, 707);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_addDessert);
            this.Controls.Add(this.btn_listMode);
            this.Controls.Add(this.btn_imageMode);
            this.Controls.Add(this.lv_dessert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "productList";
            this.Load += new System.EventHandler(this.puffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ListView lv_dessert;
        private System.Windows.Forms.Button btn_imageMode;
        private System.Windows.Forms.Button btn_addDessert;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_listMode;
    }
}