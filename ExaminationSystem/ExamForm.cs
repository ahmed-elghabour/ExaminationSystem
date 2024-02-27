using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.Context;
using ExaminationSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace ExaminationSystem
{
    public partial class ExamForm : Form
    {
        int ExamID = 5;
        int studentID = 2;
        readonly ExaminationContext Context = new();
        BindingSource QustionBS = [];
        BindingSource AnswerBS = [];
        int[] UserSolution;
        List<int> FlagetQustions = new();
        int oldQustionIndex;
        bool flagCheckBox = false;
        List<List<QuestChoice>> AnswerList = [];
        public ExamForm()
        {
            InitializeComponent();

            this.FormClosing += (e, v) => Context?.Dispose();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            List<Question> QuestionsList;

            LAcademicYear.Text = GetCurrentAcademicYear();

            // Update Subject
            int courseID = Context.Exams.FirstOrDefault((e) => e.ExamId == ExamID).CourseId ?? -1;
            if (courseID > 0)
            {
                string subject = Context.Courses.FirstOrDefault(c => c.CourseId == courseID).CourseName ?? String.Empty;
                LSubject.Text = subject;
            }

            // Update Student
            Student currentStudent = Context?.Students?.FirstOrDefault(s => s.StdId == studentID);
            if (currentStudent != null)
            {
                LStudentName.Text = $"{currentStudent?.StdFirstName ?? String.Empty} {currentStudent?.StdFirstName ?? String.Empty}";
            }


            try
            {
                QuestionsList = Context.Questions.FromSql($"EXEC SP_SelectExam_Ques {ExamID}").ToList();

                if (QuestionsList.Count > 0)
                {
                    UserSolution = new int[QuestionsList.Count];

                    QustionBS.DataSource = QuestionsList;

                    this.TBQustionHeader.DataBindings.Add("Text", QustionBS, "QuestionHead", true);

                    //TBQustionHeader.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";



                    int w = PanelQustionShortcut.Width;
                    int h = PanelQustionShortcut.Height;
                    int buttonSize = 40;
                    int margin = 5;
                    int padding = 4;
                    int count = QuestionsList.Count;

                    // Calculate number of columns based on panel width and button size
                    int columns = (w - padding) / (buttonSize + margin);

                    // Calculate number of rows needed to fit all buttons
                    int rows = (int)Math.Ceiling((double)count / columns);

                    // Add buttons to the panel
                    for (int i = 0; i < count; i++)
                    {
                        int row = i / columns;
                        int column = i % columns;

                        Button button = new Button();
                        button.Width = buttonSize;
                        button.Height = buttonSize;
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        button.Left = padding + column * (buttonSize + margin); // Add padding
                        button.Top = padding + row * (buttonSize + margin); // Add padding
                        button.Text = $"{i + 1}";
                        int index = i;
                        button.Click += (s, e) => { QustionBS.Position = index; };
                        PanelQustionShortcut.Controls.Add(button);
                    }


                    // Answer Section 
                    for (int i = 0; i < count; i++)
                    {
                        int qID = QuestionsList[i].QuestionId;
                        Trace.WriteLine($"Current QID: {qID}");
                        AnswerList.Add(Context.QuestChoices.FromSql($"EXEC SP_SelectQuestChoices {qID}").ToList());

                    }
                }

                QustionBS.CurrentChanged += (s, e) =>
                {
                    updateAnsewrs(AnswerList[QustionBS.Position]);
                };
                oldQustionIndex = 0;
                updateAnsewrs(AnswerList[QustionBS.Position]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void updateAnsewrs(List<QuestChoice> newAnswer)
        {
            if (RBQuestChoices1.Checked)
                UserSolution[oldQustionIndex] = 1;
            if (RBQuestChoices2.Checked)
                UserSolution[oldQustionIndex] = 2;
            if (RBQuestChoices3.Checked)
                UserSolution[oldQustionIndex] = 3;
            if (RBQuestChoices4.Checked)
                UserSolution[oldQustionIndex] = 4;

            UpdateProgressBar(UserSolution.Count(value => value > 0), QustionBS.Count);
            LProggress.Text = $"{QustionBS.Position + 1}/{QustionBS.Count}";

            Button oldButton = (Button)PanelQustionShortcut.Controls[oldQustionIndex];
            oldButton.BackColor = Color.White;

            if (UserSolution[oldQustionIndex] != 0)
            {
                oldButton.Font = new(oldButton.Font, FontStyle.Bold);
            }

            flagCheckBox = true;
            if (FlagetQustions.Contains(QustionBS.Position))
            {
                CBFlag.Checked = true;
            }
            else
            {
                CBFlag.Checked = false;
            }
            flagCheckBox = false;
            PanelQustionShortcut.Controls[QustionBS.Position].BackColor = ColorTranslator.FromHtml("#EDEDED");

            oldQustionIndex = QustionBS.Position;


            RBQuestChoices1.Checked = false;
            RBQuestChoices2.Checked = false;
            RBQuestChoices3.Checked = false;
            RBQuestChoices4.Checked = false;

            if (UserSolution[oldQustionIndex] == 1)
                RBQuestChoices1.Checked = true;
            if (UserSolution[oldQustionIndex] == 2)
                RBQuestChoices2.Checked = true;
            if (UserSolution[oldQustionIndex] == 3)
                RBQuestChoices3.Checked = true;
            if (UserSolution[oldQustionIndex] == 4)
                RBQuestChoices4.Checked = true;


            if (newAnswer.Count == 2)
            {
                set_TF();
                RBQuestChoices1.Text = newAnswer[0].Sentence;
                RBQuestChoices2.Text = newAnswer[1].Sentence;
            }
            else if (newAnswer.Count == 4)
            {
                set_MCQ();
                RBQuestChoices1.Text = newAnswer[0].Sentence;
                RBQuestChoices2.Text = newAnswer[1].Sentence;
                RBQuestChoices3.Text = newAnswer[2].Sentence;
                RBQuestChoices4.Text = newAnswer[3].Sentence;
            }

        }

        void set_MCQ()
        {
            LQuestChoices3.Visible = true;
            RBQuestChoices3.Visible = true;
            LQuestChoices4.Visible = true;
            RBQuestChoices4.Visible = true;
        }
        void set_TF()
        {
            LQuestChoices3.Visible = false;
            RBQuestChoices3.Visible = false;
            LQuestChoices4.Visible = false;
            RBQuestChoices4.Visible = false;
        }

        private void BTNNextQuestion_Click(object sender, EventArgs e)
        {
            QustionBS.MoveNext();
        }

        private void BTNPreviousQuestion_Click(object sender, EventArgs e)
        {
            QustionBS.MovePrevious();
        }

        private void CBFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (flagCheckBox)
            {
                return;
            }

            if (FlagetQustions.Contains(QustionBS.Position))
            {
                FlagetQustions.Remove(QustionBS.Position);
                PanelQustionShortcut.Controls[QustionBS.Position].ForeColor = Color.FromArgb(0, 0, 0);
            }
            else
            {
                FlagetQustions.Add(QustionBS.Position);
                PanelQustionShortcut.Controls[QustionBS.Position].ForeColor = Color.FromArgb(49, 123, 209);
            }
        }

        private void Submit()
        {
            updateAnsewrs(AnswerList[QustionBS.Position]);

            string Answers = string.Join(",", UserSolution.Select(n => n == 0 ? "" : ((char)('A' + n - 1)).ToString())); ;
            Trace.WriteLine(Answers);
            try
            {
                var x = Context.Database.ExecuteSql($"EXEC SP_ExamAnswers @ExamID = {ExamID}, @Std_ID = {studentID}, @Answers = {Answers};");
                Trace.WriteLine(x);

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar(int current, int total)
        {
            double progressPercentage = ((double)current / (double)total) * 100;

            int percentage = (int)progressPercentage;
            // Calculate the width of the child panel based on the percentage
            int parentWidth = PanelProgressBar?.Parent?.Width ?? 0;
            int childWidth = (int)Math.Round(parentWidth * percentage / 100.0);

            // Set the width of the child panel
            PanelProgressBar.Width = childWidth;
        }

        private string GetCurrentAcademicYear()
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Determine the academic year start and end dates
            DateTime academicYearStart;
            DateTime academicYearEnd;

            if (currentDate.Month >= 9)
            {
                // If the current month is September or later, the academic year starts in the current year
                academicYearStart = new DateTime(currentDate.Year, 9, 1);
                academicYearEnd = new DateTime(currentDate.Year + 1, 7, 31);
            }
            else
            {
                // If the current month is before September, the academic year starts in the previous year
                academicYearStart = new DateTime(currentDate.Year - 1, 9, 1);
                academicYearEnd = new DateTime(currentDate.Year, 7, 31);
            }

            // Format the academic year as "YYYY/YYYY"
            string academicYear = $"{academicYearStart.Year}/{academicYearEnd.Year}";

            // Output the academic year
            return academicYear;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}
