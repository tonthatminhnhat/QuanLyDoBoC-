using EFCoreTutorial.DTO;
using EFCoreTutorial.Model;

namespace EFCoreTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadClassroom();
        }
        void LoadClassroom()
        {
            // buoc1 lay du lileu
            StudentDB db = new StudentDB();
            //  var ls = db.Classrooms.ToList();
            //   var ls=db.Classrooms.Where(e=>e.Name.Contains("A")).ToList();//laays lop A
            /*  var ls = db.Classrooms.Where(e =>
              e.Name.Contains("A") ||
                e.Name.Contains("L")
              ).ToList(); // laays A vaf L*/
            var ls = db.Classrooms.Select(e => new ClassroomDTO
            {
                Id = e.Id,
                Name = e.Name,
                AmountStudent = e.Students.Count()
            }).ToList();
            //đẩy lên giao diện
            cbbLop.DataSource = ls;
            cbbLop.DisplayMember = "Display";
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadStudent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void loadStudent()
        {

            lbTongSoSinhVien.Text = "0";
            //lay thông tin cuar lop dang chon
            var lop = cbbLop.SelectedItem as ClassroomDTO;

            //lay ds sv trong lop dang chon
            if (lop != null)
            {
                StudentDB db = new StudentDB();
                var ls = db.Students.Where(t => t.IdClassroom == lop.Id)
                    .Select(t => new StudentDTO
                    {
                        Id = t.Id,
                        IdClassroom = t.IdClassroom,
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        DDB = t.DDB,
                        POB = t.POB,
                        StudentNumber = t.StudentNumber
                    }).ToList();
                studentDTOBindingSource.DataSource = ls;
                lbTongSoSinhVien.Text = ls.Count.ToString();
            }
            else studentDTOBindingSource.DataSource = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //xac dinh sinh vien dang chon
            var sv = studentDTOBindingSource.Current as StudentDTO;
            if (sv != null)
            {
                var rs = MessageBox.Show("ban co that su muon xoa?",
                      "ThongBao"
                      , MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    StudentDB db = new StudentDB();
                    var obj = db.Students.Where(t => t.Id == sv.Id)
                        .FirstOrDefault();
                    if (obj != null)
                    {
                        db.Students.Remove(obj);
                        db.SaveChanges();
                        loadStudent();
                    }
                }
            }
            //xac nhan xoa roi ok
        }


        private void btcThem_Click(object sender, EventArgs e)
        {
            var f = new FormStudentDetail();
            if (f.ShowDialog() == DialogResult.OK)
            {
                loadStudent();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sv = studentDTOBindingSource.Current as StudentDTO;
            if (sv != null)
            {
                var f = new FormStudentDetail(sv);
                if (f.ShowDialog() == DialogResult.OK)
                    loadStudent();
            }
        }


        private void txttiemkiem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                var tuKhoa = txttiemkiem.Text.ToLower();

                using (var db = new StudentDB())
                {
                    var ls = db.Students
                        .Where(t =>
                        t.POB.ToLower().Contains(tuKhoa) ||
                        (t.LastName + " " + t.FirstName).ToLower().Contains(tuKhoa) ||
                         (t.FirstName + " " + t.LastName).ToLower().Contains(tuKhoa) ||
                        t.LastName.ToLower().Contains(tuKhoa) ||
                        t.FirstName.ToLower().Contains(tuKhoa) ||
                        t.StudentNumber.Contains(tuKhoa))
                        .Select(t => new StudentDTO
                        {
                            Id = t.Id,
                            StudentNumber = t.StudentNumber,
                            FirstName = t.FirstName,
                            LastName = t.LastName,
                            POB = t.POB,
                            DDB = t.DDB,
                            IdClassroom = t.IdClassroom
                        }).ToList();
                    studentDTOBindingSource.DataSource = null;
                    studentDTOBindingSource.DataSource = ls;
                }

            }
        }

        private void lbTongSoSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void txttiemkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}