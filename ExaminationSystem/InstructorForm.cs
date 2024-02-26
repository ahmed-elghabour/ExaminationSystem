using ExaminationSystem.Context;
using ExaminationSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ExaminationSystem
{
    public partial class InstructorForm : Form
    {
        public int ID { get; init; }
        ExaminationContext Context = new ExaminationContext();
        public InstructorForm()
        {
            // TODO ID
            InitializeComponent();
            DepartmentNamesFromDataBase();
            CourseNamesFromDataBase(1);
            LoadInstructorData(1);
            GetInstructorCourses(1);
        }

        private void LoadInstructorData(int id)
        {
            try
            {
                var InstructorData = Context.Instructors.FromSql($"exec SP_SelectInstructor {id}").ToList();
                if (InstructorData.Count > 0)
                {
                    var instructor = InstructorData.First();
                    NameTXT.Text = instructor.InsName.ToString();
                    SalaryNum.Value = instructor.Salary;
                    DegreeBox.SelectedItem = instructor.Degree;
                    var Department = Context.Departments.FromSql($"exec SP_SelectDepartment {instructor.DeptId}").ToList();
                    if (Department.Count > 0)
                    {
                        var DeptName = Department.First();
                        DepartmentBox.SelectedItem = DeptName.DeptName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void DepartmentNamesFromDataBase()
        {
            var Departments = Context.Departments.ToList();
            foreach (var dept in Departments)
            {
                string DeptName = dept.DeptName.ToString();
                DepartmentBox.Items.Add(DeptName);
            }
        }

        private void CourseNamesFromDataBase(int id)
        {
            var courses = from c in Context.Courses
                          where c.Instructors.Any(c => c.InsId == id)
                          select c.CourseName;
            if (courses != null)
            {
                foreach (var course in courses)
                {
                    CrsBox.Items.Add(course);
                }
            }
            else
                CrsBox.Text = "No courses to teach";

        }

        private void GetInstructorCourses(int id)
        {
            try
            {
                CoursesBox.Items.Clear();
                var courses = from c in Context.Courses
                              where c.Instructors.Any(c => c.InsId == id)
                              select c.CourseName;
                if (courses != null)
                {
                    foreach (var course in courses)
                    {
                        CoursesBox.Items.Add(course);
                    }
                }
                else
                    CoursesBox.Text = "No courses to teach";


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }


        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            //TODO   id
            try
            {
                int id = 1;
                var Instructor = Context.Instructors.FromSqlRaw($"exec SP_SelectInstructor {id}").AsEnumerable().FirstOrDefault();
                Instructor.InsName = NameTXT.Text;
                Instructor.Degree = DegreeBox.SelectedItem.ToString();
                Instructor.Salary = (int)SalaryNum.Value;
                string departmentName = DepartmentBox.SelectedItem.ToString();
                var Department = Context.Departments.FirstOrDefault(d => d.DeptName == departmentName);
                Instructor.DeptId = Department.DeptId;
                Context.SaveChanges();
                MessageBox.Show(this, "Instructor data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logForm = new LoginForm();
            logForm.Show();
        }

        private void InstructorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int TFnumber = (int)TFNum.Value;
                int MCQnumber = (int)MCQnum.Value;
                int duration = (int)DurationNum.Value;
                string CourseName = CrsBox.SelectedItem.ToString();
                Context.Database.ExecuteSqlRaw("exec SP_GenerateExam @p0, @p1, @p2, @p3", CourseName, TFnumber, MCQnumber, duration);
                Context.SaveChanges();
                MessageBox.Show(this, "Exam created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
