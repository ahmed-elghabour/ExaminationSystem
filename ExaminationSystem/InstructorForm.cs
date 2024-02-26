using ExaminationSystem.Context;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ExaminationSystem
{
    public partial class InstructorForm : Form
    {
        ExaminationContext Context = new ExaminationContext();
        public InstructorForm()
        {
            InitializeComponent();
            DepartmentNamesFromDataBase();
            LoadInstructorData(1);
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
                    try
                    {
                        var Department = Context.Departments.FromSql($"exec SP_SelectDepartment {instructor.DeptId}").ToList();
                        if (Department.Count > 0)
                        {
                            var DeptName = Department.First();
                            DepartmentBox.SelectedItem = DeptName.DeptName;
                        }
                    }
                    catch
                    {
                        MessageBox.Show(this, "Instructor doesn\'t assigned to department", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
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

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            //var InstructorData = Context.Instructors.FromSql($"exec SP_SelectInstructor {id}");

        }
    }
}
