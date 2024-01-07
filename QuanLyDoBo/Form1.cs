using QuanLyDoBo.DTO;
using QuanLyDoBo.Model;
using System.Diagnostics;
using ImageMagick;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Linq;

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

            var sapXepOptions = new List<string>
           {
              "", // Rỗng
              "Giá tiền cao thấp",
              "Giá tiền thấp cao",
              "Tên sản phẩm (a-z)",
              "Tên sản phẩm (z-a)",
              "Hết hàng",
              "Loại vải",
              "Kiểu mẫu",
              "Sale",

            };
            // Đặt dữ liệu cho ComboBox cbbsapxep
            cbbsapxep.DataSource = sapXepOptions;
            var loc = new List<string>
           {
              "",  "Size S","Size M", "Size L", "Size XL","Size XXL",
              "Đỏ","Cam","Vàng","Lục","Lam","Chàm","Trắng"
            };
            // Đặt dữ liệu cho ComboBox cbblọc
            cbbloc.DataSource = loc;
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
                    resetFormSP();
                    resetFormAnh();
                    txtmasp2.Text = "";
                    anhDTOBindingSource.DataSource = null;
                    sizeDTOBindingSource.DataSource = null;

                    //     lbTongSoSinhVien.Text = ls.Count.ToString();
                }
                else
                {
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
                    resetFormSP();
                    resetFormAnh();
                    txtmasp2.Text = "";
                    anhDTOBindingSource.DataSource = null;
                    sizeDTOBindingSource.DataSource = null;
                }
            }
        }

        // đăng ký sự kiện cho cbbKieuMau
        private void cbbKieuMau_SelectedIndexChanged(object sender, EventArgs e) { loadSanPham(); }
     
        private void cbbSapXel_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedSorting = cbbsapxep.SelectedItem.ToString();
            List<SanPhamDTO> currentList = sanPhamDTOBindingSource.DataSource as List<SanPhamDTO>;

            switch (selectedSorting)
            {
                case "":
                    string a = (string)cbbKieuMau.SelectedValue;
                    cbbKieuMau.SelectedItem = null;
                    cbbKieuMau.SelectedValue = a;
                    break;
                case "Giá tiền cao thấp":
                    currentList = currentList.OrderByDescending(sp => sp.gia).ToList();
                    break;
                case "Giá tiền thấp cao":
                    currentList = currentList.OrderBy(sp => sp.gia).ToList();
                    break;
                case "Hết hàng":
                    currentList = currentList.OrderBy(sp => sp.hethang).ThenBy(sp => sp.namesp).ToList();
                    break;
                case "Loại vải":
                    currentList = currentList.OrderBy(sp => sp.loaivai).ThenBy(sp => sp.namesp).ToList();
                    break;
                case "Kiểu mẫu":
                    currentList = currentList.OrderBy(sp => sp.idkieumau).ThenBy(sp => sp.namesp).ToList();
                    break;
                case "Sale":
                    currentList = currentList.OrderByDescending(sp => sp.sale).ToList();
                    break;
                case "Tên sản phẩm (a-z)":
                    currentList = currentList.OrderBy(sp => sp.namesp).ToList();
                    break;
                case "Tên sản phẩm (z-a)":
                    currentList = currentList.OrderByDescending(sp => sp.namesp).ToList();
                    break;
                default:
                    break;
            }
            sanPhamDTOBindingSource.DataSource = currentList;
        }

        private void cbbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = (string)cbbKieuMau.SelectedValue;
            cbbKieuMau.SelectedItem = null;
            cbbKieuMau.SelectedValue = a;
            var db = new SanPhamDB();
            string bien = cbbloc.SelectedItem.ToString();
            List<SanPhamDTO> currentList = sanPhamDTOBindingSource.DataSource as List<SanPhamDTO>;
            switch (bien)
            {
                case "":
                    string b = (string)cbbKieuMau.SelectedValue;
                    cbbKieuMau.SelectedItem = null;
                    cbbKieuMau.SelectedValue = b;
                    break;
                case "Size S":
                    currentList = currentList.Where(sp =>
                    db.Sizes.Any(s => s.masp == sp.masp && s.soluong > 0 && s.size == "S"))
                   .ToList();
                    break;
                case "Size M":
                    currentList = currentList.Where(sp =>
                    db.Sizes.Any(s => s.masp == sp.masp && s.soluong > 0 && s.size == "M"))
                   .ToList();
                    break;
                case "Size L":
                    currentList = currentList.Where(sp =>
                    db.Sizes.Any(s => s.masp == sp.masp && s.soluong > 0 && s.size == "L"))
                   .ToList();
                    break;
                case "Cam":
                    currentList = currentList.Where(sp =>
                    db.Anhs.Any(a => a.mau.ToLower().Contains("cam") && a.masp == sp.masp && a.hethang == false) ||
                    db.Anhs.Any(a => a.mau.ToLower().Contains("Cam") && a.masp == sp.masp && a.hethang == false))
                   .ToList();
                    break;
                case "Đỏ":
                    currentList = currentList.Where(sp =>
                    db.Anhs.Any(a => a.mau.ToLower().Contains("đỏ") && a.masp == sp.masp && a.hethang == false) ||
                    db.Anhs.Any(a => a.mau.ToLower().Contains("Đỏ") && a.masp == sp.masp && a.hethang == false))
                   .ToList();
                    break;
                case "Vàng":
                    currentList = currentList.Where(sp =>
                    db.Anhs.Any(a => a.mau.ToLower().Contains("vàng") && a.masp == sp.masp && a.hethang == false)||
                    db.Anhs.Any(a => a.mau.ToLower().Contains("Vàng") && a.masp == sp.masp && a.hethang == false)                  
                    )
                   .ToList();
                    break;
                default:
                    break;
            }
            sanPhamDTOBindingSource.DataSource = currentList;
        }
        // ================================================ xử lý bảng sản phẩm ================================
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
                sizeDTOBindingSource.DataSource = null;
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

        private void dataGridViewAnh_EnterSoLuong(object sender, DataGridViewCellEventArgs e)
        {
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

        private void txtSearch(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                var tuKhoa = txtsearch.Text.ToLower();
                var keywords = tuKhoa.Split(' ');

                Debug.WriteLine($"Xuất từ khóa: {tuKhoa}");
                using (var db = new SanPhamDB())
                {
                    var ls = db.SanPhams
                        .Where(sp => sp.hethang == false &&
                        (
                        //tìm kiếm cơ bản 
                          db.Sizes.Any(s => s.size.ToLower().Contains(tuKhoa) && sp.masp == s.masp && s.soluong > 0)

                      || sp.idkieumau.ToLower().Contains(tuKhoa) //tìm theo idkieumau
                      || db.KieuMaus.Any(km => km.tenmau.ToLower().Contains(tuKhoa) && km.idkieumau == sp.idkieumau) //tìm theo tên kiểu mẫu
                      || sp.loaivai.ToLower().Contains(tuKhoa)  // tìm theo loại vải

                      || db.Anhs.Any(a => a.mau.ToLower().Contains(tuKhoa) && a.masp == sp.masp && a.hethang == false) // tìm kiém theo màu còn hàng

                      // tìm kiếm phối hơp trong bảng Sản Phẩm - tìm kiếm theo idkieumau và loai vai
                      || (tuKhoa.Contains(sp.idkieumau.ToLower())
                         && tuKhoa.Contains(sp.loaivai.ToLower()))
                      || (db.KieuMaus.Any(km => tuKhoa.Contains(km.tenmau.ToLower()) && km.idkieumau == sp.idkieumau) //tìm kiếm theo kieumau và loai vai
                         && tuKhoa.Contains(sp.loaivai.ToLower()) && !db.Anhs.Any(a => tuKhoa.Contains(a.mau.ToLower()) && a.masp == sp.masp && a.hethang == false)
                         )

                      // tìm kiếm phối hơp trong bảng Sản Phẩm và bảng Ảnh
                      || (db.Anhs.Any(a => tuKhoa.Contains(a.mau.ToLower()) && a.masp == sp.masp && a.hethang == false)
                         && db.KieuMaus.Any(km => tuKhoa.Contains(km.tenmau.ToLower()) && km.idkieumau == sp.idkieumau) //tìm kiếm theo kieumau và loai vai và màu
                         && tuKhoa.Contains(sp.loaivai.ToLower()))
                      || (db.Anhs.Any(a => tuKhoa.Contains(a.mau.ToLower()) && a.masp == sp.masp && a.hethang == false)
                         && db.KieuMaus.Any(km => tuKhoa.Contains(km.tenmau.ToLower()) && km.idkieumau == sp.idkieumau)) //tìm kiếm theo kieumau và màu
                      || (db.Anhs.Any(a => tuKhoa.Contains(a.mau.ToLower()) && a.masp == sp.masp && a.hethang == false)
                         && tuKhoa.Contains(sp.loaivai.ToLower()))                                                      //tìm kiếm theo loai vai và màu
                      || db.Anhs.Any(a => tuKhoa.Contains(a.mau.ToLower()) && a.masp == sp.masp && a.hethang == false)

                      )
                      )
                        .Select(sp => new SanPhamDTO
                        {
                            idsp = sp.idsp,
                            masp = sp.masp,
                            idkieumau = sp.idkieumau,
                            namesp = sp.namesp,
                            hethang = sp.hethang,
                            gia = sp.gia,
                            sale = sp.sale,
                            loaivai = sp.loaivai,
                            anhdaidien = sp.anhdaidien

                        }).ToList();
                    Debug.WriteLine($"Kiểu mẫu khác 3: {ls}");
                    sanPhamDTOBindingSource.DataSource = null;
                    sanPhamDTOBindingSource.DataSource = ls;
                    resetFormSP();
                    resetFormAnh();
                    txtmasp2.Text = "";
                    anhDTOBindingSource.DataSource = null;
                    sizeDTOBindingSource.DataSource = null;
                }

            }
        }

        
    }
}
//Debug.WriteLine($"Kiểu mẫu khác null KieuMau: {kieumau.idkieumau} và {kieumau.tenmau}");