﻿namespace AppQLNhaThuoc
{
    partial class Option
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaT = new System.Windows.Forms.TextBox();
            this.btnCloseOp = new System.Windows.Forms.Button();
            this.delThuoc = new System.Windows.Forms.Button();
            this.updateThuoc = new System.Windows.Forms.Button();
            this.addThuoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHSD = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataOption = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOption)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "HSD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaT);
            this.groupBox2.Controls.Add(this.btnCloseOp);
            this.groupBox2.Controls.Add(this.delThuoc);
            this.groupBox2.Controls.Add(this.updateThuoc);
            this.groupBox2.Controls.Add(this.addThuoc);
            this.groupBox2.Location = new System.Drawing.Point(427, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(171, 355);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtMaT
            // 
            this.txtMaT.Location = new System.Drawing.Point(44, 254);
            this.txtMaT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaT.Name = "txtMaT";
            this.txtMaT.Size = new System.Drawing.Size(102, 20);
            this.txtMaT.TabIndex = 17;
            // 
            // btnCloseOp
            // 
            this.btnCloseOp.BackColor = System.Drawing.Color.Red;
            this.btnCloseOp.ForeColor = System.Drawing.Color.White;
            this.btnCloseOp.Location = new System.Drawing.Point(41, 307);
            this.btnCloseOp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseOp.Name = "btnCloseOp";
            this.btnCloseOp.Size = new System.Drawing.Size(92, 24);
            this.btnCloseOp.TabIndex = 14;
            this.btnCloseOp.Text = "Đóng";
            this.btnCloseOp.UseVisualStyleBackColor = false;
            this.btnCloseOp.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // delThuoc
            // 
            this.delThuoc.BackColor = System.Drawing.Color.OliveDrab;
            this.delThuoc.ForeColor = System.Drawing.Color.White;
            this.delThuoc.Location = new System.Drawing.Point(41, 176);
            this.delThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delThuoc.Name = "delThuoc";
            this.delThuoc.Size = new System.Drawing.Size(92, 24);
            this.delThuoc.TabIndex = 14;
            this.delThuoc.Text = "Xóa";
            this.delThuoc.UseVisualStyleBackColor = false;
            // 
            // updateThuoc
            // 
            this.updateThuoc.BackColor = System.Drawing.Color.OliveDrab;
            this.updateThuoc.ForeColor = System.Drawing.Color.White;
            this.updateThuoc.Location = new System.Drawing.Point(41, 147);
            this.updateThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateThuoc.Name = "updateThuoc";
            this.updateThuoc.Size = new System.Drawing.Size(92, 24);
            this.updateThuoc.TabIndex = 15;
            this.updateThuoc.Text = "Sửa";
            this.updateThuoc.UseVisualStyleBackColor = false;
            // 
            // addThuoc
            // 
            this.addThuoc.BackColor = System.Drawing.Color.OliveDrab;
            this.addThuoc.ForeColor = System.Drawing.Color.White;
            this.addThuoc.Location = new System.Drawing.Point(41, 118);
            this.addThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addThuoc.Name = "addThuoc";
            this.addThuoc.Size = new System.Drawing.Size(92, 24);
            this.addThuoc.TabIndex = 16;
            this.addThuoc.Text = "Thêm";
            this.addThuoc.UseVisualStyleBackColor = false;
            this.addThuoc.Click += new System.EventHandler(this.addThuoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gía";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(531, 405);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHSD);
            this.groupBox1.Controls.Add(this.lblGia);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(413, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // lblHSD
            // 
            this.lblHSD.AutoSize = true;
            this.lblHSD.Location = new System.Drawing.Point(143, 110);
            this.lblHSD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHSD.Name = "lblHSD";
            this.lblHSD.Size = new System.Drawing.Size(30, 13);
            this.lblHSD.TabIndex = 25;
            this.lblHSD.Text = "HSD";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(143, 75);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(25, 13);
            this.lblGia.TabIndex = 25;
            this.lblGia.Text = "Gía";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(143, 36);
            this.lblTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(56, 13);
            this.lblTen.TabIndex = 25;
            this.lblTen.Text = "Tên thuốc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 152);
            this.panel1.TabIndex = 3;
            // 
            // dataOption
            // 
            this.dataOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOption.Location = new System.Drawing.Point(2, 158);
            this.dataOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataOption.Name = "dataOption";
            this.dataOption.RowHeadersWidth = 51;
            this.dataOption.RowTemplate.Height = 24;
            this.dataOption.Size = new System.Drawing.Size(419, 206);
            this.dataOption.TabIndex = 6;
            this.dataOption.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOption_CellContentClick);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataOption);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Option";
            this.Text = "Chọn lựa";
            this.Load += new System.EventHandler(this.Option_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataOption;
        private System.Windows.Forms.Button delThuoc;
        private System.Windows.Forms.Button updateThuoc;
        private System.Windows.Forms.Button addThuoc;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblHSD;
        private System.Windows.Forms.Button btnCloseOp;
        private System.Windows.Forms.TextBox txtMaT;
    }
}