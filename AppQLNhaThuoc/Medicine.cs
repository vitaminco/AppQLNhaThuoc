
using System;
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    public partial class Medicine : Form
    {
        function f = new function();
        string query;

        public Medicine()
        {
            InitializeComponent();
        }

        private void Medicine_Load(object sender, System.EventArgs e)
        {
            query = "select * from THUOC";
            DataSet ds = f.getData(query);
            dataMedi.DataSource = ds.Tables[0];
        }

        private void addMedi_Click(object sender, System.EventArgs e)
        {
            // Truy vấn dữ liệu từ bảng CHINHANH
            string queryChiNhanh = "SELECT * FROM CHINHANH";
            DataSet dsCn = f.getData(queryChiNhanh);

            // Biến lưu mã chi nhánh tạm thời
            string macn = "";

            // Kiểm tra nếu DataSet có chứa bảng và bảng có ít nhất một hàng
            if (dsCn.Tables.Count > 0 && dsCn.Tables[0].Rows.Count > 0)
            {
                // Lấy giá trị của cột "maCN" từ hàng đầu tiên và lưu vào biến macn
                macn = dsCn.Tables[0].Rows[0]["maCN"].ToString();
                lblMaCN.Text = macn; // Gán vào TextBox để hiển thị cho người dùng
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu trong bảng CHINHANH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đầu vào
            if (txtMaT.Text == "" || txtTenThuoc.Text == "" || txtSoLuong.Text == "" || txtGiaBan.Text == "" || dateTimeHSD.Text == "" || string.IsNullOrWhiteSpace(macn))
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ma = txtMaT.Text;
                string ten = txtTenThuoc.Text;
                int so = Convert.ToInt32(txtSoLuong.Text);
                decimal gia = Convert.ToDecimal(txtGiaBan.Text);

                DateTime hsd = dateTimeHSD.Value;
                string dateString = hsd.ToString("yyyy-MM-dd");

                // Câu lệnh INSERT đã sửa
                string query = $"INSERT INTO THUOC (maThuoc, tenThuoc, soLuong, giaBan, hanSuDung, maCN) " +
                               $"VALUES ('{ma}', N'{ten}', {so}, {gia}, '{dateString}', '{macn}')";

                f.setData(query, "Thêm thuốc thành công");
                Medicine_Load(this, null);

                // Xóa dữ liệu trong TextBox
                txtMaT.Clear();
                txtTenThuoc.Clear();
                txtSoLuong.Clear();
                txtGiaBan.Clear();
            }
        }

        private void updateMedi_Click(object sender, EventArgs e)
        {
            // Truy vấn dữ liệu từ bảng CHINHANH
            string queryChiNhanh = "SELECT * FROM CHINHANH";
            DataSet dsCn = f.getData(queryChiNhanh);

            // Biến lưu mã chi nhánh tạm thời
            string macn = "";

            // Kiểm tra nếu DataSet có chứa bảng và bảng có ít nhất một hàng
            if (dsCn.Tables.Count > 0 && dsCn.Tables[0].Rows.Count > 0)
            {
                // Lấy giá trị của cột "maCN" từ hàng đầu tiên và lưu vào biến macn
                macn = dsCn.Tables[0].Rows[0]["maCN"].ToString();
                lblMaCN.Text = macn; // Gán vào Label để hiển thị cho người dùng
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu trong bảng CHINHANH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đầu vào
            if (txtMaT.Text == "" || txtTenThuoc.Text == "" || txtSoLuong.Text == "" || txtGiaBan.Text == "" || dateTimeHSD.Text == "" || string.IsNullOrWhiteSpace(macn))
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maThuoc = txtMaT.Text;
                string tenThuoc = txtTenThuoc.Text;
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                float giaBan = Convert.ToSingle(txtGiaBan.Text);
                string hanSuDung = dateTimeHSD.Value.ToString("yyyy-MM-dd");

                // Câu lệnh UPDATE đã sửa
                string query = $"UPDATE THUOC SET tenThuoc = N'{tenThuoc}', soLuong = {soLuong}, giaBan = {giaBan}, hanSuDung = '{hanSuDung}', maCN = '{macn}' WHERE maThuoc = '{maThuoc}'";

                // Gọi phương thức setData để thực hiện câu lệnh SQL và thông báo
                f.setData(query, "Cập nhật thông tin thuốc thành công");

                // Tải lại dữ liệu trong bảng sau khi cập nhật
                Medicine_Load(this, null);

                // Xóa các trường sau khi cập nhật xong
                txtMaT.Clear();
                txtTenThuoc.Clear();
                txtSoLuong.Clear();
                txtGiaBan.Clear();
                dateTimeHSD.Value = DateTime.Now;
            }
        }

        private void delMedi_Click(object sender, System.EventArgs e)
        {
            if (lblMaCN is null) {
                string maT = txtMaT.Text;
                string query = "DELETE FROM THUOC WHERE maThuoc = '" + maT + "'";

                f.setData(query, "Xóa thành công");
                Medicine_Load(this, null);
            }
            else
            {
                f.setData(query, "Xóa không thành công do có khóa ngoại");
            }
        }

        private void dataMedi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dataMedi.Rows[e.RowIndex];
                txtMaT.Text = row.Cells["maThuoc"].Value.ToString();
                txtTenThuoc.Text = row.Cells["tenThuoc"].Value.ToString();
                txtSoLuong.Text = row.Cells["soLuong"].Value.ToString();
                txtGiaBan.Text = row.Cells["giaBan"].Value.ToString();
                dateTimeHSD.Text = row.Cells["hanSuDung"].Value.ToString();
                lblMaCN.Text = row.Cells["maCN"].Value.ToString();
            }
        }

        private void btnCloseMe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
