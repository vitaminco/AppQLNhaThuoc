
using System;
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    public partial class Order : Form
    {
        function f = new function();
        string query;

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

        public Order()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataOrder.Rows[e.RowIndex];
                txtMaDH.Text = row.Cells["maDH"].Value.ToString();
                txtMaKH.Text = row.Cells["maKH"].Value.ToString();
                createdAt.Text = row.Cells["ngayDat"].Value.ToString();
                lblTongTien.Text = row.Cells["totalAmount"].Value.ToString();
                lblMaCN.Text = row.Cells["maCN"].Value.ToString();
            }
        }

        private void Order_Load(object sender, System.EventArgs e)
        {
            query = "select * from DONHANG";
            DataSet ds = f.getData(query);
            dataOrder.DataSource = ds.Tables[0];
        }

        private void addMedi_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Kiểm tra xem mã đơn hàng, mã khách hàng và mã chi nhánh đã được nhập chưa
                if (!string.IsNullOrEmpty(txtMaDH.Text) && !string.IsNullOrEmpty(txtMaKH.Text) && !string.IsNullOrEmpty(lblMaCN.Text))
                {
                    string maDh = txtMaDH.Text;
                    string maKh = txtMaKH.Text;
                    string maCn = lblMaCN.Text; // Giả sử bạn đã lấy mã chi nhánh từ một label
                    decimal totalAmount = 1000; // Giá trị mẫu cho totalAmount, bạn có thể thay thế với dữ liệu thực tế

                    // Đảm bảo câu lệnh SQL đúng định dạng và các giá trị được truyền vào chính xác
                    string query = "INSERT INTO [DONHANG] ([maDH], [maKH], [ngayDat], [totalAmount], [maCN]) " +
                                   "VALUES (N'" + maDh + "', N'" + maKh + "', GETDATE(), " + totalAmount + ", N'" + maCn + "')";

                    // Thêm dữ liệu vào cơ sở dữ liệu
                    f.setData(query, "Thêm đơn hàng thành công");

                    // Tải lại dữ liệu sau khi thêm mới
                    Order_Load(this, null);

                    // Xóa nội dung các trường nhập
                    txtMaDH.Clear();
                    txtMaKH.Clear();

                    // Hiển thị form chi tiết đơn hàng
                    using (Option orderDetailForm = new Option())
                    {
                        orderDetailForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã đơn hàng và mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delMedi_Click(object sender, System.EventArgs e)
        {
            if (lblMaCN is null && txtMaDH != null)
            {
                string maDH = txtMaDH.Text;
                string query = "DELETE FROM DONHANG WHERE maDH = '" + maDH + "'";

                f.setData(query, "Xóa thành công");
                Order_Load(this, null);
            }
            else
            {
                f.setData(query, "Xóa không thành công");
            }
        }

        private void btnCloseOr_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
