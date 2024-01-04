namespace EFCoreTutorial
{
    partial class FormStudentDetail
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
            lbtieude = new Label();
            label2 = new Label();
            cbblop = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtmasinhvien = new TextBox();
            txtten = new TextBox();
            txtho = new TextBox();
            txtnoisinh = new TextBox();
            btndongy = new Button();
            btnboqua = new Button();
            cbbdate = new DateTimePicker();
            SuspendLayout();
            // 
            // lbtieude
            // 
            lbtieude.AutoSize = true;
            lbtieude.Location = new Point(25, 9);
            lbtieude.Name = "lbtieude";
            lbtieude.Size = new Size(76, 20);
            lbtieude.TabIndex = 0;
            lbtieude.Text = "Thêm mói";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 82);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "lớp";
            // 
            // cbblop
            // 
            cbblop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbblop.FormattingEnabled = true;
            cbblop.Location = new Point(188, 74);
            cbblop.Name = "cbblop";
            cbblop.Size = new Size(151, 28);
            cbblop.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 116);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã sinh viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 180);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 4;
            label4.Text = "Họ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 180);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 5;
            label5.Text = "Tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 231);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 6;
            label6.Text = "NGày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 270);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 7;
            label7.Text = "Nơi sinh";
            // 
            // txtmasinhvien
            // 
            txtmasinhvien.Location = new Point(202, 121);
            txtmasinhvien.Name = "txtmasinhvien";
            txtmasinhvien.Size = new Size(125, 27);
            txtmasinhvien.TabIndex = 8;
            // 
            // txtten
            // 
            txtten.Location = new Point(188, 177);
            txtten.Name = "txtten";
            txtten.Size = new Size(125, 27);
            txtten.TabIndex = 9;
            // 
            // txtho
            // 
            txtho.Location = new Point(391, 180);
            txtho.Name = "txtho";
            txtho.Size = new Size(125, 27);
            txtho.TabIndex = 10;
            // 
            // txtnoisinh
            // 
            txtnoisinh.Location = new Point(171, 267);
            txtnoisinh.Name = "txtnoisinh";
            txtnoisinh.Size = new Size(125, 27);
            txtnoisinh.TabIndex = 12;
            // 
            // btndongy
            // 
            btndongy.Location = new Point(517, 325);
            btndongy.Name = "btndongy";
            btndongy.Size = new Size(94, 29);
            btndongy.TabIndex = 13;
            btndongy.Text = "Đồng ý";
            btndongy.UseVisualStyleBackColor = true;
            // 
            // btnboqua
            // 
            btnboqua.Location = new Point(644, 330);
            btnboqua.Name = "btnboqua";
            btnboqua.Size = new Size(94, 29);
            btnboqua.TabIndex = 14;
            btnboqua.Text = "Bỏ qua";
            btnboqua.UseVisualStyleBackColor = true;
            // 
            // cbbdate
            // 
            cbbdate.Format = DateTimePickerFormat.Short;
            cbbdate.Location = new Point(188, 234);
            cbbdate.Name = "cbbdate";
            cbbdate.Size = new Size(250, 27);
            cbbdate.TabIndex = 15;
            // 
            // FormStudentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnboqua;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(cbbdate);
            Controls.Add(btnboqua);
            Controls.Add(btndongy);
            Controls.Add(txtnoisinh);
            Controls.Add(txtho);
            Controls.Add(txtten);
            Controls.Add(txtmasinhvien);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbblop);
            Controls.Add(label2);
            Controls.Add(lbtieude);
            Name = "FormStudentDetail";
            Load += FormStudentDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtieude;
        private Label label2;
        private ComboBox cbblop;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtmasinhvien;
        private TextBox txtten;
        private TextBox txtho;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private TextBox txtnoisinh;
        private Button btndongy;
        private Button button1;
        private Button btnboqua;
        private DateTimePicker cbbdate;
    }
}