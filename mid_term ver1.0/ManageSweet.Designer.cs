namespace mid_term_ver1._0
{
    partial class addSweet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSweet));
            this.lb_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dgv_allSweetList = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_deleteSweet = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_addSweet = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lable134 = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allSweetList)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("微軟正黑體", 28F);
            this.lb_title.Image = ((System.Drawing.Image)(resources.GetObject("lb_title.Image")));
            this.lb_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_title.Location = new System.Drawing.Point(232, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(1056, 117);
            this.lb_title.TabIndex = 18;
            this.lb_title.Text = "　　　　甜點管理";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.txt_desc.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this.txt_desc.Location = new System.Drawing.Point(157, 526);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(548, 197);
            this.txt_desc.TabIndex = 42;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.txt_price.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this.txt_price.Location = new System.Drawing.Point(157, 432);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.MaxLength = 10;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(548, 71);
            this.txt_price.TabIndex = 40;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.txt_name.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this.txt_name.Location = new System.Drawing.Point(157, 340);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(548, 71);
            this.txt_name.TabIndex = 41;
            // 
            // dgv_allSweetList
            // 
            this.dgv_allSweetList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.dgv_allSweetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allSweetList.Location = new System.Drawing.Point(715, 143);
            this.dgv_allSweetList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_allSweetList.Name = "dgv_allSweetList";
            this.dgv_allSweetList.RowHeadersWidth = 62;
            this.dgv_allSweetList.RowTemplate.Height = 24;
            this.dgv_allSweetList.Size = new System.Drawing.Size(768, 753);
            this.dgv_allSweetList.TabIndex = 39;
            this.dgv_allSweetList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_allSweetList_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 434);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 68);
            this.label10.TabIndex = 38;
            this.label10.Text = "價格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 528);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 68);
            this.label5.TabIndex = 37;
            this.label5.Text = "說明";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 341);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 68);
            this.label6.TabIndex = 36;
            this.label6.Text = "品名";
            // 
            // btn_deleteSweet
            // 
            this.btn_deleteSweet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deleteSweet.BackgroundImage")));
            this.btn_deleteSweet.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_deleteSweet.Location = new System.Drawing.Point(1183, 987);
            this.btn_deleteSweet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteSweet.Name = "btn_deleteSweet";
            this.btn_deleteSweet.Size = new System.Drawing.Size(300, 75);
            this.btn_deleteSweet.TabIndex = 33;
            this.btn_deleteSweet.Text = "甜點下架";
            this.btn_deleteSweet.UseVisualStyleBackColor = true;
            this.btn_deleteSweet.Click += new System.EventHandler(this.btn_deleteSweet_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reload.BackgroundImage")));
            this.btn_reload.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reload.Location = new System.Drawing.Point(875, 904);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(300, 75);
            this.btn_reload.TabIndex = 34;
            this.btn_reload.Text = "重新載入";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_addSweet
            // 
            this.btn_addSweet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addSweet.BackgroundImage")));
            this.btn_addSweet.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addSweet.Location = new System.Drawing.Point(1183, 904);
            this.btn_addSweet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addSweet.Name = "btn_addSweet";
            this.btn_addSweet.Size = new System.Drawing.Size(300, 75);
            this.btn_addSweet.TabIndex = 35;
            this.btn_addSweet.Text = "新增甜點";
            this.btn_addSweet.UseVisualStyleBackColor = true;
            this.btn_addSweet.Click += new System.EventHandler(this.btn_addSweet_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save.Location = new System.Drawing.Point(553, 904);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(300, 75);
            this.btn_save.TabIndex = 43;
            this.btn_save.Text = "儲存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(553, 987);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(300, 75);
            this.btn_clear.TabIndex = 44;
            this.btn_clear.Text = "清空欄位";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lable134
            // 
            this.lable134.AutoSize = true;
            this.lable134.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable134.Location = new System.Drawing.Point(13, 243);
            this.lable134.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable134.Name = "lable134";
            this.lable134.Size = new System.Drawing.Size(135, 68);
            this.lable134.TabIndex = 46;
            this.lable134.Text = "編號";
            // 
            // lb_ID
            // 
            this.lb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.lb_ID.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(157, 243);
            this.lb_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(550, 68);
            this.lb_ID.TabIndex = 45;
            // 
            // addSweet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1514, 1096);
            this.Controls.Add(this.lable134);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_allSweetList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_deleteSweet);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_addSweet);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "addSweet";
            this.Text = "AddSweet";
            this.Load += new System.EventHandler(this.AddSweet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allSweetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView dgv_allSweetList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_deleteSweet;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_addSweet;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lable134;
        private System.Windows.Forms.Label lb_ID;
    }
}