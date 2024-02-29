namespace ExaminationSystem
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            tabControl1 = new TabControl();
            tabEdit = new TabPage();
            button1 = new Button();
            btnUpdateStudent = new Button();
            label7 = new Label();
            comboBoxDepartment = new ComboBox();
            label6 = new Label();
            txtPhoneNumber = new TextBox();
            dateTimeBirthDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            comboBoxGender = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtFirstName = new TextBox();
            tabExam = new TabPage();
            btnStartExam = new Button();
            label8 = new Label();
            comboBoxExams = new ComboBox();
            CoursesGrades = new TabPage();
            gradesBox = new ListBox();
            label10 = new Label();
            CourseNameLBL = new Label();
            coursesGradesBox = new ListBox();
            tabControl1.SuspendLayout();
            tabEdit.SuspendLayout();
            tabExam.SuspendLayout();
            CoursesGrades.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabEdit);
            tabControl1.Controls.Add(tabExam);
            tabControl1.Controls.Add(CoursesGrades);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 320);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabEdit
            // 
            tabEdit.BackgroundImage = (Image)resources.GetObject("tabEdit.BackgroundImage");
            tabEdit.BackgroundImageLayout = ImageLayout.Stretch;
            tabEdit.Controls.Add(button1);
            tabEdit.Controls.Add(btnUpdateStudent);
            tabEdit.Controls.Add(label7);
            tabEdit.Controls.Add(comboBoxDepartment);
            tabEdit.Controls.Add(label6);
            tabEdit.Controls.Add(txtPhoneNumber);
            tabEdit.Controls.Add(dateTimeBirthDate);
            tabEdit.Controls.Add(label5);
            tabEdit.Controls.Add(label4);
            tabEdit.Controls.Add(comboBoxGender);
            tabEdit.Controls.Add(label3);
            tabEdit.Controls.Add(label2);
            tabEdit.Controls.Add(label1);
            tabEdit.Controls.Add(txtLastName);
            tabEdit.Controls.Add(txtAddress);
            tabEdit.Controls.Add(txtFirstName);
            tabEdit.ForeColor = Color.White;
            tabEdit.Location = new Point(4, 24);
            tabEdit.Margin = new Padding(3, 2, 3, 2);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3, 2, 3, 2);
            tabEdit.Size = new Size(671, 292);
            tabEdit.TabIndex = 1;
            tabEdit.Text = "Edit";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(5, 250);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(185, 43);
            button1.TabIndex = 15;
            button1.Text = "Signout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = Color.DeepSkyBlue;
            btnUpdateStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatStyle = FlatStyle.Flat;
            btnUpdateStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateStudent.ForeColor = Color.White;
            btnUpdateStudent.Location = new Point(443, 185);
            btnUpdateStudent.Margin = new Padding(3, 2, 3, 2);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(185, 43);
            btnUpdateStudent.TabIndex = 14;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(360, 149);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 13;
            label7.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(443, 147);
            comboBoxDepartment.Margin = new Padding(3, 2, 3, 2);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(185, 23);
            comboBoxDepartment.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(394, 110);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Phone";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(443, 110);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(185, 23);
            txtPhoneNumber.TabIndex = 10;
            // 
            // dateTimeBirthDate
            // 
            dateTimeBirthDate.CustomFormat = "";
            dateTimeBirthDate.Format = DateTimePickerFormat.Short;
            dateTimeBirthDate.Location = new Point(443, 72);
            dateTimeBirthDate.Margin = new Padding(3, 2, 3, 2);
            dateTimeBirthDate.MaxDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimeBirthDate.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dateTimeBirthDate.Name = "dateTimeBirthDate";
            dateTimeBirthDate.Size = new Size(185, 23);
            dateTimeBirthDate.TabIndex = 9;
            dateTimeBirthDate.Value = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(369, 72);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(47, 209);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(102, 208);
            comboBoxGender.Margin = new Padding(3, 2, 3, 2);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(185, 23);
            comboBoxGender.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(43, 165);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 121);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 76);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(102, 118);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(102, 164);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(185, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(102, 74);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 23);
            txtFirstName.TabIndex = 0;
            // 
            // tabExam
            // 
            tabExam.Controls.Add(btnStartExam);
            tabExam.Controls.Add(label8);
            tabExam.Controls.Add(comboBoxExams);
            tabExam.Location = new Point(4, 24);
            tabExam.Margin = new Padding(3, 2, 3, 2);
            tabExam.Name = "tabExam";
            tabExam.Size = new Size(671, 292);
            tabExam.TabIndex = 2;
            tabExam.Text = "Exam";
            tabExam.UseVisualStyleBackColor = true;
            // 
            // btnStartExam
            // 
            btnStartExam.Location = new Point(242, 207);
            btnStartExam.Margin = new Padding(3, 2, 3, 2);
            btnStartExam.Name = "btnStartExam";
            btnStartExam.Size = new Size(284, 66);
            btnStartExam.TabIndex = 2;
            btnStartExam.Text = "Start Exam";
            btnStartExam.UseVisualStyleBackColor = true;
            btnStartExam.Click += btnStartExam_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 95);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 1;
            label8.Text = "Student Courses";
            // 
            // comboBoxExams
            // 
            comboBoxExams.FormattingEnabled = true;
            comboBoxExams.Location = new Point(328, 93);
            comboBoxExams.Margin = new Padding(3, 2, 3, 2);
            comboBoxExams.Name = "comboBoxExams";
            comboBoxExams.Size = new Size(133, 23);
            comboBoxExams.TabIndex = 0;
            // 
            // CoursesGrades
            // 
            CoursesGrades.Controls.Add(gradesBox);
            CoursesGrades.Controls.Add(label10);
            CoursesGrades.Controls.Add(CourseNameLBL);
            CoursesGrades.Controls.Add(coursesGradesBox);
            CoursesGrades.Location = new Point(4, 24);
            CoursesGrades.Name = "CoursesGrades";
            CoursesGrades.Padding = new Padding(3, 3, 3, 3);
            CoursesGrades.Size = new Size(671, 292);
            CoursesGrades.TabIndex = 3;
            CoursesGrades.Text = "Courses Grades";
            CoursesGrades.UseVisualStyleBackColor = true;
            // 
            // gradesBox
            // 
            gradesBox.FormattingEnabled = true;
            gradesBox.ItemHeight = 15;
            gradesBox.Location = new Point(351, 30);
            gradesBox.Name = "gradesBox";
            gradesBox.Size = new Size(251, 334);
            gradesBox.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(443, 7);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 3;
            label10.Text = "Grade";
            // 
            // CourseNameLBL
            // 
            CourseNameLBL.AutoSize = true;
            CourseNameLBL.Location = new Point(193, 7);
            CourseNameLBL.Name = "CourseNameLBL";
            CourseNameLBL.Size = new Size(44, 15);
            CourseNameLBL.TabIndex = 1;
            CourseNameLBL.Text = "Course";
            // 
            // coursesGradesBox
            // 
            coursesGradesBox.FormattingEnabled = true;
            coursesGradesBox.ItemHeight = 15;
            coursesGradesBox.Location = new Point(131, 30);
            coursesGradesBox.Name = "coursesGradesBox";
            coursesGradesBox.Size = new Size(233, 334);
            coursesGradesBox.TabIndex = 0;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            FormClosing += StudentForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            tabExam.ResumeLayout(false);
            tabExam.PerformLayout();
            CoursesGrades.ResumeLayout(false);
            CoursesGrades.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabEdit;
        private TabPage tabExam;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtFirstName;
        private Label label4;
        private ComboBox comboBoxGender;
        private Label label5;
        private DateTimePicker dateTimeBirthDate;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label label7;
        private ComboBox comboBoxDepartment;
        private Button btnUpdateStudent;
        private ComboBox comboBoxExams;
        private Label label8;
        private Button btnStartExam;
        private TabPage CoursesGrades;
        private ListBox coursesGradesBox;
        private Label label10;
        private Label CourseNameLBL;
        private ListBox gradesBox;
        private Button button1;
    }
}