﻿namespace mid_term_ver1._0
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
            this.lblchkNum = new System.Windows.Forms.Label();
            this.btn_changeChkNum = new System.Windows.Forms.Button();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtchkNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 520);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 606);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 710);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 68);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 822);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 68);
            this.label3.TabIndex = 3;
            this.label3.Text = "輸入驗證碼";
            // 
            // lblchkNum
            // 
            this.lblchkNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.lblchkNum.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblchkNum.Location = new System.Drawing.Point(861, 818);
            this.lblchkNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblchkNum.Name = "lblchkNum";
            this.lblchkNum.Size = new System.Drawing.Size(210, 75);
            this.lblchkNum.TabIndex = 4;
            this.lblchkNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_changeChkNum
            // 
            this.btn_changeChkNum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_changeChkNum.BackgroundImage")));
            this.btn_changeChkNum.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_changeChkNum.Location = new System.Drawing.Point(1110, 818);
            this.btn_changeChkNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_changeChkNum.Name = "btn_changeChkNum";
            this.btn_changeChkNum.Size = new System.Drawing.Size(300, 75);
            this.btn_changeChkNum.TabIndex = 5;
            this.btn_changeChkNum.Text = "換一個";
            this.btn_changeChkNum.UseVisualStyleBackColor = true;
            this.btn_changeChkNum.Click += new System.EventHandler(this.btn_changeChkNum_Click);
            // 
            // btn_signIn
            // 
            this.btn_signIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_signIn.BackgroundImage")));
            this.btn_signIn.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_signIn.Location = new System.Drawing.Point(857, 957);
            this.btn_signIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(300, 75);
            this.btn_signIn.TabIndex = 5;
            this.btn_signIn.Text = "登入";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_signUp.BackgroundImage")));
            this.btn_signUp.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_signUp.Location = new System.Drawing.Point(529, 957);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(300, 75);
            this.btn_signUp.TabIndex = 5;
            this.btn_signUp.Text = "註冊";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this.textBox1.Location = new System.Drawing.Point(621, 604);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 71);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this.textBox2.Location = new System.Drawing.Point(621, 708);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(448, 71);
            this.textBox2.TabIndex = 6;
            // 
            // txtchkNum
            // 
            this.txtchkNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.txtchkNum.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this.txtchkNum.Location = new System.Drawing.Point(621, 818);
            this.txtchkNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtchkNum.Name = "txtchkNum";
            this.txtchkNum.Size = new System.Drawing.Size(208, 71);
            this.txtchkNum.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1614, 1167);
            this.Controls.Add(this.txtchkNum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.btn_changeChkNum);
            this.Controls.Add(this.lblchkNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblchkNum;
        private System.Windows.Forms.Button btn_changeChkNum;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtchkNum;
    }
}

