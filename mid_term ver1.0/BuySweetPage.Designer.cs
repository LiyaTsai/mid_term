﻿namespace mid_term_ver1._0
{
    partial class BuySweetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuySweetPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_productamount = new System.Windows.Forms.NumericUpDown();
            this.btn_goToCart = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_addsweet = new System.Windows.Forms.Button();
            this.lbox_product = new System.Windows.Forms.ListBox();
            this.lb_subtotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_total1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_unitprice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbox_cartSweet = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_puffPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_productamount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 50F);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(242, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 150);
            this.label1.TabIndex = 17;
            this.label1.Text = "甜甜";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_productamount
            // 
            this.num_productamount.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.num_productamount.Location = new System.Drawing.Point(335, 650);
            this.num_productamount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num_productamount.Name = "num_productamount";
            this.num_productamount.Size = new System.Drawing.Size(106, 52);
            this.num_productamount.TabIndex = 18;
            this.num_productamount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_productamount.ValueChanged += new System.EventHandler(this.num_productamount_ValueChanged);
            // 
            // btn_goToCart
            // 
            this.btn_goToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_goToCart.BackgroundImage")));
            this.btn_goToCart.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_goToCart.Location = new System.Drawing.Point(1215, 968);
            this.btn_goToCart.Name = "btn_goToCart";
            this.btn_goToCart.Size = new System.Drawing.Size(285, 80);
            this.btn_goToCart.TabIndex = 27;
            this.btn_goToCart.Text = "前往購物車";
            this.btn_goToCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_goToCart.UseVisualStyleBackColor = true;
            this.btn_goToCart.Click += new System.EventHandler(this.btn_goToCart_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menu.BackgroundImage")));
            this.btn_menu.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_menu.Location = new System.Drawing.Point(957, 167);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(285, 80);
            this.btn_menu.TabIndex = 28;
            this.btn_menu.Text = "甜點實拍照片";
            this.btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_addsweet
            // 
            this.btn_addsweet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addsweet.BackgroundImage")));
            this.btn_addsweet.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_addsweet.Location = new System.Drawing.Point(975, 652);
            this.btn_addsweet.Name = "btn_addsweet";
            this.btn_addsweet.Size = new System.Drawing.Size(285, 80);
            this.btn_addsweet.TabIndex = 29;
            this.btn_addsweet.Text = "加入訂單";
            this.btn_addsweet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addsweet.UseVisualStyleBackColor = true;
            this.btn_addsweet.Click += new System.EventHandler(this.btn_addsweet_Click);
            // 
            // lbox_product
            // 
            this.lbox_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.lbox_product.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_product.FormattingEnabled = true;
            this.lbox_product.ItemHeight = 54;
            this.lbox_product.Location = new System.Drawing.Point(284, 253);
            this.lbox_product.Name = "lbox_product";
            this.lbox_product.Size = new System.Drawing.Size(958, 382);
            this.lbox_product.TabIndex = 26;
            this.lbox_product.SelectedIndexChanged += new System.EventHandler(this.lbox_product_SelectedIndexChanged);
            // 
            // lb_subtotal
            // 
            this.lb_subtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.lb_subtotal.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lb_subtotal.Location = new System.Drawing.Point(790, 652);
            this.lb_subtotal.Name = "lb_subtotal";
            this.lb_subtotal.Size = new System.Drawing.Size(165, 38);
            this.lb_subtotal.TabIndex = 19;
            this.lb_subtotal.Text = "0";
            this.lb_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label8.Location = new System.Drawing.Point(689, 652);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 36);
            this.label8.TabIndex = 20;
            this.label8.Text = "小計 $";
            // 
            // lb_total1
            // 
            this.lb_total1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.lb_total1.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lb_total1.Location = new System.Drawing.Point(1311, 920);
            this.lb_total1.Name = "lb_total1";
            this.lb_total1.Size = new System.Drawing.Size(189, 38);
            this.lb_total1.TabIndex = 21;
            this.lb_total1.Text = "0";
            this.lb_total1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label7.Location = new System.Drawing.Point(1206, 920);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "小結 $";
            // 
            // lb_unitprice
            // 
            this.lb_unitprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.lb_unitprice.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lb_unitprice.Location = new System.Drawing.Point(563, 651);
            this.lb_unitprice.Name = "lb_unitprice";
            this.lb_unitprice.Size = new System.Drawing.Size(118, 38);
            this.lb_unitprice.TabIndex = 23;
            this.lb_unitprice.Text = "0";
            this.lb_unitprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label5.Location = new System.Drawing.Point(463, 652);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "單價 $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label4.Location = new System.Drawing.Point(259, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "數量";
            // 
            // lbox_cartSweet
            // 
            this.lbox_cartSweet.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.lbox_cartSweet.FormattingEnabled = true;
            this.lbox_cartSweet.ItemHeight = 54;
            this.lbox_cartSweet.Location = new System.Drawing.Point(242, 754);
            this.lbox_cartSweet.Name = "lbox_cartSweet";
            this.lbox_cartSweet.Size = new System.Drawing.Size(958, 274);
            this.lbox_cartSweet.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(0, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 400);
            this.button1.TabIndex = 32;
            this.button1.Text = "甜點";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_puffPage
            // 
            this.btn_puffPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_puffPage.BackgroundImage")));
            this.btn_puffPage.Font = new System.Drawing.Font("Yu Gothic UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puffPage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_puffPage.Location = new System.Drawing.Point(0, 225);
            this.btn_puffPage.Name = "btn_puffPage";
            this.btn_puffPage.Size = new System.Drawing.Size(80, 400);
            this.btn_puffPage.TabIndex = 32;
            this.btn_puffPage.Text = "泡芙";
            this.btn_puffPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_puffPage.UseVisualStyleBackColor = true;
            this.btn_puffPage.Click += new System.EventHandler(this.btn_puffPage_Click);
            // 
            // BuySweetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1512, 1060);
            this.Controls.Add(this.btn_puffPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbox_cartSweet);
            this.Controls.Add(this.num_productamount);
            this.Controls.Add(this.btn_goToCart);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_addsweet);
            this.Controls.Add(this.lbox_product);
            this.Controls.Add(this.lb_subtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_total1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_unitprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BuySweetPage";
            this.Text = "BuySweetPage";
            this.Load += new System.EventHandler(this.BuySweetPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_productamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_productamount;
        private System.Windows.Forms.Button btn_goToCart;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_addsweet;
        private System.Windows.Forms.ListBox lbox_product;
        private System.Windows.Forms.Label lb_subtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_total1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_unitprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbox_cartSweet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_puffPage;
    }
}