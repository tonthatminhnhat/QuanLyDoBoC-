using EFCoreTutorial.DTO;
using EFCoreTutorial.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreTutorial
{
    public partial class FormStudentDetail : Form
    {
        StudentDTO student;
        public FormStudentDetail(StudentDTO student = null)
        {
            InitializeComponent();
            this.student = student;
            LoadLopHoc();
            if (student != null)
            {
                //cap nhat
                this.Text = "Caapj nhat sinh vien";
                lbtieude.Text = "Cap nhat";
                cbblop.SelectedValue = student.IdClassroom;
                txtmasinhvien.Text = student.StudentNumber;
                txtho.Text = student.LastName;
                txtten.Text = student.FirstName;
                cbbdate.Value = student.DDB ?? DateTime.Now;
                txtnoisinh.Text = student.POB;
            }
        }
        void LoadLopHoc()
        {
            using (var db = new StudentDB())
            {
                var ls = db.Classrooms.Select(e => new ClassroomDTO
                {
                    Id = e.Id,
                    Name = e.Name,
                }).ToList();
                cbblop.DataSource= ls;
                cbblop.DisplayMember = "Name";
                cbblop.ValueMember = "Id";
            }
        }
        private void btndongy_click(object sender, EventArgs e)
        {
            using (var db = new StudentDB())
            {
                var lop = cbblop.SelectedItem as ClassroomDTO;
                if (student == null)
                {
                    var sv = new Student
                    {
                        FirstName = txtho.Text,
                        LastName = txtten.Text,
                        DDB = cbbdate.Value,
                        POB= txtnoisinh.Text,
                        StudentNumber = txtmasinhvien.Text,
                        IdClassroom = lop.Id
                    };
                    db.Students.Add(sv);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    // caapj nhaat thong tin sinh vine
                    var sv = db.Students.Where(t => t.Id == student.Id).FirstOrDefault();
                    sv.FirstName = txtten.Text;
                    sv.LastName = txtho.Text;
                    sv.POB = txtnoisinh.Text;
                    sv.DDB= cbbdate.Value;
                    sv.IdClassroom = lop.Id;
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;



                }
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormStudentDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
