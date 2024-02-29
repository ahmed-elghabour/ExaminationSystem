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
            tabControl1 = new TabControl();
            tabEdit = new TabPage();
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
            button1 = new Button();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            tabEdit.SuspendLayout();
            tabExam.SuspendLayout();
            CoursesGrades.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabEdit);
            tabControl1.Controls.Add(tabExam);
            tabControl1.Controls.Add(CoursesGrades);
            tabControl1.Location = new Point(12, 39);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 256);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabEdit
            // 
            tabEdit.BackColor = Color.White;
            tabEdit.BackgroundImageLayout = ImageLayout.Stretch;
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
            tabEdit.Size = new Size(671, 228);
            tabEdit.TabIndex = 1;
            tabEdit.Text = "Edit";
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = Color.FromArgb(49, 123, 209);
            btnUpdateStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatStyle = FlatStyle.Flat;
            btnUpdateStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateStudent.ForeColor = Color.White;
            btnUpdateStudent.Location = new Point(445, 136);
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
            label7.ForeColor = Color.Black;
            label7.Location = new Point(362, 100);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 13;
            label7.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(445, 98);
            comboBoxDepartment.Margin = new Padding(3, 2, 3, 2);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(185, 23);
            comboBoxDepartment.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(396, 61);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Phone";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(445, 61);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(185, 23);
            txtPhoneNumber.TabIndex = 10;
            // 
            // dateTimeBirthDate
            // 
            dateTimeBirthDate.CustomFormat = "";
            dateTimeBirthDate.Format = DateTimePickerFormat.Short;
            dateTimeBirthDate.Location = new Point(445, 23);
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
            label5.ForeColor = Color.Black;
            label5.Location = new Point(371, 23);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(49, 160);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // comboBoxGender
            // 
            comboBoxGender.ForeColor = Color.Black;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(104, 159);
            comboBoxGender.Margin = new Padding(3, 2, 3, 2);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(185, 23);
            comboBoxGender.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(45, 116);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 72);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(104, 69);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(104, 115);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(185, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(104, 25);
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
            tabExam.Size = new Size(671, 228);
            tabExam.TabIndex = 2;
            tabExam.Text = "Exam";
            tabExam.UseVisualStyleBackColor = true;
            // 
            // btnStartExam
            // 
            btnStartExam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStartExam.BackColor = Color.FromArgb(49, 123, 209);
            btnStartExam.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartExam.ForeColor = Color.White;
            btnStartExam.Location = new Point(203, 144);
            btnStartExam.Margin = new Padding(3, 2, 3, 2);
            btnStartExam.Name = "btnStartExam";
            btnStartExam.Size = new Size(284, 66);
            btnStartExam.TabIndex = 2;
            btnStartExam.Text = "Start Exam";
            btnStartExam.UseVisualStyleBackColor = false;
            btnStartExam.Click += btnStartExam_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(212, 96);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 1;
            label8.Text = "Student Courses";
            // 
            // comboBoxExams
            // 
            comboBoxExams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            CoursesGrades.Padding = new Padding(3);
            CoursesGrades.Size = new Size(671, 228);
            CoursesGrades.TabIndex = 3;
            CoursesGrades.Text = "Courses Grades";
            CoursesGrades.UseVisualStyleBackColor = true;
            // 
            // gradesBox
            // 
            gradesBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradesBox.FormattingEnabled = true;
            gradesBox.ItemHeight = 15;
            gradesBox.Location = new Point(342, 32);
            gradesBox.Name = "gradesBox";
            gradesBox.Size = new Size(251, 229);
            gradesBox.TabIndex = 4;
            // 
            // label10
            // 
            label10.Location = new Point(448, 9);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 3;
            label10.Text = "Grade";
            // 
            // CourseNameLBL
            // 
            CourseNameLBL.Location = new Point(195, 8);
            CourseNameLBL.Name = "CourseNameLBL";
            CourseNameLBL.Size = new Size(44, 22);
            CourseNameLBL.TabIndex = 1;
            CourseNameLBL.Text = "Course";
            // 
            // coursesGradesBox
            // 
            coursesGradesBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            coursesGradesBox.FormattingEnabled = true;
            coursesGradesBox.ItemHeight = 15;
            coursesGradesBox.Location = new Point(101, 32);
            coursesGradesBox.Name = "coursesGradesBox";
            coursesGradesBox.Size = new Size(233, 229);
            coursesGradesBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(49, 123, 209);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(569, 301);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 26);
            button1.TabIndex = 16;
            button1.Text = "Signout";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 123, 209);
            panel1.Location = new Point(-19, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 45);
            panel1.TabIndex = 17;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(button1);
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
        private Panel panel1;
    }
}