﻿namespace AppQLNhaThuoc
{
    partial class Home
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
            this.btnChiNhanh = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnEmploy = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnMedi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChiNhanh
            // 
            this.btnChiNhanh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnChiNhanh.ForeColor = System.Drawing.Color.White;
            this.btnChiNhanh.Location = new System.Drawing.Point(23, 462);
            this.btnChiNhanh.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiNhanh.Name = "btnChiNhanh";
            this.btnChiNhanh.Size = new System.Drawing.Size(86, 32);
            this.btnChiNhanh.TabIndex = 0;
            this.btnChiNhanh.Text = "Chi nhánh";
            this.btnChiNhanh.UseVisualStyleBackColor = false;
            this.btnChiNhanh.Visible = false;
            this.btnChiNhanh.Click += new System.EventHandler(this.btnChiNhanh_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(338, 46);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(86, 32);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnEmploy
            // 
            this.btnEmploy.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEmploy.ForeColor = System.Drawing.Color.White;
            this.btnEmploy.Location = new System.Drawing.Point(476, 46);
            this.btnEmploy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(86, 32);
            this.btnEmploy.TabIndex = 0;
            this.btnEmploy.Text = "Nhân viên";
            this.btnEmploy.UseVisualStyleBackColor = false;
            this.btnEmploy.Click += new System.EventHandler(this.btnEmploy_Click);
            // 
            // btnCate
            // 
            this.btnCate.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCate.ForeColor = System.Drawing.Color.White;
            this.btnCate.Location = new System.Drawing.Point(58, 46);
            this.btnCate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(86, 32);
            this.btnCate.TabIndex = 0;
            this.btnCate.Text = "Kho";
            this.btnCate.UseVisualStyleBackColor = false;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnMedi
            // 
            this.btnMedi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMedi.ForeColor = System.Drawing.Color.White;
            this.btnMedi.Location = new System.Drawing.Point(203, 46);
            this.btnMedi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedi.Name = "btnMedi";
            this.btnMedi.Size = new System.Drawing.Size(86, 32);
            this.btnMedi.TabIndex = 0;
            this.btnMedi.Text = "Thuốc";
            this.btnMedi.UseVisualStyleBackColor = false;
            this.btnMedi.Click += new System.EventHandler(this.btnMedi_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(710, 46);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEmploy);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnCate);
            this.groupBox1.Controls.Add(this.btnMedi);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(806, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(-29, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(913, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(-29, 515);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(910, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(823, -44);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 635);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(22, -42);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 630);
            this.button4.TabIndex = 2;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhà thuốc thuộc chi nhánh: ";
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.ForeColor = System.Drawing.Color.White;
            this.lblChiNhanh.Location = new System.Drawing.Point(532, 107);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(0, 31);
            this.lblChiNhanh.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::AppQLNhaThuoc.Properties.Resources.z5449426178580_a9b123523b50a5182b3e57a51a8f827b;
            this.ClientSize = new System.Drawing.Size(852, 551);
            this.Controls.Add(this.lblChiNhanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChiNhanh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChiNhanh;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnEmploy;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnMedi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChiNhanh;
    }
}

