using QuanLyDoBo.DTO;
using QuanLyDoBo.Model;
using System.Diagnostics;
using ImageMagick;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace QuanLyDoBo
{
    public partial class Form1 : Form
    {
        AllSQL SQL = new AllSQL();
        public Form1()
        {
            InitializeComponent();
            LoadKieuMauAndAllSanPham();
            dataGridViewSP.CellClick += new DataGridViewCellEventHandler(SelectRowSP);
            dataGridViewAnh.CellClick += new DataGridViewCellEventHandler(SelectRowAnh);
            dataGridViewSize.DataError += new DataGridViewDataErrorEventHandler(dataGridViewSize_DataError);

            dataGridViewSize.CellEndEdit += new DataGridViewCellEventHandler(dataGridViewAnh_EnterSoLuong);
              //     Debug.WriteLine($"Kiểu mẫu khác null KieuMau: {kieumau.idkieumau} và {kieumau.tenmau}");
        }
        // truyền giá trị vào 2 combobox
        void LoadKieuMauAndAllSanPham()
        {
            SanPhamDB db = new SanPhamDB();
            var ls = db.KieuMaus.Select(e => new KieuMauDTO
            {
                idkieumau = e.idkieumau,
                tenmau = e.tenmau,
                AmountKieuMau = e.SanPhams.Count()
            }).ToList();

            var tatCa = new KieuMauDTO { idkieumau = "0", tenmau = "Tất cả", AmountKieuMau = 0 };
            ls.Insert(0, tatCa);
            cbbKieuMau.DataSource = ls;
            cbbKieuMau.DisplayMember = "tenmau";
            cbbKieuMau.ValueMember = "idkieumau";
            var rong = new KieuMauDTO { idkieumau = "0", tenmau = "", AmountKieuMau = 0 };
            ls.RemoveAt(0);
            ls.Insert(0, rong);

            cbbidkieumau.DataSource = ls.ToList();
            cbbidkieumau.DisplayMember = "tenmau";
            cbbidkieumau.ValueMember = "idkieumau";
            // Đ
        }
        // load lại thong tin sản phẩm
        void loadSanPham()
        {
            var kieumau = cbbKieuMau.SelectedItem as KieuMauDTO;
            if (kieumau != null)
            {
                if (kieumau.idkieumau == "0")
                {
                    SanPhamDB db = new SanPhamDB();
                    var ls = db.SanPhams.Select(t => new SanPhamDTO
                    {
                        idsp = t.idsp,
                        masp = t.masp,
                        idkieumau = t.idkieumau,
                        anhdaidien = t.anhdaidien,
                        gia = t.gia,
                        hethang = t.hethang,
                        loaivai = t.loaivai,
                        namesp = t.namesp,
                        sale = t.sale
                    }).ToList();
                    sanPhamDTOBindingSource.DataSource = ls;
                    //     lbTongSoSinhVien.Text = ls.Count.ToString();
                }
                else
                {
                    Debug.WriteLine($"Kiểu mẫu khác KieuMau: {kieumau.idkieumau} và {kieumau.tenmau}");
                    SanPhamDB db = new SanPhamDB();
                    var ls = db.SanPhams.Where(t => t.idkieumau == kieumau.idkieumau)
                        .Select(t => new SanPhamDTO
                        {
                            idsp = t.idsp,
                            masp = t.masp,
                            idkieumau = t.idkieumau,
                            anhdaidien = t.anhdaidien,
                            gia = t.gia,
                            hethang = t.hethang,
                            loaivai = t.loaivai,
                            namesp = t.namesp,
                            sale = t.sale
                        }).ToList();
                    sanPhamDTOBindingSource.DataSource = ls;
                }
            }
        }

        // đăng ký sự kiện cho cbbKieuMau
        private void cbbKieuMau_SelectedIndexChanged(object sender, EventArgs e) { loadSanPham(); }

        private void SelectRowSP(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewSP.Rows.Count)
            {
                DataGridViewRow row = dataGridViewSP.Rows[rowIndex];
                SanPhamDTO sp = row.DataBoundItem as SanPhamDTO;
                txtmasp.Text = sp.masp;
                cbbidkieumau.SelectedValue = sp.idkieumau;
                txtgia.Text = sp.gia.ToString();
                txtnamesp.Text = sp.namesp; txtsale.Text = sp.sale.ToString();
                txtloaivai.Text = sp.loaivai;
                txtanhdaidien.Text = sp.anhdaidien;
                cbhethang.Checked = sp.hethang;
                SetImageSP(sp.anhdaidien);
                cbbidkieumau.BackColor = Color.FromArgb(224, 224, 224);
                cbbidkieumau.Enabled = false;
                LayDSAnh(txtmasp.Text);
                txtmasp2.Text = sp.masp;
            }
        }
        /// đẩy ảnh lên 
        private void SetImageSP(string path)
        {
            try
            {
                pictureBox1.BorderStyle = BorderStyle.None;
                pictureBox1.Image?.Dispose();
                using (MagickImage image = new MagickImage(path))
                {
                    var memoryStream = new MemoryStream();
                    image.Write(memoryStream, MagickFormat.Bmp);
                    memoryStream.Position = 0; // Reset the position of MemoryStream to the beginning
                    pictureBox1.Image = new System.Drawing.Bitmap(memoryStream);
                }
            }
            catch (Exception ex)
            {
                pictureBox1.Image = Image.FromFile("F:\\ImagesDoBo\\errorimg.jpg"); pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                MessageBox.Show("Ảnh không tồn tại hoặc sai đường dẫn!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // đọc ảnh từ file
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileName = openFileDialog.FileName;
                        txtanhdaidien.Text = fileName;
                        pictureBox1.BorderStyle = BorderStyle.None;
                        pictureBox1.Image?.Dispose();
                        using (MagickImage image = new MagickImage(fileName))
                        {
                            var memoryStream = new MemoryStream();
                            image.Write(memoryStream, MagickFormat.Bmp);
                            memoryStream.Position = 0; // Reset the position of MemoryStream to the beginning                   
                            pictureBox1.Image = new System.Drawing.Bitmap(memoryStream);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chỉ chọn file ảnh!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // reset form sp
        private void resetFormSP()
        {
            txtmasp.Text = string.Empty;
            cbbidkieumau.SelectedValue = "0";
            txtgia.Text = string.Empty;
            txtnamesp.Text = string.Empty;
            txtsale.Text = string.Empty;
            txtloaivai.Text = string.Empty;
            txtanhdaidien.Text = string.Empty;
            cbhethang.Checked = false;
            pictureBox1.Image = null;
            cbbidkieumau.BackColor = Color.FromArgb(255, 192, 192);
            cbbidkieumau.Enabled = true;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            resetFormAnh();
        }
        // nút reset form sp
        private void btnresetformsp_Click(object sender, EventArgs e) { resetFormSP(); }

        /// thêm 1 sanpham mới
        private void btnaddsp_Click(object sender, EventArgs e)
        {
            using (SanPhamDB db = new SanPhamDB())
            {
                if (db.SanPhams.Any(sp => sp.namesp == txtnamesp.Text)) { MessageBox.Show("Tên sản phẩm này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                if (SQL.InsertSP(((KieuMauDTO)cbbidkieumau.SelectedItem).idkieumau, int.Parse(txtgia.Text),
                    txtnamesp.Text, int.Parse(txtsale.Text), txtloaivai.Text, txtanhdaidien.Text))
                {

                    if (SQL.UpdateMaSP())
                    {
                        TaiLaiBangSP();
                        int lastRowIndex = dataGridViewSP.RowCount - 1;
                        dataGridViewSP.FirstDisplayedScrollingRowIndex = lastRowIndex;
                        dataGridViewSP.Rows[lastRowIndex].Selected = true;
                        MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm sản phẩm mới thành công nhưng lỗi mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thêm sản phẩm mới. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        // tải lại bảng sp theo cbbKieuMau hiẹn tại và reset formSP
        private void TaiLaiBangSP()
        {
            string a = (string)cbbKieuMau.SelectedValue;
            cbbKieuMau.SelectedItem = null;
            cbbKieuMau.SelectedValue = a;
            resetFormSP();
        }
        /// nút xóa sp
        private void btnxoasp_Click(object sender, EventArgs e)
        {
            string masp = txtmasp.Text;
            if (masp == "") MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult dialogResult = MessageBox.Show("Lưu ý nếu xóa sản phẩm này thì tất cả mã ảnh và" +
                    " mã size của nó sẽ bị xóa theo bạn, có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (SQL.DeleteSP(masp))
                    {
                        TaiLaiBangSP();
                        MessageBox.Show("Xóa thành công!.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Xóa không thành công!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// nut cap nhat san pham
        private void btnUpdateSP_Click(object sender, EventArgs e)
        {
            using (SanPhamDB db = new SanPhamDB())
            {
                if (SQL.UpdateSP(txtmasp.Text, int.Parse(txtgia.Text),
                    txtnamesp.Text, int.Parse(txtsale.Text), txtloaivai.Text, txtanhdaidien.Text))
                {
                    TaiLaiBangSP();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        ///====================================== Xử lý bảng ảnh======================================================================//
        private void LayDSAnh(string masp)
        {
            SanPhamDB db = new SanPhamDB();
            var ls = db.Anhs.Where(t => t.masp == masp)
                .Select(t => new AnhDTO
                {
                    idanh = t.idanh,
                    masp = masp,
                    mau = t.mau,
                    path = t.path,
                    maanh = t.maanh,
                    hethang = t.hethang,
                }).ToList();
            anhDTOBindingSource.DataSource = ls;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileName = openFileDialog.FileName;
                        txtpath.Text = fileName;
                        pictureBox2.BorderStyle = BorderStyle.None;
                        pictureBox2.Image?.Dispose();
                        using (MagickImage image = new MagickImage(fileName))
                        {
                            var memoryStream = new MemoryStream();
                            image.Write(memoryStream, MagickFormat.Bmp);
                            memoryStream.Position = 0;
                            pictureBox2.Image = new System.Drawing.Bitmap(memoryStream);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chỉ chọn file ảnh!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetImageAnh(string path)
        {
            try
            {
                pictureBox2.BorderStyle = BorderStyle.None;
                pictureBox2.Image?.Dispose();
                using (MagickImage image = new MagickImage(path))
                {
                    var memoryStream = new MemoryStream();
                    image.Write(memoryStream, MagickFormat.Bmp);
                    memoryStream.Position = 0; // Reset the position of MemoryStream to the beginning
                    pictureBox2.Image = new System.Drawing.Bitmap(memoryStream);
                }
            }
            catch (Exception ex)
            {
                pictureBox2.Image = Image.FromFile("F:\\ImagesDoBo\\errorimg.jpg"); pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                MessageBox.Show("Ảnh không tồn tại hoặc sai đường dẫn!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void SelectRowAnh(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewAnh.Rows.Count)
            {
                DataGridViewRow row = dataGridViewAnh.Rows[rowIndex];
                AnhDTO a = row.DataBoundItem as AnhDTO;
                txtmaanh.Text = a.maanh;
                txtmasp2.Text = a.masp;
                txtmau.Text = a.mau;
                txtpath.Text = a.path;
                cbhethang2.Checked = a.hethang;
                SetImageAnh(a.path);
                LayDSSize(txtmaanh.Text);
            }
        }
        private void resetFormAnh()
        {
            txtmaanh.Text = string.Empty;
            txtmau.Text = string.Empty;
            txtpath.Text = string.Empty;
            cbhethang2.Checked = false;
            pictureBox2.Image = null;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }
        private void btnresetformanh_Click(object sender, EventArgs e) { resetFormAnh(); }
        private void btnUpdateAnh_Click(object sender, EventArgs e)
        {
            using (SanPhamDB db = new SanPhamDB())
            {
                if (SQL.UpdateAnh(txtmaanh.Text, txtmau.Text, txtpath.Text))
                {
                    LayDSAnh(txtmasp.Text);
                    resetFormAnh();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddAnh_Click(object sender, EventArgs e)
        {
            using (SanPhamDB db = new SanPhamDB())
            {
                if (db.Anhs.Any(a => a.masp == txtmasp.Text && a.path == txtpath.Text)) { MessageBox.Show("Bạn đã thêm ảnh này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                if (SQL.InsertAnh(txtmasp.Text, txtmau.Text, txtpath.Text))
                {
                    if (SQL.UpdateMaAnh())
                    {
                        LayDSAnh(txtmasp.Text);
                        resetFormAnh();

                        int lastRowIndex = dataGridViewAnh.RowCount - 1;
                        dataGridViewAnh.FirstDisplayedScrollingRowIndex = lastRowIndex;
                        dataGridViewAnh.Rows[lastRowIndex].Selected = true;
                        AnhDTO a = dataGridViewAnh.Rows[lastRowIndex].DataBoundItem as AnhDTO;
                        SQL.InsertSize(a.maanh, a.masp, "S");
                        SQL.InsertSize(a.maanh, a.masp, "M");
                        SQL.InsertSize(a.maanh, a.masp, "L");
                        SQL.InsertSize(a.maanh, a.masp, "XL");
                        SQL.InsertSize(a.maanh, a.masp, "XXL");

                        MessageBox.Show("Thêm ảnh mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm ảnh mới thành công nhưng lỗi mã ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thêm ảnh mới. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeleteAnh_Click(object sender, EventArgs e)
        {
            if (txtmasp.Text == "") MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult dialogResult = MessageBox.Show("Lưu ý nếu xóa ảnh này thì toàn bộ thông tin size của ảnh" +
                    "cũng bị xóa theo, có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string maanh = txtmaanh.Text;
                    if (SQL.Delete5Size(maanh))
                    {
                        SQL.DeleteAnh(maanh);
                        LayDSAnh(txtmasp.Text);
                        resetFormAnh();
                        sizeDTOBindingSource.DataSource = null;
                        MessageBox.Show("Xóa thành công!.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Xóa không thành công!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //=============================================Xử lý bảng size=================================================
        private void LayDSSize(string maanh)
        {
            SanPhamDB db = new SanPhamDB();
            var ls = db.Sizes.Where(s => s.maanh == maanh)
                .Select(t => new SizeDTO
                {
                    idsize = t.idsize,
                    masize = t.masize,
                    maanh = t.maanh,
                    masp = t.masp,
                    size = t.size,
                    soluong = t.soluong
                }).ToList();
            sizeDTOBindingSource.DataSource = ls;
        }
         private bool hasError = false;
        private void dataGridViewSize_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Exception is FormatException)
            {
                LayDSSize(txtmaanh.Text);
                MessageBox.Show("Vui lòng nhập một số nguyên dương!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasError = true; // Đánh dấu rằng có lỗi xảy ra
                Debug.WriteLine($"Kiểu mẫu khác null KieuMau 1: {hasError}");
                e.ThrowException = false;
                LayDSSize(txtmaanh.Text);          
            }
        }
        private void dataGridViewAnh_EnterSoLuong(object sender, DataGridViewCellEventArgs e)
        {
            if (hasError)
            {
                Debug.WriteLine($"Kiểu mẫu khác null KieuMau2: {hasError} ");
                hasError = false;
                Debug.WriteLine($"Kiểu mẫu khác null KieuMau3: {hasError} ");
                return;
            }

            if (e.ColumnIndex == 1)
            {
                string maSize = dataGridViewSize.Rows[e.RowIndex].Cells[0].Value.ToString();
                int newQuantity = Convert.ToInt32(dataGridViewSize.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                if (newQuantity < 0)
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên dương!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LayDSSize(txtmaanh.Text);
                    return;
                }
                if (SQL.UpdateSoLuong(maSize, newQuantity))
                {
                    SanPhamDB db = new SanPhamDB();
                    string maanh = txtmaanh.Text;
                    string masp = txtmasp2.Text;
                    if (db.Sizes.Any(s => s.maanh == maanh && s.soluong > 0))
                    {
                        SQL.UpdateHetHangAnh(maanh, false);
                        LayDSAnh(txtmasp.Text);
                        if (db.SanPhams.Any(sp => sp.masp == masp && sp.hethang == true))
                        {
                            SQL.UpdateHetHangSP(masp, false);
                            string a = (string)cbbKieuMau.SelectedValue;
                            cbbKieuMau.SelectedItem = null;
                            cbbKieuMau.SelectedValue = a;
                            cbhethang.Checked = false;
                        }
                        cbhethang2.Checked = false;
                        MessageBox.Show("Cập nhật thành công!.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SQL.UpdateHetHangAnh(maanh, true);
                        LayDSAnh(txtmasp.Text);
                        if (!db.Anhs.Any(a => a.masp == masp && a.hethang == false))
                        {
                            SQL.UpdateHetHangSP(masp, true);
                            string a = (string)cbbKieuMau.SelectedValue;
                            cbbKieuMau.SelectedItem = null;
                            cbbKieuMau.SelectedValue = a;
                            cbhethang.Checked = true;
                        }
                        cbhethang2.Checked = true;
                        MessageBox.Show("Cập nhật thành công!.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}   
