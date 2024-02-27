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
            btnUpdateStudent = new Button();
            tabControl1.SuspendLayout();
            tabEdit.SuspendLayout();
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
            tabEdit.Location = new Point(4, 29);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(768, 393);
            tabEdit.TabIndex = 1;
            tabEdit.Text = "Edit";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 326);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 13;
            label7.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(147, 323);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(211, 28);
            comboBoxDepartment.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 277);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "Phone";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(147, 274);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(211, 27);
            txtPhoneNumber.TabIndex = 10;
            // 
            // dateTimeBirthDate
            // 
            dateTimeBirthDate.CustomFormat = "";
            dateTimeBirthDate.Format = DateTimePickerFormat.Short;
            dateTimeBirthDate.Location = new Point(147, 230);
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
            label5.Location = new Point(63, 230);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 8;
            label5.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 181);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(147, 178);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(211, 28);
            comboBoxGender.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 133);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 84);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 35);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(147, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(211, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(147, 129);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(211, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(147, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(211, 27);
            txtFirstName.TabIndex = 0;
            // 
            // tabExam
            // 
            tabExam.Location = new Point(4, 29);
            tabExam.Name = "tabExam";
            tabExam.Size = new Size(768, 393);
            tabExam.TabIndex = 2;
            tabExam.Text = "Exam";
            tabExam.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(603, 326);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(159, 61);
            btnUpdateStudent.TabIndex = 14;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
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
    }
}