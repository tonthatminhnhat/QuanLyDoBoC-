
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace _20T1020493

{
    public partial class QuanLySach : Form
    {

        string fileName = "C:\\Users\\HP\\source\\repos\\20T1020493\\20T1020493.json";
        List<Sach> danhSachSach = new List<Sach>();
        public QuanLySach()
        {
            InitializeComponent();
            ShowData();
        }
        void ShowData()
        {

            if (File.Exists(fileName))
            {
                var fileInfo = new FileInfo(fileName);
                if (fileInfo.Length > 0)
                {
                    var json = File.ReadAllText(fileName);
                    danhSachSach = JsonConvert.DeserializeObject<List<Sach>>(json);
                    sachBindingSource.DataSource = danhSachSach;
                }
            }
        }
        private void btnXemChiTiet(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Table.SelectedRows[0];
                txtMaSach.Text = selectedRow.Cells[0].Value.ToString();
                txtMaSach.ReadOnly = true;
                txtMaSach.BackColor = Color.LightGray; // Đặt màu nền thành xám           
                txtTenSach.Text = selectedRow.Cells[1].Value.ToString();
                txtNamXuatBan.Text = selectedRow.Cells[2].Value.ToString();
                txtNhaXuatBan.Text = selectedRow.Cells[3].Value.ToString();
                txtGiaNhap.Text = selectedRow.Cells[4].Value.ToString();
                txtGiaBan.Text = selectedRow.Cells[5].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells[6].Value.ToString();               
                HinhDaiDien.ImageLocation = selectedRow.Cells[7].Value.ToString();
                HinhDaiDien.BorderStyle = BorderStyle.None;
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một hàng trên bảng để xem chi tiết.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
                MessageBox.Show("Mã sách không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (danhSachSach.Any(sach => sach.MaSach == txtMaSach.Text))
            {
                MessageBox.Show("Mã sách trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (CheckTxt(txtNamXuatBan.Text, txtSoLuong.Text, txtGiaNhap.Text, txtGiaBan.Text))
                {
                    var sach = new Sach
                    {
                        MaSach = txtMaSach.Text,
                        TenSach = txtTenSach.Text,
                        NamXuatBan = int.Parse(txtNamXuatBan.Text),
                        NhaSanXuat = txtNhaXuatBan.Text,
                        GiaNhap = double.Parse(txtGiaNhap.Text),
                        GiaBan = double.Parse(txtGiaBan.Text),
                        SoLuongNhap = int.Parse(txtSoLuong.Text),
                        HinhDaiDien = HinhDaiDien.ImageLocation,
                    };
                    danhSachSach.Add(sach);

                    updateBinding();

                    offNenMasach();

                    MessageBox.Show("Da them thanh cong!", "Thong bao",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Lưu ý Năm xuất bản, giá nhập, giá bán \nvà số lượng không phải là chuỗi!!!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updateBinding()
        {
            sachBindingSource.ResetBindings(false); // Đảm bảo cập nhật dữ liệu
            sachBindingSource.DataSource = danhSachSach;
            File.WriteAllText(fileName, JsonConvert.SerializeObject(danhSachSach, Formatting.Indented));
        }
        void ClearForm()
        {
            txtMaSach.Clear(); txtTenSach.Clear();
            txtNamXuatBan.Clear(); txtNhaXuatBan.Clear();
            txtGiaNhap.Clear(); txtGiaBan.Clear();
            txtSoLuong.Clear(); HinhDaiDien.Image = null;
            HinhDaiDien.BorderStyle = BorderStyle.FixedSingle;
        }
        private void HinhDaiDien_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Chon anh dai dien",
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                HinhDaiDien.BorderStyle = BorderStyle.None;
                HinhDaiDien.ImageLocation = fileName;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Table.SelectedRows[0];
                Sach sachXoa = danhSachSach.FirstOrDefault(Sach => Sach.MaSach == selectedRow.Cells[0].Value.ToString());
                if (sachXoa != null)
                {
                    danhSachSach.Remove(sachXoa);
                    updateBinding();

                    MessageBox.Show($"Xóa thành công sách: {sachXoa.TenSach}", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trên bảng để xóa", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CheckTxt(String a, String b, String c, String d)
        {
            int n; double m;
            return int.TryParse(a, out n) && int.TryParse(b, out n) && double.TryParse(c, out m) && double.TryParse(d, out m);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                if (CheckTxt(txtNamXuatBan.Text, txtSoLuong.Text, txtGiaNhap.Text, txtGiaBan.Text))
                {
                    Sach sachCapNhat = danhSachSach.FirstOrDefault(Sach => Sach.MaSach == txtMaSach.Text);
                    danhSachSach.Remove(sachCapNhat);

                    sachCapNhat = new Sach
                    {
                        MaSach = txtMaSach.Text,
                        TenSach = txtTenSach.Text,
                        NamXuatBan = int.Parse(txtNamXuatBan.Text),
                        NhaSanXuat = txtNhaXuatBan.Text,
                        GiaNhap = double.Parse(txtGiaNhap.Text),
                        GiaBan = double.Parse(txtGiaBan.Text),
                        SoLuongNhap = int.Parse(txtSoLuong.Text),
                        HinhDaiDien = HinhDaiDien.ImageLocation,
                    };
                    danhSachSach.Add(sachCapNhat);
                    updateBinding();

                    offNenMasach();
                    MessageBox.Show("Cập nhật thành công", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Lưu ý Năm xuất bản, giá nhập, giá bán \nvà số lượng không phải là chuỗi!!!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng xem chi tiết sách để cập nhật", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private bool isFirstLoad = true;
        private void offNenMasach()
        {
            txtMaSach.ReadOnly = false;
            txtMaSach.BackColor = SystemColors.Window; // Đặt màu nền mặc định
            ClearForm();
        }
        private void QuanLySach_Click(object sender, EventArgs e)
        {
            if (isFirstLoad)
            {
                offNenMasach();
            }                             // 
        }
    }
}