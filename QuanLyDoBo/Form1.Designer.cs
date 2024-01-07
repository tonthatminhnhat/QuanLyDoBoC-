namespace QuanLyDoBo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridViewSP = new DataGridView();
            maspDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namespDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idkieumauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hethangDataGridViewTextBoxColumn = new DataGridViewCheckBoxColumn();
            loaivaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anhdaidienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sanPhamDTOBindingSource = new BindingSource(components);
            cbbKieuMau = new ComboBox();
            dataGridViewAnh = new DataGridView();
            maanhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maspDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            mauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hethangDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            anhDTOBindingSource = new BindingSource(components);
            dataGridViewSize = new DataGridView();
            masizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soluongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maanhDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maspDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            sizeDTOBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbhethang = new CheckBox();
            txtmasp = new TextBox();
            cbbidkieumau = new ComboBox();
            txtsale = new TextBox();
            txtgia = new TextBox();
            txtnamesp = new TextBox();
            txtanhdaidien = new TextBox();
            btnresetformsp = new Button();
            btnaddsp = new Button();
            btnUpdateSP = new Button();
            btnxoasp = new Button();
            pictureBox1 = new PictureBox();
            txtloaivai = new TextBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            txtmau = new TextBox();
            txtmaanh = new TextBox();
            label11 = new Label();
            label12 = new Label();
            cbhethang2 = new CheckBox();
            label13 = new Label();
            txtmasp2 = new TextBox();
            label14 = new Label();
            txtpath = new TextBox();
            label15 = new Label();
            btnDeleteAnh = new Button();
            btnUpdateAnh = new Button();
            btnAddAnh = new Button();
            btnresetformanh = new Button();
            label17 = new Label();
            txtsearch = new TextBox();
            label16 = new Label();
            cbbsapxep = new ComboBox();
            label18 = new Label();
            cbbloc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)anhDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSP
            // 
            dataGridViewSP.AllowUserToAddRows = false;
            dataGridViewSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSP.AutoGenerateColumns = false;
            dataGridViewSP.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSP.Columns.AddRange(new DataGridViewColumn[] { maspDataGridViewTextBoxColumn, namespDataGridViewTextBoxColumn, idkieumauDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, saleDataGridViewTextBoxColumn, hethangDataGridViewTextBoxColumn, loaivaiDataGridViewTextBoxColumn, anhdaidienDataGridViewTextBoxColumn });
            dataGridViewSP.DataSource = sanPhamDTOBindingSource;
            dataGridViewSP.Location = new Point(12, 350);
            dataGridViewSP.Name = "dataGridViewSP";
            dataGridViewSP.ReadOnly = true;
            dataGridViewSP.RowHeadersVisible = false;
            dataGridViewSP.RowHeadersWidth = 51;
            dataGridViewSP.RowTemplate.Height = 29;
            dataGridViewSP.Size = new Size(1278, 693);
            dataGridViewSP.TabIndex = 0;
            dataGridViewSP.CellClick += SelectRowSP;
            // 
            // maspDataGridViewTextBoxColumn
            // 
            maspDataGridViewTextBoxColumn.DataPropertyName = "masp";
            maspDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            maspDataGridViewTextBoxColumn.MinimumWidth = 6;
            maspDataGridViewTextBoxColumn.Name = "maspDataGridViewTextBoxColumn";
            maspDataGridViewTextBoxColumn.ReadOnly = true;
            maspDataGridViewTextBoxColumn.Width = 79;
            // 
            // namespDataGridViewTextBoxColumn
            // 
            namespDataGridViewTextBoxColumn.DataPropertyName = "namesp";
            namespDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            namespDataGridViewTextBoxColumn.MinimumWidth = 6;
            namespDataGridViewTextBoxColumn.Name = "namespDataGridViewTextBoxColumn";
            namespDataGridViewTextBoxColumn.ReadOnly = true;
            namespDataGridViewTextBoxColumn.Width = 300;
            // 
            // idkieumauDataGridViewTextBoxColumn
            // 
            idkieumauDataGridViewTextBoxColumn.DataPropertyName = "idkieumau";
            idkieumauDataGridViewTextBoxColumn.HeaderText = "Mã kiểu mẫu";
            idkieumauDataGridViewTextBoxColumn.MinimumWidth = 6;
            idkieumauDataGridViewTextBoxColumn.Name = "idkieumauDataGridViewTextBoxColumn";
            idkieumauDataGridViewTextBoxColumn.ReadOnly = true;
            idkieumauDataGridViewTextBoxColumn.Width = 123;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            giaDataGridViewTextBoxColumn.ReadOnly = true;
            giaDataGridViewTextBoxColumn.Width = 90;
            // 
            // saleDataGridViewTextBoxColumn
            // 
            saleDataGridViewTextBoxColumn.DataPropertyName = "sale";
            saleDataGridViewTextBoxColumn.HeaderText = "Sale";
            saleDataGridViewTextBoxColumn.MinimumWidth = 6;
            saleDataGridViewTextBoxColumn.Name = "saleDataGridViewTextBoxColumn";
            saleDataGridViewTextBoxColumn.ReadOnly = true;
            saleDataGridViewTextBoxColumn.Width = 50;
            // 
            // hethangDataGridViewTextBoxColumn
            // 
            hethangDataGridViewTextBoxColumn.DataPropertyName = "hethang";
            hethangDataGridViewTextBoxColumn.HeaderText = "Hết hàng";
            hethangDataGridViewTextBoxColumn.MinimumWidth = 6;
            hethangDataGridViewTextBoxColumn.Name = "hethangDataGridViewTextBoxColumn";
            hethangDataGridViewTextBoxColumn.ReadOnly = true;
            hethangDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            hethangDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            hethangDataGridViewTextBoxColumn.Width = 97;
            // 
            // loaivaiDataGridViewTextBoxColumn
            // 
            loaivaiDataGridViewTextBoxColumn.DataPropertyName = "loaivai";
            loaivaiDataGridViewTextBoxColumn.HeaderText = "Loại Vải";
            loaivaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            loaivaiDataGridViewTextBoxColumn.Name = "loaivaiDataGridViewTextBoxColumn";
            loaivaiDataGridViewTextBoxColumn.ReadOnly = true;
            loaivaiDataGridViewTextBoxColumn.Width = 130;
            // 
            // anhdaidienDataGridViewTextBoxColumn
            // 
            anhdaidienDataGridViewTextBoxColumn.DataPropertyName = "anhdaidien";
            anhdaidienDataGridViewTextBoxColumn.HeaderText = "Ảnh đại diện";
            anhdaidienDataGridViewTextBoxColumn.MinimumWidth = 6;
            anhdaidienDataGridViewTextBoxColumn.Name = "anhdaidienDataGridViewTextBoxColumn";
            anhdaidienDataGridViewTextBoxColumn.ReadOnly = true;
            anhdaidienDataGridViewTextBoxColumn.Width = 330;
            // 
            // sanPhamDTOBindingSource
            // 
            sanPhamDTOBindingSource.DataSource = typeof(DTO.SanPhamDTO);
            // 
            // cbbKieuMau
            // 
            cbbKieuMau.FormattingEnabled = true;
            cbbKieuMau.Location = new Point(92, 73);
            cbbKieuMau.Name = "cbbKieuMau";
            cbbKieuMau.Size = new Size(103, 28);
            cbbKieuMau.TabIndex = 1;
            cbbKieuMau.SelectedIndexChanged += cbbKieuMau_SelectedIndexChanged;
            // 
            // dataGridViewAnh
            // 
            dataGridViewAnh.AllowUserToAddRows = false;
            dataGridViewAnh.AllowUserToDeleteRows = false;
            dataGridViewAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridViewAnh.AutoGenerateColumns = false;
            dataGridViewAnh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnh.Columns.AddRange(new DataGridViewColumn[] { maanhDataGridViewTextBoxColumn, maspDataGridViewTextBoxColumn1, mauDataGridViewTextBoxColumn, pathDataGridViewTextBoxColumn, hethangDataGridViewCheckBoxColumn });
            dataGridViewAnh.DataSource = anhDTOBindingSource;
            dataGridViewAnh.Location = new Point(1308, 522);
            dataGridViewAnh.Name = "dataGridViewAnh";
            dataGridViewAnh.ReadOnly = true;
            dataGridViewAnh.RowHeadersVisible = false;
            dataGridViewAnh.RowHeadersWidth = 51;
            dataGridViewAnh.RowTemplate.Height = 29;
            dataGridViewAnh.Size = new Size(604, 265);
            dataGridViewAnh.TabIndex = 2;
            // 
            // maanhDataGridViewTextBoxColumn
            // 
            maanhDataGridViewTextBoxColumn.DataPropertyName = "maanh";
            maanhDataGridViewTextBoxColumn.HeaderText = "maanh";
            maanhDataGridViewTextBoxColumn.MinimumWidth = 6;
            maanhDataGridViewTextBoxColumn.Name = "maanhDataGridViewTextBoxColumn";
            maanhDataGridViewTextBoxColumn.ReadOnly = true;
            maanhDataGridViewTextBoxColumn.Width = 125;
            // 
            // maspDataGridViewTextBoxColumn1
            // 
            maspDataGridViewTextBoxColumn1.DataPropertyName = "masp";
            maspDataGridViewTextBoxColumn1.HeaderText = "masp";
            maspDataGridViewTextBoxColumn1.MinimumWidth = 6;
            maspDataGridViewTextBoxColumn1.Name = "maspDataGridViewTextBoxColumn1";
            maspDataGridViewTextBoxColumn1.ReadOnly = true;
            maspDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mauDataGridViewTextBoxColumn
            // 
            mauDataGridViewTextBoxColumn.DataPropertyName = "mau";
            mauDataGridViewTextBoxColumn.HeaderText = "mau";
            mauDataGridViewTextBoxColumn.MinimumWidth = 6;
            mauDataGridViewTextBoxColumn.Name = "mauDataGridViewTextBoxColumn";
            mauDataGridViewTextBoxColumn.ReadOnly = true;
            mauDataGridViewTextBoxColumn.Width = 125;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.DataPropertyName = "path";
            pathDataGridViewTextBoxColumn.HeaderText = "path";
            pathDataGridViewTextBoxColumn.MinimumWidth = 6;
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            pathDataGridViewTextBoxColumn.ReadOnly = true;
            pathDataGridViewTextBoxColumn.Width = 125;
            // 
            // hethangDataGridViewCheckBoxColumn
            // 
            hethangDataGridViewCheckBoxColumn.DataPropertyName = "hethang";
            hethangDataGridViewCheckBoxColumn.HeaderText = "hethang";
            hethangDataGridViewCheckBoxColumn.MinimumWidth = 6;
            hethangDataGridViewCheckBoxColumn.Name = "hethangDataGridViewCheckBoxColumn";
            hethangDataGridViewCheckBoxColumn.ReadOnly = true;
            hethangDataGridViewCheckBoxColumn.Width = 125;
            // 
            // anhDTOBindingSource
            // 
            anhDTOBindingSource.DataSource = typeof(DTO.AnhDTO);
            // 
            // dataGridViewSize
            // 
            dataGridViewSize.AllowUserToAddRows = false;
            dataGridViewSize.AllowUserToDeleteRows = false;
            dataGridViewSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewSize.AutoGenerateColumns = false;
            dataGridViewSize.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSize.Columns.AddRange(new DataGridViewColumn[] { masizeDataGridViewTextBoxColumn, soluongDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, maanhDataGridViewTextBoxColumn1, maspDataGridViewTextBoxColumn2 });
            dataGridViewSize.DataSource = sizeDTOBindingSource;
            dataGridViewSize.Location = new Point(1308, 866);
            dataGridViewSize.Name = "dataGridViewSize";
            dataGridViewSize.RowHeadersVisible = false;
            dataGridViewSize.RowHeadersWidth = 51;
            dataGridViewSize.RowTemplate.Height = 29;
            dataGridViewSize.Size = new Size(604, 177);
            dataGridViewSize.TabIndex = 3;
            // 
            // masizeDataGridViewTextBoxColumn
            // 
            masizeDataGridViewTextBoxColumn.DataPropertyName = "masize";
            masizeDataGridViewTextBoxColumn.HeaderText = "Mã size";
            masizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            masizeDataGridViewTextBoxColumn.Name = "masizeDataGridViewTextBoxColumn";
            masizeDataGridViewTextBoxColumn.ReadOnly = true;
            masizeDataGridViewTextBoxColumn.Width = 140;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            soluongDataGridViewTextBoxColumn.Width = 110;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            sizeDataGridViewTextBoxColumn.ReadOnly = true;
            sizeDataGridViewTextBoxColumn.Width = 80;
            // 
            // maanhDataGridViewTextBoxColumn1
            // 
            maanhDataGridViewTextBoxColumn1.DataPropertyName = "maanh";
            maanhDataGridViewTextBoxColumn1.HeaderText = "Mã ảnh";
            maanhDataGridViewTextBoxColumn1.MinimumWidth = 6;
            maanhDataGridViewTextBoxColumn1.Name = "maanhDataGridViewTextBoxColumn1";
            maanhDataGridViewTextBoxColumn1.ReadOnly = true;
            maanhDataGridViewTextBoxColumn1.Width = 130;
            // 
            // maspDataGridViewTextBoxColumn2
            // 
            maspDataGridViewTextBoxColumn2.DataPropertyName = "masp";
            maspDataGridViewTextBoxColumn2.HeaderText = "Mã SP";
            maspDataGridViewTextBoxColumn2.MinimumWidth = 6;
            maspDataGridViewTextBoxColumn2.Name = "maspDataGridViewTextBoxColumn2";
            maspDataGridViewTextBoxColumn2.ReadOnly = true;
            maspDataGridViewTextBoxColumn2.Width = 141;
            // 
            // sizeDTOBindingSource
            // 
            sizeDTOBindingSource.DataSource = typeof(DTO.SizeDTO);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "Kiểu mẫu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(165, 31);
            label2.TabIndex = 5;
            label2.Text = "Quản lý đồ bộ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 210);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "Mã sản phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 237);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "Tên sản phẩm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 211);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "Mã kiểu mẫu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 211);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 9;
            label6.Text = "Giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 212);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 10;
            label7.Text = "Sale:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(654, 276);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 11;
            label8.Text = "Hết hàng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 261);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 12;
            label9.Text = "Ảnh đại diện";
            // 
            // cbhethang
            // 
            cbhethang.AutoSize = true;
            cbhethang.BackColor = Color.FromArgb(224, 224, 224);
            cbhethang.Enabled = false;
            cbhethang.Location = new Point(733, 283);
            cbhethang.Name = "cbhethang";
            cbhethang.Size = new Size(18, 17);
            cbhethang.TabIndex = 13;
            cbhethang.UseVisualStyleBackColor = false;
            // 
            // txtmasp
            // 
            txtmasp.BackColor = Color.FromArgb(224, 224, 224);
            txtmasp.Location = new Point(119, 210);
            txtmasp.Name = "txtmasp";
            txtmasp.ReadOnly = true;
            txtmasp.Size = new Size(58, 27);
            txtmasp.TabIndex = 14;
            // 
            // cbbidkieumau
            // 
            cbbidkieumau.BackColor = Color.FromArgb(255, 192, 192);
            cbbidkieumau.FormattingEnabled = true;
            cbbidkieumau.Location = new Point(286, 209);
            cbbidkieumau.Name = "cbbidkieumau";
            cbbidkieumau.Size = new Size(113, 28);
            cbbidkieumau.TabIndex = 15;
            // 
            // txtsale
            // 
            txtsale.Location = new Point(547, 209);
            txtsale.Name = "txtsale";
            txtsale.Size = new Size(32, 27);
            txtsale.TabIndex = 16;
            // 
            // txtgia
            // 
            txtgia.Location = new Point(445, 210);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(71, 27);
            txtgia.TabIndex = 17;
            // 
            // txtnamesp
            // 
            txtnamesp.Location = new Point(119, 240);
            txtnamesp.Name = "txtnamesp";
            txtnamesp.Size = new Size(632, 27);
            txtnamesp.TabIndex = 18;
            // 
            // txtanhdaidien
            // 
            txtanhdaidien.Location = new Point(119, 273);
            txtanhdaidien.Name = "txtanhdaidien";
            txtanhdaidien.Size = new Size(529, 27);
            txtanhdaidien.TabIndex = 19;
            // 
            // btnresetformsp
            // 
            btnresetformsp.Location = new Point(12, 306);
            btnresetformsp.Name = "btnresetformsp";
            btnresetformsp.Size = new Size(128, 29);
            btnresetformsp.TabIndex = 21;
            btnresetformsp.Text = "ResetForm";
            btnresetformsp.UseVisualStyleBackColor = true;
            btnresetformsp.Click += btnresetformsp_Click;
            // 
            // btnaddsp
            // 
            btnaddsp.Location = new Point(143, 308);
            btnaddsp.Name = "btnaddsp";
            btnaddsp.Size = new Size(143, 29);
            btnaddsp.TabIndex = 22;
            btnaddsp.Text = "Thêm sản phẩm";
            btnaddsp.UseVisualStyleBackColor = true;
            btnaddsp.Click += btnaddsp_Click;
            // 
            // btnUpdateSP
            // 
            btnUpdateSP.Location = new Point(292, 308);
            btnUpdateSP.Name = "btnUpdateSP";
            btnUpdateSP.Size = new Size(153, 29);
            btnUpdateSP.TabIndex = 23;
            btnUpdateSP.Text = "Cập nhật sản phẩm";
            btnUpdateSP.UseVisualStyleBackColor = true;
            btnUpdateSP.Click += btnUpdateSP_Click;
            // 
            // btnxoasp
            // 
            btnxoasp.Location = new Point(474, 307);
            btnxoasp.Name = "btnxoasp";
            btnxoasp.Size = new Size(128, 29);
            btnxoasp.TabIndex = 24;
            btnxoasp.Text = "Xóa sản phẩm";
            btnxoasp.UseVisualStyleBackColor = true;
            btnxoasp.Click += btnxoasp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(780, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtloaivai
            // 
            txtloaivai.Location = new Point(654, 207);
            txtloaivai.Name = "txtloaivai";
            txtloaivai.Size = new Size(97, 27);
            txtloaivai.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(585, 210);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 26;
            label10.Text = "Loại vải:";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Location = new Point(1774, 288);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 186);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtmau
            // 
            txtmau.Location = new Point(1354, 397);
            txtmau.Name = "txtmau";
            txtmau.Size = new Size(395, 27);
            txtmau.TabIndex = 32;
            // 
            // txtmaanh
            // 
            txtmaanh.BackColor = Color.FromArgb(224, 224, 224);
            txtmaanh.Location = new Point(1375, 351);
            txtmaanh.Name = "txtmaanh";
            txtmaanh.ReadOnly = true;
            txtmaanh.Size = new Size(73, 27);
            txtmaanh.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1308, 400);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 30;
            label11.Text = "Màu:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1308, 354);
            label12.Name = "label12";
            label12.Size = new Size(61, 20);
            label12.TabIndex = 29;
            label12.Text = "Mã ảnh:";
            // 
            // cbhethang2
            // 
            cbhethang2.AutoSize = true;
            cbhethang2.BackColor = Color.FromArgb(224, 224, 224);
            cbhethang2.Enabled = false;
            cbhethang2.Location = new Point(1715, 357);
            cbhethang2.Name = "cbhethang2";
            cbhethang2.Size = new Size(18, 17);
            cbhethang2.TabIndex = 34;
            cbhethang2.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1636, 357);
            label13.Name = "label13";
            label13.Size = new Size(73, 20);
            label13.TabIndex = 33;
            label13.Text = "Hết hàng:";
            // 
            // txtmasp2
            // 
            txtmasp2.BackColor = Color.FromArgb(224, 224, 224);
            txtmasp2.Location = new Point(1572, 350);
            txtmasp2.Multiline = true;
            txtmasp2.Name = "txtmasp2";
            txtmasp2.ReadOnly = true;
            txtmasp2.Size = new Size(58, 27);
            txtmasp2.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1465, 354);
            label14.Name = "label14";
            label14.Size = new Size(101, 20);
            label14.TabIndex = 35;
            label14.Text = "Mã sản phẩm:";
            // 
            // txtpath
            // 
            txtpath.Location = new Point(1354, 447);
            txtpath.Name = "txtpath";
            txtpath.Size = new Size(395, 27);
            txtpath.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1308, 450);
            label15.Name = "label15";
            label15.Size = new Size(40, 20);
            label15.TabIndex = 37;
            label15.Text = "Path:";
            // 
            // btnDeleteAnh
            // 
            btnDeleteAnh.Location = new Point(1665, 486);
            btnDeleteAnh.Name = "btnDeleteAnh";
            btnDeleteAnh.Size = new Size(113, 29);
            btnDeleteAnh.TabIndex = 42;
            btnDeleteAnh.Text = "Xóa ảnh";
            btnDeleteAnh.UseVisualStyleBackColor = true;
            btnDeleteAnh.Click += btnDeleteAnh_Click;
            // 
            // btnUpdateAnh
            // 
            btnUpdateAnh.Location = new Point(1546, 486);
            btnUpdateAnh.Name = "btnUpdateAnh";
            btnUpdateAnh.Size = new Size(113, 29);
            btnUpdateAnh.TabIndex = 41;
            btnUpdateAnh.Text = "Cập nhật ảnh";
            btnUpdateAnh.UseVisualStyleBackColor = true;
            btnUpdateAnh.Click += btnUpdateAnh_Click;
            // 
            // btnAddAnh
            // 
            btnAddAnh.Location = new Point(1427, 487);
            btnAddAnh.Name = "btnAddAnh";
            btnAddAnh.Size = new Size(113, 29);
            btnAddAnh.TabIndex = 40;
            btnAddAnh.Text = "Thêm ảnh";
            btnAddAnh.UseVisualStyleBackColor = true;
            btnAddAnh.Click += btnAddAnh_Click;
            // 
            // btnresetformanh
            // 
            btnresetformanh.Location = new Point(1308, 487);
            btnresetformanh.Name = "btnresetformanh";
            btnresetformanh.Size = new Size(113, 29);
            btnresetformanh.TabIndex = 39;
            btnresetformanh.Text = "ResetForm";
            btnresetformanh.UseVisualStyleBackColor = true;
            btnresetformanh.Click += btnresetformanh_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(257, 73);
            label17.Name = "label17";
            label17.Size = new Size(70, 20);
            label17.TabIndex = 47;
            label17.Text = "Tìm kiếm";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(356, 76);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(211, 27);
            txtsearch.TabIndex = 48;
            txtsearch.KeyPress += txtSearch;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(727, 76);
            label16.Name = "label16";
            label16.Size = new Size(65, 20);
            label16.TabIndex = 50;
            label16.Text = "Sắp xếp:";
            // 
            // cbbsapxep
            // 
            cbbsapxep.FormattingEnabled = true;
            cbbsapxep.Location = new Point(798, 73);
            cbbsapxep.Name = "cbbsapxep";
            cbbsapxep.Size = new Size(151, 28);
            cbbsapxep.TabIndex = 51;
            cbbsapxep.SelectedIndexChanged += cbbSapXel_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(757, 119);
            label18.Name = "label18";
            label18.Size = new Size(35, 20);
            label18.TabIndex = 52;
            label18.Text = "Lọc:";
            // 
            // cbbloc
            // 
            cbbloc.FormattingEnabled = true;
            cbbloc.Location = new Point(798, 116);
            cbbloc.Name = "cbbloc";
            cbbloc.Size = new Size(151, 28);
            cbbloc.TabIndex = 53;
            cbbloc.SelectedIndexChanged += cbbLoc_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1924, 1055);
            Controls.Add(cbbloc);
            Controls.Add(label18);
            Controls.Add(cbbsapxep);
            Controls.Add(label16);
            Controls.Add(txtsearch);
            Controls.Add(label17);
            Controls.Add(btnDeleteAnh);
            Controls.Add(btnUpdateAnh);
            Controls.Add(btnAddAnh);
            Controls.Add(btnresetformanh);
            Controls.Add(txtpath);
            Controls.Add(label15);
            Controls.Add(txtmasp2);
            Controls.Add(label14);
            Controls.Add(cbhethang2);
            Controls.Add(label13);
            Controls.Add(txtmau);
            Controls.Add(txtmaanh);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(pictureBox2);
            Controls.Add(txtloaivai);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(btnxoasp);
            Controls.Add(btnUpdateSP);
            Controls.Add(btnaddsp);
            Controls.Add(btnresetformsp);
            Controls.Add(txtanhdaidien);
            Controls.Add(txtnamesp);
            Controls.Add(txtgia);
            Controls.Add(txtsale);
            Controls.Add(cbbidkieumau);
            Controls.Add(txtmasp);
            Controls.Add(cbhethang);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewSize);
            Controls.Add(dataGridViewAnh);
            Controls.Add(cbbKieuMau);
            Controls.Add(dataGridViewSP);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            KeyPress += txtSearch;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)anhDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSP;
        private ComboBox cbbKieuMau;
        private BindingSource sanPhamDTOBindingSource;
        private DataGridView dataGridViewAnh;
        private DataGridView dataGridViewSize;
        private BindingSource sizeDTOBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox cbhethang;
        private TextBox txtmasp;
        private ComboBox cbbidkieumau;
        private TextBox txtsale;
        private TextBox txtgia;
        private TextBox txtnamesp;
        private TextBox txtanhdaidien;
        private Button btnresetformsp;
        private Button btnaddsp;
        private Button btnUpdateSP;
        private Button btnxoasp;
        private PictureBox pictureBox1;
        private TextBox txtloaivai;
        private Label label10;
        private PictureBox pictureBox2;
        private TextBox txtmau;
        private TextBox txtmaanh;
        private Label label11;
        private Label label12;
        private CheckBox cbhethang2;
        private Label label13;
        private TextBox txtmasp2;
        private Label label14;
        private TextBox txtpath;
        private Label label15;
        private BindingSource anhDTOBindingSource;
        private Button btnDeleteAnh;
        private Button btnUpdateAnh;
        private Button btnAddAnh;
        private Button btnresetformanh;
        private DataGridViewTextBoxColumn maspDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namespDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idkieumauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hethangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaivaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anhdaidienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maanhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maspDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn mauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hethangDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn masizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maanhDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maspDataGridViewTextBoxColumn2;
        private Label label17;
        private TextBox txtsearch;
        private Label label16;
        private ComboBox cbbsapxep;
        private Label label18;
        private ComboBox cbbloc;
    }
}