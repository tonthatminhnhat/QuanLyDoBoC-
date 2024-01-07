namespace EFCoreTutorial
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cbbLop = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            studentNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dDBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pOBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentDTOBindingSource = new BindingSource(components);
            panel1 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lbTongSoSinhVien = new ToolStripStatusLabel();
            toolStrip2 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btcThem = new ToolStripButton();
            btnSua = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            txttiemkiem = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // cbbLop
            // 
            cbbLop.FormattingEnabled = true;
            cbbLop.Location = new Point(153, 94);
            cbbLop.Name = "cbbLop";
            cbbLop.Size = new Size(191, 28);
            cbbLop.TabIndex = 0;
            cbbLop.SelectedIndexChanged += cbbLop_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 1;
            label1.Text = "Quản lý lớp học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 97);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Lớp học:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentNumberDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, dDBDataGridViewTextBoxColumn, pOBDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(795, 200);
            dataGridView1.TabIndex = 3;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            studentNumberDataGridViewTextBoxColumn.HeaderText = "Mã sinhv";
            studentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            studentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            studentNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Họ";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Tên";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dDBDataGridViewTextBoxColumn
            // 
            dDBDataGridViewTextBoxColumn.DataPropertyName = "DDB";
            dataGridViewCellStyle1.NullValue = "dd/MM/yyyy";
            dDBDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            dDBDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            dDBDataGridViewTextBoxColumn.MinimumWidth = 6;
            dDBDataGridViewTextBoxColumn.Name = "dDBDataGridViewTextBoxColumn";
            dDBDataGridViewTextBoxColumn.ReadOnly = true;
            dDBDataGridViewTextBoxColumn.Width = 125;
            // 
            // pOBDataGridViewTextBoxColumn
            // 
            pOBDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pOBDataGridViewTextBoxColumn.DataPropertyName = "POB";
            pOBDataGridViewTextBoxColumn.HeaderText = "Nơi sinh";
            pOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            pOBDataGridViewTextBoxColumn.Name = "pOBDataGridViewTextBoxColumn";
            pOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDTOBindingSource
            // 
            studentDTOBindingSource.DataSource = typeof(DTO.StudentDTO);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(toolStrip2);
            panel1.Location = new Point(27, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 253);
            panel1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lbTongSoSinhVien });
            statusStrip1.Location = new Point(0, 227);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(795, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(82, 20);
            toolStripStatusLabel1.Text = "Tổng số sv:";
            // 
            // lbTongSoSinhVien
            // 
            lbTongSoSinhVien.Name = "lbTongSoSinhVien";
            lbTongSoSinhVien.Size = new Size(17, 20);
            lbTongSoSinhVien.Text = "0";
            lbTongSoSinhVien.Click += lbTongSoSinhVien_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel1, btcThem, btnSua, btnDelete });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(795, 27);
            toolStrip2.TabIndex = 4;
            toolStrip2.Text = "toolStrip2";
            toolStrip2.ItemClicked += toolStrip2_ItemClicked;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(136, 24);
            toolStripLabel1.Text = "danh sach sinh vien";
            // 
            // btcThem
            // 
            btcThem.Alignment = ToolStripItemAlignment.Right;
            btcThem.Image = (Image)resources.GetObject("btcThem.Image");
            btcThem.ImageTransparentColor = Color.Magenta;
            btcThem.Name = "btcThem";
            btcThem.Size = new Size(70, 24);
            btcThem.Text = "Thêm";
            btcThem.Click += btcThem_Click;
            // 
            // btnSua
            // 
            btnSua.AccessibleDescription = "";
            btnSua.Alignment = ToolStripItemAlignment.Right;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageTransparentColor = Color.Magenta;
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(58, 24);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnDelete
            // 
            btnDelete.Alignment = ToolStripItemAlignment.Right;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(59, 24);
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(834, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // txttiemkiem
            // 
            txttiemkiem.Location = new Point(555, 14);
            txttiemkiem.Name = "txttiemkiem";
            txttiemkiem.Size = new Size(125, 27);
            txttiemkiem.TabIndex = 8;
            txttiemkiem.TextChanged += txttiemkiem_TextChanged;
            txttiemkiem.KeyPress += txttiemkiem_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 17);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Timf kiem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 446);
            Controls.Add(label4);
            Controls.Add(txttiemkiem);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbLop);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbLop;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private BindingSource studentDTOBindingSource;
        private DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dDBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pOBDataGridViewTextBoxColumn;
        private Panel panel1;
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbTongSoSinhVien;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btcThem;
        private ToolStripButton btnSua;
        private ToolStripButton btnDelete;
        private TextBox txttiemkiem;
        private Label label4;
    }
}