using ExaminationSystem.Context;
using ExaminationSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class StudentForm : Form
    {
        public int StdID { get; init; }

        List<Course> StudentCourses;

        ExaminationContext Context = new();

        public StudentForm(int id)
        {
            StdID = id;
            InitializeComponent();
            GetDepartmentNamesFromDataBase();
            LoadStudentData(StdID);
            GetStudentCourses(StdID);
            //GetCourseGrade(id);

            this.FormClosing += (e, v) => Context?.Dispose();
        }

        private void GetDepartmentNamesFromDataBase()
        {
            var Departments = Context.Departments.ToList();
            foreach (var dept in Departments)
            {
                string DeptName = dept.DeptName.ToString();
                comboBoxDepartment.Items.Add(DeptName);
            }
        }


        private void LoadStudentData(int id)
        {
            try
            {
                var StudentData = Context.Students.FromSql($"exec SP_SelectStudent {id}").ToList();
                if (StudentData.Count > 0)
                {
                    var student = StudentData.First();
                    txtFirstName.Text = student.StdFirstName;
                    txtLastName.Text = student.StdLastName;
                    txtAddress.Text = student.Address;
                    comboBoxGender.SelectedItem = student.Gender;
                    if (DateTime.TryParseExact(student.BirthDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
                    {
                        dateTimeBirthDate.Value = birthDate;
                    }
                    txtPhoneNumber.Text = student.PhoneNumber;
                    var Department = Context.Departments.FromSql($"exec SP_SelectDepartment {student.DeptId}").ToList();
                    if (Department.Count > 0)
                    {
                        var department = Department.First();
                        comboBoxDepartment.SelectedItem = department.DeptName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var Student = Context.Students?.FromSql($"exec SP_SelectStudent {StdID}").AsEnumerable().FirstOrDefault();
                if (Student != null)
                {
                    Student.StdFirstName = txtFirstName.Text;
                    Student.StdLastName = txtLastName.Text;
                    Student.Address = txtAddress.Text;
                    Student.Gender = comboBoxGender?.SelectedItem?.ToString();

                    if (DateTime.TryParseExact(dateTimeBirthDate.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
                    {
                        Student.BirthDate = DateOnly.FromDateTime(birthDate);
                    }

                    Student.PhoneNumber = txtPhoneNumber.Text;

                    string departmentName = comboBoxDepartment?.SelectedItem?.ToString() ?? String.Empty;
                    var Department = Context.Departments.FirstOrDefault(d => d.DeptName == departmentName);
                    Student.DeptId = Department?.DeptId;
                }

                Context.SaveChanges();
                MessageBox.Show(this, "Student data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }




        private void GetStudentCourses(int id)
        {
            try
            {
                comboBoxExams.Items.Clear();
                StudentCourses = Context.Courses
                                .Where(course => course.StdCrs.Any(stdCrs => stdCrs.StdId == id))
                                .ToList();

                comboBoxExams.DataSource = StudentCourses;
                comboBoxExams.DisplayMember = "CourseName";
                comboBoxExams.ValueMember = "CourseId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }


        }



        private void btnStartExam_Click(object sender, EventArgs e)
        {
            var randomExam = Context.Exams
                .Where(exam => exam.CourseId == Convert.ToInt32(comboBoxExams.SelectedValue))
                .OrderBy(e => Guid.NewGuid()) // Order by random
                .FirstOrDefault();

            if (randomExam == null)
            {
                MessageBox.Show(this, "No Exam Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ExamForm examForm = new();

            examForm.ExamID = randomExam.ExamId;
            examForm.studentID = StdID;

            Trace.WriteLine(Convert.ToInt32(comboBoxExams.SelectedValue) + " aaasasasa");

            examForm.next = this;
            examForm.Show();

            this.Hide();
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Context?.Dispose();
            Application.Exit();
        }

        private void GetCourseGrade()
        {

        }

        void load_coures_data()
        {
            coursesGradesBox.Items.Clear();
            gradesBox.Items.Clear();
            try
            {
                var results = (from sc in Context.StdCrs
                               join c in Context.Courses on sc.CourseId equals c.CourseId
                               where sc.StdId == StdID
                               select new
                               {
                                   c.CourseName,
                                   CoursesGrades = sc.StdGrade
                               }).ToList();
                if (results != null)
                {
                    foreach (var student in results)
                    {
                        coursesGradesBox.Items.Add($"{student.CourseName}");
                        gradesBox.Items.Add($"{student.CoursesGrades}");
                    }
                }
                else
                    coursesGradesBox.Text = "No Courses";


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new();
            logForm.Show();
            this.Hide();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            load_coures_data();
        }
    }
}
