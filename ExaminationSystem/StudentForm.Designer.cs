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
            label8 = new Label();
            comboBoxExams = new ComboBox();
            btnStartExam = new Button();
            tabControl1.SuspendLayout();
            tabEdit.SuspendLayout();
            tabExam.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabEdit);
            tabControl1.Controls.Add(tabExam);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabEdit
            // 
            tabEdit.BackgroundImage = (Image)resources.GetObject("tabEdit.BackgroundImage");
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
            tabEdit.Location = new Point(4, 29);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(768, 393);
            tabEdit.TabIndex = 1;
            tabEdit.Text = "Edit";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = Color.DeepSkyBlue;
            btnUpdateStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatStyle = FlatStyle.Flat;
            btnUpdateStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateStudent.ForeColor = Color.White;
            btnUpdateStudent.Location = new Point(506, 247);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(211, 57);
            btnUpdateStudent.TabIndex = 14;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(411, 199);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 13;
            label7.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(506, 196);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(211, 28);
            comboBoxDepartment.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(450, 146);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "Phone";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(506, 146);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(211, 27);
            txtPhoneNumber.TabIndex = 10;
            // 
            // dateTimeBirthDate
            // 
            dateTimeBirthDate.CustomFormat = "";
            dateTimeBirthDate.Format = DateTimePickerFormat.Short;
            dateTimeBirthDate.Location = new Point(506, 96);
            dateTimeBirthDate.MaxDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimeBirthDate.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dateTimeBirthDate.Name = "dateTimeBirthDate";
            dateTimeBirthDate.Size = new Size(211, 27);
            dateTimeBirthDate.TabIndex = 9;
            dateTimeBirthDate.Value = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(422, 96);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 8;
            label5.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(54, 279);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(117, 278);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(211, 28);
            comboBoxGender.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(49, 220);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(32, 161);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 102);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(117, 158);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(211, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(117, 218);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(211, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(117, 98);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(211, 27);
            txtFirstName.TabIndex = 0;
            // 
            // tabExam
            // 
            tabExam.Controls.Add(btnStartExam);
            tabExam.Controls.Add(label8);
            tabExam.Controls.Add(comboBoxExams);
            tabExam.Location = new Point(4, 29);
            tabExam.Name = "tabExam";
            tabExam.Size = new Size(768, 393);
            tabExam.TabIndex = 2;
            tabExam.Text = "Exam";
            tabExam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 127);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 1;
            label8.Text = "Student Courses";
            // 
            // comboBoxExams
            // 
            comboBoxExams.FormattingEnabled = true;
            comboBoxExams.Location = new Point(375, 124);
            comboBoxExams.Name = "comboBoxExams";
            comboBoxExams.Size = new Size(151, 28);
            comboBoxExams.TabIndex = 0;
            // 
            // btnStartExam
            // 
            btnStartExam.Location = new Point(242, 207);
            btnStartExam.Name = "btnStartExam";
            btnStartExam.Size = new Size(284, 66);
            btnStartExam.TabIndex = 2;
            btnStartExam.Text = "Start Exam";
            btnStartExam.UseVisualStyleBackColor = true;
            btnStartExam.Click += btnStartExam_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "StudentForm";
            Text = "StudentForm";
            tabControl1.ResumeLayout(false);
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            tabExam.ResumeLayout(false);
            tabExam.PerformLayout();
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
    }
}