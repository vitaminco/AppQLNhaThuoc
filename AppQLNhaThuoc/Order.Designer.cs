﻿namespace AppQLNhaThuoc
{
    partial class Order
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
            this.Option = new System.Windows.Forms.GroupBox();
            this.btnCloseOr = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.createdAt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delMedi = new System.Windows.Forms.Button();
            this.addMedi = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.Option.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.Controls.Add(this.btnCloseOr);
            this.Option.Controls.Add(this.lblTongTien);
            this.Option.Controls.Add(this.lblMaCN);
            this.Option.Controls.Add(this.createdAt);
            this.Option.Controls.Add(this.label4);
            this.Option.Controls.Add(this.label3);
            this.Option.Controls.Add(this.label2);
            this.Option.Controls.Add(this.label1);
            this.Option.Controls.Add(this.delMedi);
            this.Option.Controls.Add(this.addMedi);
            this.Option.Controls.Add(this.txtMaKH);
            this.Option.Controls.Add(this.txtMaDH);
            this.Option.Location = new System.Drawing.Point(7, 3);
            this.Option.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Option.Name = "Option";
            this.Option.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Option.Size = new System.Drawing.Size(589, 137);
            this.Option.TabIndex = 3;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // btnCloseOr
            // 
            this.btnCloseOr.BackColor = System.Drawing.Color.Red;
            this.btnCloseOr.ForeColor = System.Drawing.Color.White;
            this.btnCloseOr.Location = new System.Drawing.Point(474, 94);
            this.btnCloseOr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseOr.Name = "btnCloseOr";
            this.btnCloseOr.Size = new System.Drawing.Size(92, 24);
            this.btnCloseOr.TabIndex = 25;
            this.btnCloseOr.Text = "Đóng";
            this.btnCloseOr.UseVisualStyleBackColor = false;
            this.btnCloseOr.Click += new System.EventHandler(this.btnCloseOr_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.Red;
            this.lblTongTien.ForeColor = System.Drawing.Color.White;
            this.lblTongTien.Location = new System.Drawing.Point(310, 106);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(50, 13);
            this.lblTongTien.TabIndex = 24;
            this.lblTongTien.Text = "Tổng tền";
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Location = new System.Drawing.Point(146, 106);
            this.lblMaCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(69, 13);
            this.lblMaCN.TabIndex = 24;
            this.lblMaCN.Text = "MaChiNhanh";
            // 
            // createdAt
            // 
            this.createdAt.AutoSize = true;
            this.createdAt.Location = new System.Drawing.Point(146, 80);
            this.createdAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createdAt.Name = "createdAt";
            this.createdAt.Size = new System.Drawing.Size(51, 13);
            this.createdAt.TabIndex = 24;
            this.createdAt.Text = "Ngày đặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "MaCN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "MaKH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "MaĐH";
            // 
            // delMedi
            // 
            this.delMedi.BackColor = System.Drawing.Color.OliveDrab;
            this.delMedi.ForeColor = System.Drawing.Color.White;
            this.delMedi.Location = new System.Drawing.Point(474, 61);
            this.delMedi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delMedi.Name = "delMedi";
            this.delMedi.Size = new System.Drawing.Size(92, 24);
            this.delMedi.TabIndex = 14;
            this.delMedi.Text = "Xóa";
            this.delMedi.UseVisualStyleBackColor = false;
            this.delMedi.Click += new System.EventHandler(this.delMedi_Click);
            // 
            // addMedi
            // 
            this.addMedi.BackColor = System.Drawing.Color.OliveDrab;
            this.addMedi.ForeColor = System.Drawing.Color.White;
            this.addMedi.Location = new System.Drawing.Point(474, 24);
            this.addMedi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addMedi.Name = "addMedi";
            this.addMedi.Size = new System.Drawing.Size(92, 24);
            this.addMedi.TabIndex = 16;
            this.addMedi.Text = "Thêm";
            this.addMedi.UseVisualStyleBackColor = false;
            this.addMedi.Click += new System.EventHandler(this.addMedi_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(142, 48);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(289, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(142, 20);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(290, 20);
            this.txtMaDH.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataOrder);
            this.groupBox1.Location = new System.Drawing.Point(4, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(593, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // dataOrder
            // 
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrder.Location = new System.Drawing.Point(0, 15);
            this.dataOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.RowHeadersWidth = 51;
            this.dataOrder.RowTemplate.Height = 24;
            this.dataOrder.Size = new System.Drawing.Size(592, 219);
            this.dataOrder.TabIndex = 0;
            this.dataOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order";
            this.Text = "Đặt hàng";
            this.Load += new System.EventHandler(this.Order_Load);
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.Button delMedi;
        private System.Windows.Forms.Button addMedi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label createdAt;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnCloseOr;
    }
}