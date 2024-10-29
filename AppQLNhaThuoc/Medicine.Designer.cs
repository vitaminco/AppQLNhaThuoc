namespace AppQLNhaThuoc
{
    partial class Medicine
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
            this.btnCloseMe = new System.Windows.Forms.Button();
            this.dateTimeHSD = new System.Windows.Forms.DateTimePicker();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delMedi = new System.Windows.Forms.Button();
            this.updateMedi = new System.Windows.Forms.Button();
            this.addMedi = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtMaT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataMedi = new System.Windows.Forms.DataGridView();
            this.Option.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedi)).BeginInit();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.Controls.Add(this.btnCloseMe);
            this.Option.Controls.Add(this.dateTimeHSD);
            this.Option.Controls.Add(this.lblMaCN);
            this.Option.Controls.Add(this.label5);
            this.Option.Controls.Add(this.label4);
            this.Option.Controls.Add(this.label3);
            this.Option.Controls.Add(this.label2);
            this.Option.Controls.Add(this.label1);
            this.Option.Controls.Add(this.delMedi);
            this.Option.Controls.Add(this.updateMedi);
            this.Option.Controls.Add(this.addMedi);
            this.Option.Controls.Add(this.txtGiaBan);
            this.Option.Controls.Add(this.txtSoLuong);
            this.Option.Controls.Add(this.txtTenThuoc);
            this.Option.Controls.Add(this.txtMaT);
            this.Option.Location = new System.Drawing.Point(7, 3);
            this.Option.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Option.Name = "Option";
            this.Option.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Option.Size = new System.Drawing.Size(589, 137);
            this.Option.TabIndex = 3;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // btnCloseMe
            // 
            this.btnCloseMe.BackColor = System.Drawing.Color.Red;
            this.btnCloseMe.ForeColor = System.Drawing.Color.White;
            this.btnCloseMe.Location = new System.Drawing.Point(475, 107);
            this.btnCloseMe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseMe.Name = "btnCloseMe";
            this.btnCloseMe.Size = new System.Drawing.Size(92, 24);
            this.btnCloseMe.TabIndex = 21;
            this.btnCloseMe.Text = "Đóng";
            this.btnCloseMe.UseVisualStyleBackColor = false;
            this.btnCloseMe.Click += new System.EventHandler(this.btnCloseMe_Click);
            // 
            // dateTimeHSD
            // 
            this.dateTimeHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHSD.Location = new System.Drawing.Point(146, 119);
            this.dateTimeHSD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeHSD.Name = "dateTimeHSD";
            this.dateTimeHSD.Size = new System.Drawing.Size(280, 20);
            this.dateTimeHSD.TabIndex = 20;
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Location = new System.Drawing.Point(472, 108);
            this.lblMaCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(0, 13);
            this.lblMaCN.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "HSD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gía bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Thuốc";
            // 
            // delMedi
            // 
            this.delMedi.BackColor = System.Drawing.Color.OliveDrab;
            this.delMedi.ForeColor = System.Drawing.Color.White;
            this.delMedi.Location = new System.Drawing.Point(475, 73);
            this.delMedi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delMedi.Name = "delMedi";
            this.delMedi.Size = new System.Drawing.Size(92, 24);
            this.delMedi.TabIndex = 11;
            this.delMedi.Text = "Xóa";
            this.delMedi.UseVisualStyleBackColor = false;
            this.delMedi.Click += new System.EventHandler(this.delMedi_Click);
            // 
            // updateMedi
            // 
            this.updateMedi.BackColor = System.Drawing.Color.OliveDrab;
            this.updateMedi.ForeColor = System.Drawing.Color.White;
            this.updateMedi.Location = new System.Drawing.Point(475, 44);
            this.updateMedi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateMedi.Name = "updateMedi";
            this.updateMedi.Size = new System.Drawing.Size(92, 24);
            this.updateMedi.TabIndex = 12;
            this.updateMedi.Text = "Sửa";
            this.updateMedi.UseVisualStyleBackColor = false;
            this.updateMedi.Click += new System.EventHandler(this.updateMedi_Click);
            // 
            // addMedi
            // 
            this.addMedi.BackColor = System.Drawing.Color.OliveDrab;
            this.addMedi.ForeColor = System.Drawing.Color.White;
            this.addMedi.Location = new System.Drawing.Point(475, 15);
            this.addMedi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addMedi.Name = "addMedi";
            this.addMedi.Size = new System.Drawing.Size(92, 24);
            this.addMedi.TabIndex = 13;
            this.addMedi.Text = "Thêm";
            this.addMedi.UseVisualStyleBackColor = false;
            this.addMedi.Click += new System.EventHandler(this.addMedi_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(146, 90);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(281, 20);
            this.txtGiaBan.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(146, 61);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(280, 20);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(146, 32);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(281, 20);
            this.txtTenThuoc.TabIndex = 1;
            // 
            // txtMaT
            // 
            this.txtMaT.Location = new System.Drawing.Point(146, 4);
            this.txtMaT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaT.Name = "txtMaT";
            this.txtMaT.Size = new System.Drawing.Size(282, 20);
            this.txtMaT.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataMedi);
            this.groupBox1.Location = new System.Drawing.Point(4, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(593, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // dataMedi
            // 
            this.dataMedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMedi.Location = new System.Drawing.Point(0, 15);
            this.dataMedi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataMedi.Name = "dataMedi";
            this.dataMedi.RowHeadersWidth = 51;
            this.dataMedi.RowTemplate.Height = 24;
            this.dataMedi.Size = new System.Drawing.Size(592, 219);
            this.dataMedi.TabIndex = 0;
            this.dataMedi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMedi_CellContentClick);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Medicine";
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.Medicine_Load);
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMedi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtMaT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataMedi;
        private System.Windows.Forms.Button delMedi;
        private System.Windows.Forms.Button updateMedi;
        private System.Windows.Forms.Button addMedi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.Button btnCloseMe;
    }
}