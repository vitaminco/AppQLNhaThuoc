﻿
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    public partial class Home : Form
    {
        function f = new function();
        string query;

        public Home()
        {
            InitializeComponent();
        }

        private Form currentFormchid;
        public void openchildform(Form childform)
        {
            if (currentFormchid != null && currentFormchid.GetType() != childform.GetType())
            {
                currentFormchid.Close();
            }

            currentFormchid = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childform.BringToFront();
            childform.Show();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            // Hiển thị thông báo xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng tất cả các cửa sổ không?", "Xác nhận đóng cửa sổ", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                // Đóng cửa sổ hiện tại
                this.Close();
            }
        }
        private void Home_Load(object sender, System.EventArgs e)
        {
            string query = "SELECT * FROM CHINHANH";
            DataSet ds = f.getData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                lblChiNhanh.Text = ds.Tables[0].Rows[0]["maCN"].ToString();
            }
        }

        private void btnChiNhanh_Click(object sender, System.EventArgs e)
        {
            openchildform(new Branch());
            Branch branch = new Branch();
            branch.ShowDialog();
        }

        private void btnCate_Click(object sender, System.EventArgs e)
        {
            openchildform(new Warehouse());
            Warehouse category = new Warehouse();
            category.ShowDialog();
        }

        private void btnMedi_Click(object sender, System.EventArgs e)
        {
            openchildform(new Medicine());
            Medicine medicine = new Medicine();
            medicine.ShowDialog();
        }

        private void btnOrder_Click(object sender, System.EventArgs e)
        {
            openchildform(new Order());
            Order order = new Order();
            order.ShowDialog();
        }

        private void btnEmploy_Click(object sender, System.EventArgs e)
        {
            openchildform(new Employ());
            Employ employ = new Employ();
            employ.ShowDialog();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* DataGridViewRow row = data.Rows[e.RowIndex];*/
        }
    }
}
