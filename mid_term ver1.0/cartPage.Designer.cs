namespace mid_term_ver1._0
{
    partial class cartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cartPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_giftbox = new System.Windows.Forms.RadioButton();
            this.rbtn_basicPackage = new System.Windows.Forms.RadioButton();
            this.rbtn_giftbag = new System.Windows.Forms.RadioButton();
            this.cbox_delivery = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_cash = new System.Windows.Forms.RadioButton();
            this.rbtn_trans = new System.Windows.Forms.RadioButton();
            this.rbtn_linepay = new System.Windows.Forms.RadioButton();
            this.lbox_cartSweet = new System.Windows.Forms.ListBox();
            this.btn_discount = new System.Windows.Forms.Button();
            this.brtn_RemoveOne = new System.Windows.Forms.Button();
            this.btn_RemoveAll = new System.Windows.Forms.Button();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.lbox_cartPuff = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 28F);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 60);
            this.label2.TabIndex = 19;
            this.label2.Text = "購物車";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lb_phone.Location = new System.Drawing.Point(175, 122);
            this.lb_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(50, 25);
            this.lb_phone.TabIndex = 20;
            this.lb_phone.Text = "手機";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lb_name.Location = new System.Drawing.Point(175, 82);
            this.lb_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(50, 25);
            this.lb_name.TabIndex = 21;
            this.lb_name.Text = "姓名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_giftbox);
            this.groupBox1.Controls.Add(this.rbtn_basicPackage);
            this.groupBox1.Controls.Add(this.rbtn_giftbag);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.groupBox1.Location = new System.Drawing.Point(824, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(173, 126);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "包裝";
            // 
            // rbtn_giftbox
            // 
            this.rbtn_giftbox.AutoSize = true;
            this.rbtn_giftbox.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.rbtn_giftbox.Location = new System.Drawing.Point(15, 93);
            this.rbtn_giftbox.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_giftbox.Name = "rbtn_giftbox";
            this.rbtn_giftbox.Size = new System.Drawing.Size(140, 29);
            this.rbtn_giftbox.TabIndex = 0;
            this.rbtn_giftbox.Text = "禮盒(+$100)";
            this.rbtn_giftbox.UseVisualStyleBackColor = true;
            this.rbtn_giftbox.CheckedChanged += new System.EventHandler(this.rbtn_giftbox_CheckedChanged);
            // 
            // rbtn_basicPackage
            // 
            this.rbtn_basicPackage.AutoSize = true;
            this.rbtn_basicPackage.Checked = true;
            this.rbtn_basicPackage.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.rbtn_basicPackage.Location = new System.Drawing.Point(15, 30);
            this.rbtn_basicPackage.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_basicPackage.Name = "rbtn_basicPackage";
            this.rbtn_basicPackage.Size = new System.Drawing.Size(106, 29);
            this.rbtn_basicPackage.TabIndex = 0;
            this.rbtn_basicPackage.TabStop = true;
            this.rbtn_basicPackage.Text = "基本包裝";
            this.rbtn_basicPackage.UseVisualStyleBackColor = true;
            this.rbtn_basicPackage.CheckedChanged += new System.EventHandler(this.rbtn_basicPackage_CheckedChanged);
            // 
            // rbtn_giftbag
            // 
            this.rbtn_giftbag.AutoSize = true;
            this.rbtn_giftbag.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.rbtn_giftbag.Location = new System.Drawing.Point(15, 61);
            this.rbtn_giftbag.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_giftbag.Name = "rbtn_giftbag";
            this.rbtn_giftbag.Size = new System.Drawing.Size(129, 29);
            this.rbtn_giftbag.TabIndex = 0;
            this.rbtn_giftbag.Text = "提袋(+$20)";
            this.rbtn_giftbag.UseVisualStyleBackColor = true;
            this.rbtn_giftbag.CheckedChanged += new System.EventHandler(this.rbtn_giftbag_CheckedChanged);
            // 
            // cbox_delivery
            // 
            this.cbox_delivery.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.cbox_delivery.FormattingEnabled = true;
            this.cbox_delivery.Location = new System.Drawing.Point(267, 163);
            this.cbox_delivery.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_delivery.Name = "cbox_delivery";
            this.cbox_delivery.Size = new System.Drawing.Size(234, 33);
            this.cbox_delivery.TabIndex = 24;
            this.cbox_delivery.SelectedIndexChanged += new System.EventHandler(this.cbox_delivery_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label6.Location = new System.Drawing.Point(175, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "取貨方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_cash);
            this.groupBox2.Controls.Add(this.rbtn_trans);
            this.groupBox2.Controls.Add(this.rbtn_linepay);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.groupBox2.Location = new System.Drawing.Point(650, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 122);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "付款方式";
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.rbtn_cash.Location = new System.Drawing.Point(87, 79);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(75, 33);
            this.rbtn_cash.TabIndex = 0;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "付現";
            this.rbtn_cash.UseVisualStyleBackColor = true;
            // 
            // rbtn_trans
            // 
            this.rbtn_trans.AutoSize = true;
            this.rbtn_trans.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.rbtn_trans.Location = new System.Drawing.Point(6, 79);
            this.rbtn_trans.Name = "rbtn_trans";
            this.rbtn_trans.Size = new System.Drawing.Size(75, 33);
            this.rbtn_trans.TabIndex = 0;
            this.rbtn_trans.TabStop = true;
            this.rbtn_trans.Text = "匯款";
            this.rbtn_trans.UseVisualStyleBackColor = true;
            // 
            // rbtn_linepay
            // 
            this.rbtn_linepay.AutoSize = true;
            this.rbtn_linepay.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.rbtn_linepay.Location = new System.Drawing.Point(6, 40);
            this.rbtn_linepay.Name = "rbtn_linepay";
            this.rbtn_linepay.Size = new System.Drawing.Size(119, 33);
            this.rbtn_linepay.TabIndex = 0;
            this.rbtn_linepay.TabStop = true;
            this.rbtn_linepay.Text = "Line Pay";
            this.rbtn_linepay.UseVisualStyleBackColor = true;
            // 
            // lbox_cartSweet
            // 
            this.lbox_cartSweet.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.lbox_cartSweet.FormattingEnabled = true;
            this.lbox_cartSweet.ItemHeight = 35;
            this.lbox_cartSweet.Location = new System.Drawing.Point(420, 209);
            this.lbox_cartSweet.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_cartSweet.Name = "lbox_cartSweet";
            this.lbox_cartSweet.Size = new System.Drawing.Size(578, 109);
            this.lbox_cartSweet.TabIndex = 26;
            // 
            // btn_discount
            // 
            this.btn_discount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_discount.BackgroundImage")));
            this.btn_discount.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btn_discount.Location = new System.Drawing.Point(758, 514);
            this.btn_discount.Margin = new System.Windows.Forms.Padding(2);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(240, 53);
            this.btn_discount.TabIndex = 32;
            this.btn_discount.Text = "使用折扣碼";
            this.btn_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_discount.UseVisualStyleBackColor = true;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // brtn_RemoveOne
            // 
            this.brtn_RemoveOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brtn_RemoveOne.BackgroundImage")));
            this.brtn_RemoveOne.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.brtn_RemoveOne.Location = new System.Drawing.Point(512, 458);
            this.brtn_RemoveOne.Margin = new System.Windows.Forms.Padding(2);
            this.brtn_RemoveOne.Name = "brtn_RemoveOne";
            this.brtn_RemoveOne.Size = new System.Drawing.Size(240, 53);
            this.brtn_RemoveOne.TabIndex = 33;
            this.brtn_RemoveOne.Text = "移除單筆";
            this.brtn_RemoveOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brtn_RemoveOne.UseVisualStyleBackColor = true;
            this.brtn_RemoveOne.Click += new System.EventHandler(this.brtn_RemoveOne_Click);
            // 
            // btn_RemoveAll
            // 
            this.btn_RemoveAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RemoveAll.BackgroundImage")));
            this.btn_RemoveAll.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btn_RemoveAll.Location = new System.Drawing.Point(756, 458);
            this.btn_RemoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RemoveAll.Name = "btn_RemoveAll";
            this.btn_RemoveAll.Size = new System.Drawing.Size(240, 53);
            this.btn_RemoveAll.TabIndex = 34;
            this.btn_RemoveAll.Text = "移除全部";
            this.btn_RemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RemoveAll.UseVisualStyleBackColor = true;
            this.btn_RemoveAll.Click += new System.EventHandler(this.btn_RemoveAll_Click);
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.txt_discount.Location = new System.Drawing.Point(512, 517);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(240, 50);
            this.txt_discount.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(414, 523);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 35);
            this.label3.TabIndex = 28;
            this.label3.Text = "折扣碼";
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.Color.LightSalmon;
            this.lb_total.Font = new System.Drawing.Font("Yu Gothic", 30F);
            this.lb_total.Location = new System.Drawing.Point(870, 569);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(126, 53);
            this.lb_total.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.label7.Location = new System.Drawing.Point(783, 583);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 35);
            this.label7.TabIndex = 36;
            this.label7.Text = "總計 $";
            // 
            // btn_order
            // 
            this.btn_order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_order.BackgroundImage")));
            this.btn_order.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btn_order.Location = new System.Drawing.Point(618, 633);
            this.btn_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(240, 53);
            this.btn_order.TabIndex = 37;
            this.btn_order.Text = "送出訂單";
            this.btn_order.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lbox_cartPuff
            // 
            this.lbox_cartPuff.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.lbox_cartPuff.FormattingEnabled = true;
            this.lbox_cartPuff.ItemHeight = 35;
            this.lbox_cartPuff.Location = new System.Drawing.Point(11, 209);
            this.lbox_cartPuff.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_cartPuff.Name = "lbox_cartPuff";
            this.lbox_cartPuff.Size = new System.Drawing.Size(405, 109);
            this.lbox_cartPuff.TabIndex = 26;
            // 
            // cartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1008, 707);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_discount);
            this.Controls.Add(this.brtn_RemoveOne);
            this.Controls.Add(this.btn_RemoveAll);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbox_cartPuff);
            this.Controls.Add(this.lbox_cartSweet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbox_delivery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cartPage";
            this.Text = "cartPage";
            this.Load += new System.EventHandler(this.cartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_giftbox;
        private System.Windows.Forms.RadioButton rbtn_basicPackage;
        private System.Windows.Forms.RadioButton rbtn_giftbag;
        private System.Windows.Forms.ComboBox cbox_delivery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_cash;
        private System.Windows.Forms.RadioButton rbtn_trans;
        private System.Windows.Forms.RadioButton rbtn_linepay;
        private System.Windows.Forms.ListBox lbox_cartSweet;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button brtn_RemoveOne;
        private System.Windows.Forms.Button btn_RemoveAll;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ListBox lbox_cartPuff;
    }
}