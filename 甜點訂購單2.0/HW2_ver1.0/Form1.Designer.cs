namespace HW2_ver1._0
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbox_product = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_unitprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_total1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ckb_chocolate = new System.Windows.Forms.CheckBox();
            this.ckb_vanilla = new System.Windows.Forms.CheckBox();
            this.ckb_earlgrey = new System.Windows.Forms.CheckBox();
            this.ckb_strawberrycheese = new System.Windows.Forms.CheckBox();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.btn_addpuff = new System.Windows.Forms.Button();
            this.cbox_delivery = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_giftbox = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtn_giftbag = new System.Windows.Forms.RadioButton();
            this.num_productamount = new System.Windows.Forms.NumericUpDown();
            this.btn_form2 = new System.Windows.Forms.Button();
            this.lb_puffamount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_subtotal = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_productamount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(27, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 40F);
            this.label1.Location = new System.Drawing.Point(117, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOMO 甜點團購單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(32, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(32, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "手機";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.txt_name.Location = new System.Drawing.Point(86, 121);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(272, 37);
            this.txt_name.TabIndex = 3;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.txt_phone.Location = new System.Drawing.Point(86, 164);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_phone.MaxLength = 10;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(272, 37);
            this.txt_phone.TabIndex = 3;
            // 
            // lbox_product
            // 
            this.lbox_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.lbox_product.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lbox_product.FormattingEnabled = true;
            this.lbox_product.ItemHeight = 25;
            this.lbox_product.Location = new System.Drawing.Point(21, 568);
            this.lbox_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbox_product.Name = "lbox_product";
            this.lbox_product.Size = new System.Drawing.Size(617, 204);
            this.lbox_product.TabIndex = 5;
            this.lbox_product.SelectedIndexChanged += new System.EventHandler(this.lbox_product_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label4.Location = new System.Drawing.Point(23, 782);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "數量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label5.Location = new System.Drawing.Point(189, 782);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "單價 $";
            // 
            // lb_unitprice
            // 
            this.lb_unitprice.BackColor = System.Drawing.Color.LightSalmon;
            this.lb_unitprice.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lb_unitprice.Location = new System.Drawing.Point(259, 782);
            this.lb_unitprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_unitprice.Name = "lb_unitprice";
            this.lb_unitprice.Size = new System.Drawing.Size(60, 25);
            this.lb_unitprice.TabIndex = 2;
            this.lb_unitprice.Text = "0";
            this.lb_unitprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label7.Location = new System.Drawing.Point(242, 818);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "小結 $";
            // 
            // lb_total1
            // 
            this.lb_total1.BackColor = System.Drawing.Color.LightSalmon;
            this.lb_total1.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lb_total1.Location = new System.Drawing.Point(312, 818);
            this.lb_total1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total1.Name = "lb_total1";
            this.lb_total1.Size = new System.Drawing.Size(126, 25);
            this.lb_total1.TabIndex = 2;
            this.lb_total1.Text = "0";
            this.lb_total1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.ckb_chocolate);
            this.groupBox2.Controls.Add(this.ckb_vanilla);
            this.groupBox2.Controls.Add(this.ckb_earlgrey);
            this.groupBox2.Controls.Add(this.ckb_strawberrycheese);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.groupBox2.Location = new System.Drawing.Point(27, 249);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(611, 230);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "泡芙$400/6入(口味可混搭，每盒至多選3種口味)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MistyRose;
            this.label11.ForeColor = System.Drawing.Color.Salmon;
            this.label11.Location = new System.Drawing.Point(439, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "選三種口味";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MistyRose;
            this.label10.ForeColor = System.Drawing.Color.Salmon;
            this.label10.Location = new System.Drawing.Point(252, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 29);
            this.label10.TabIndex = 12;
            this.label10.Text = "選兩種口味";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MistyRose;
            this.label9.ForeColor = System.Drawing.Color.Salmon;
            this.label9.Location = new System.Drawing.Point(45, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "選一種口味";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 61);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(581, 122);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ckb_chocolate
            // 
            this.ckb_chocolate.AutoSize = true;
            this.ckb_chocolate.BackColor = System.Drawing.Color.MistyRose;
            this.ckb_chocolate.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.ckb_chocolate.Location = new System.Drawing.Point(475, 187);
            this.ckb_chocolate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckb_chocolate.Name = "ckb_chocolate";
            this.ckb_chocolate.Size = new System.Drawing.Size(120, 33);
            this.ckb_chocolate.TabIndex = 0;
            this.ckb_chocolate.Text = "香濃可可";
            this.ckb_chocolate.UseVisualStyleBackColor = false;
            // 
            // ckb_vanilla
            // 
            this.ckb_vanilla.AutoSize = true;
            this.ckb_vanilla.BackColor = System.Drawing.Color.MistyRose;
            this.ckb_vanilla.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.ckb_vanilla.Location = new System.Drawing.Point(316, 187);
            this.ckb_vanilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckb_vanilla.Name = "ckb_vanilla";
            this.ckb_vanilla.Size = new System.Drawing.Size(120, 33);
            this.ckb_vanilla.TabIndex = 0;
            this.ckb_vanilla.Text = "香草奶油";
            this.ckb_vanilla.UseVisualStyleBackColor = false;
            // 
            // ckb_earlgrey
            // 
            this.ckb_earlgrey.AutoSize = true;
            this.ckb_earlgrey.BackColor = System.Drawing.Color.MistyRose;
            this.ckb_earlgrey.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.ckb_earlgrey.Location = new System.Drawing.Point(183, 187);
            this.ckb_earlgrey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckb_earlgrey.Name = "ckb_earlgrey";
            this.ckb_earlgrey.Size = new System.Drawing.Size(98, 33);
            this.ckb_earlgrey.TabIndex = 0;
            this.ckb_earlgrey.Text = "伯爵茶";
            this.ckb_earlgrey.UseVisualStyleBackColor = false;
            // 
            // ckb_strawberrycheese
            // 
            this.ckb_strawberrycheese.AutoSize = true;
            this.ckb_strawberrycheese.BackColor = System.Drawing.Color.MistyRose;
            this.ckb_strawberrycheese.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.ckb_strawberrycheese.Location = new System.Drawing.Point(14, 187);
            this.ckb_strawberrycheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckb_strawberrycheese.Name = "ckb_strawberrycheese";
            this.ckb_strawberrycheese.Size = new System.Drawing.Size(120, 33);
            this.ckb_strawberrycheese.TabIndex = 0;
            this.ckb_strawberrycheese.Text = "草莓起司";
            this.ckb_strawberrycheese.UseVisualStyleBackColor = false;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addproduct.BackgroundImage")));
            this.btn_addproduct.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_addproduct.Location = new System.Drawing.Point(502, 774);
            this.btn_addproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(136, 40);
            this.btn_addproduct.TabIndex = 7;
            this.btn_addproduct.Text = "加入訂單";
            this.btn_addproduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // btn_addpuff
            // 
            this.btn_addpuff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addpuff.BackgroundImage")));
            this.btn_addpuff.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_addpuff.Location = new System.Drawing.Point(448, 483);
            this.btn_addpuff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addpuff.Name = "btn_addpuff";
            this.btn_addpuff.Size = new System.Drawing.Size(190, 40);
            this.btn_addpuff.TabIndex = 7;
            this.btn_addpuff.Text = "加入一盒泡芙";
            this.btn_addpuff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addpuff.UseVisualStyleBackColor = true;
            this.btn_addpuff.Click += new System.EventHandler(this.btn_addpuff_Click);
            // 
            // cbox_delivery
            // 
            this.cbox_delivery.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.cbox_delivery.FormattingEnabled = true;
            this.cbox_delivery.Location = new System.Drawing.Point(124, 208);
            this.cbox_delivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_delivery.Name = "cbox_delivery";
            this.cbox_delivery.Size = new System.Drawing.Size(234, 33);
            this.cbox_delivery.TabIndex = 8;
            this.cbox_delivery.SelectedIndexChanged += new System.EventHandler(this.cbox_delivery_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label6.Location = new System.Drawing.Point(32, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "取貨方式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_giftbox);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbtn_giftbag);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.groupBox1.Location = new System.Drawing.Point(465, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(173, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "包裝";
            // 
            // rbtn_giftbox
            // 
            this.rbtn_giftbox.AutoSize = true;
            this.rbtn_giftbox.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.rbtn_giftbox.Location = new System.Drawing.Point(15, 93);
            this.rbtn_giftbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_giftbox.Name = "rbtn_giftbox";
            this.rbtn_giftbox.Size = new System.Drawing.Size(140, 29);
            this.rbtn_giftbox.TabIndex = 0;
            this.rbtn_giftbox.TabStop = true;
            this.rbtn_giftbox.Text = "禮盒(+$100)";
            this.rbtn_giftbox.UseVisualStyleBackColor = true;
            this.rbtn_giftbox.CheckedChanged += new System.EventHandler(this.rbtn_giftbox_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.radioButton1.Location = new System.Drawing.Point(15, 30);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "基本包裝";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rbtn_giftbag_CheckedChanged);
            // 
            // rbtn_giftbag
            // 
            this.rbtn_giftbag.AutoSize = true;
            this.rbtn_giftbag.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.rbtn_giftbag.Location = new System.Drawing.Point(15, 60);
            this.rbtn_giftbag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_giftbag.Name = "rbtn_giftbag";
            this.rbtn_giftbag.Size = new System.Drawing.Size(129, 29);
            this.rbtn_giftbag.TabIndex = 0;
            this.rbtn_giftbag.TabStop = true;
            this.rbtn_giftbag.Text = "提袋(+$20)";
            this.rbtn_giftbag.UseVisualStyleBackColor = true;
            this.rbtn_giftbag.CheckedChanged += new System.EventHandler(this.rbtn_giftbag_CheckedChanged);
            // 
            // num_productamount
            // 
            this.num_productamount.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.num_productamount.Location = new System.Drawing.Point(77, 774);
            this.num_productamount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_productamount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num_productamount.Name = "num_productamount";
            this.num_productamount.Size = new System.Drawing.Size(71, 37);
            this.num_productamount.TabIndex = 1;
            this.num_productamount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_productamount.ValueChanged += new System.EventHandler(this.num_productamount_ValueChanged);
            // 
            // btn_form2
            // 
            this.btn_form2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_form2.BackgroundImage")));
            this.btn_form2.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_form2.Location = new System.Drawing.Point(448, 818);
            this.btn_form2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(190, 40);
            this.btn_form2.TabIndex = 7;
            this.btn_form2.Text = "前往購物車";
            this.btn_form2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_form2.UseVisualStyleBackColor = true;
            this.btn_form2.Click += new System.EventHandler(this.btn_form2_Click);
            // 
            // lb_puffamount
            // 
            this.lb_puffamount.BackColor = System.Drawing.Color.LightSalmon;
            this.lb_puffamount.Font = new System.Drawing.Font("Yu Gothic", 16F);
            this.lb_puffamount.Location = new System.Drawing.Point(31, 483);
            this.lb_puffamount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_puffamount.Name = "lb_puffamount";
            this.lb_puffamount.Size = new System.Drawing.Size(410, 40);
            this.lb_puffamount.TabIndex = 10;
            this.lb_puffamount.Text = "目前未選購泡芙";
            this.lb_puffamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.label8.Location = new System.Drawing.Point(338, 782);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "小計 $";
            // 
            // lb_subtotal
            // 
            this.lb_subtotal.BackColor = System.Drawing.Color.LightSalmon;
            this.lb_subtotal.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.lb_subtotal.Location = new System.Drawing.Point(408, 782);
            this.lb_subtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_subtotal.Name = "lb_subtotal";
            this.lb_subtotal.Size = new System.Drawing.Size(70, 25);
            this.lb_subtotal.TabIndex = 2;
            this.lb_subtotal.Text = "0";
            this.lb_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menu.BackgroundImage")));
            this.btn_menu.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.btn_menu.Location = new System.Drawing.Point(447, 533);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(190, 40);
            this.btn_menu.TabIndex = 7;
            this.btn_menu.Text = "甜點實拍照片";
            this.btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.label12.Location = new System.Drawing.Point(22, 529);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 40);
            this.label12.TabIndex = 11;
            this.label12.Text = "甜點";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(679, 861);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_puffamount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.num_productamount);
            this.Controls.Add(this.cbox_delivery);
            this.Controls.Add(this.btn_addpuff);
            this.Controls.Add(this.btn_form2);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbox_product);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_subtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_total1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_unitprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "甜點團購單";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_productamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.ListBox lbox_product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_unitprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_total1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckb_chocolate;
        private System.Windows.Forms.CheckBox ckb_vanilla;
        private System.Windows.Forms.CheckBox ckb_earlgrey;
        private System.Windows.Forms.CheckBox ckb_strawberrycheese;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Button btn_addpuff;
        private System.Windows.Forms.ComboBox cbox_delivery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_giftbox;
        private System.Windows.Forms.RadioButton rbtn_giftbag;
        private System.Windows.Forms.NumericUpDown num_productamount;
        private System.Windows.Forms.Button btn_form2;
        private System.Windows.Forms.Label lb_puffamount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_subtotal;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}

