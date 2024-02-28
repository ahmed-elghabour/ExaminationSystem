namespace ExaminationSystem
{
    partial class InstructorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            tabPage4 = new TabPage();
            createBtn = new Button();
            MCQnum = new NumericUpDown();
            TFNum = new NumericUpDown();
            DurationNum = new NumericUpDown();
            CrsBox = new ComboBox();
            TFLbl = new Label();
            MCQlbl = new Label();
            DurationLbl = new Label();
            CourseLbl = new Label();
            tabPage2 = new TabPage();
            CoursesBox = new ListBox();
            tabPage1 = new TabPage();
            SignOutBtn = new Button();
            UpdateBTN = new Button();
            DegreeBox = new ComboBox();
            SalaryNum = new NumericUpDown();
            DepartmentBox = new ComboBox();
            NameTXT = new TextBox();
            SalaryLbl = new Label();
            DegreeLbl = new Label();
            DepartmentLbl = new Label();
            NameLbl = new Label();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            studentsBox = new ListBox();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MCQnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TFNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationNum).BeginInit();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryNum).BeginInit();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(createBtn);
            tabPage4.Controls.Add(MCQnum);
            tabPage4.Controls.Add(TFNum);
            tabPage4.Controls.Add(DurationNum);
            tabPage4.Controls.Add(CrsBox);
            tabPage4.Controls.Add(TFLbl);
            tabPage4.Controls.Add(MCQlbl);
            tabPage4.Controls.Add(DurationLbl);
            tabPage4.Controls.Add(CourseLbl);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(814, 409);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Create Exam";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createBtn.BackColor = Color.Coral;
            createBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.Location = new Point(283, 313);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(219, 45);
            createBtn.TabIndex = 8;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // MCQnum
            // 
            MCQnum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MCQnum.Location = new Point(478, 244);
            MCQnum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MCQnum.Name = "MCQnum";
            MCQnum.Size = new Size(213, 27);
            MCQnum.TabIndex = 7;
            // 
            // TFNum
            // 
            TFNum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TFNum.Location = new Point(107, 244);
            TFNum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            TFNum.Name = "TFNum";
            TFNum.Size = new Size(249, 27);
            TFNum.TabIndex = 6;
            // 
            // DurationNum
            // 
            DurationNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DurationNum.Location = new Point(478, 133);
            DurationNum.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            DurationNum.Name = "DurationNum";
            DurationNum.Size = new Size(213, 27);
            DurationNum.TabIndex = 5;
            // 
            // CrsBox
            // 
            CrsBox.FormattingEnabled = true;
            CrsBox.Location = new Point(107, 133);
            CrsBox.Name = "CrsBox";
            CrsBox.Size = new Size(249, 28);
            CrsBox.TabIndex = 4;
            CrsBox.Text = "Choose course";
            // 
            // TFLbl
            // 
            TFLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TFLbl.AutoSize = true;
            TFLbl.BackColor = Color.Transparent;
            TFLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TFLbl.Location = new Point(107, 195);
            TFLbl.Name = "TFLbl";
            TFLbl.Size = new Size(230, 31);
            TFLbl.TabIndex = 3;
            TFLbl.Text = "True or False Number";
            // 
            // MCQlbl
            // 
            MCQlbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MCQlbl.AutoSize = true;
            MCQlbl.BackColor = Color.Transparent;
            MCQlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MCQlbl.Location = new Point(478, 195);
            MCQlbl.Name = "MCQlbl";
            MCQlbl.Size = new Size(156, 31);
            MCQlbl.TabIndex = 2;
            MCQlbl.Text = "MCQ Number";
            // 
            // DurationLbl
            // 
            DurationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DurationLbl.AutoSize = true;
            DurationLbl.BackColor = Color.Transparent;
            DurationLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DurationLbl.Location = new Point(478, 81);
            DurationLbl.Name = "DurationLbl";
            DurationLbl.Size = new Size(103, 31);
            DurationLbl.TabIndex = 1;
            DurationLbl.Text = "Duration";
            // 
            // CourseLbl
            // 
            CourseLbl.AutoSize = true;
            CourseLbl.BackColor = Color.Transparent;
            CourseLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CourseLbl.Location = new Point(107, 81);
            CourseLbl.Name = "CourseLbl";
            CourseLbl.Size = new Size(151, 31);
            CourseLbl.TabIndex = 0;
            CourseLbl.Text = "Course Name";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(CoursesBox);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(814, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Courses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CoursesBox
            // 
            CoursesBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CoursesBox.FormattingEnabled = true;
            CoursesBox.Location = new Point(118, 5);
            CoursesBox.Name = "CoursesBox";
            CoursesBox.Size = new Size(430, 364);
            CoursesBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(SignOutBtn);
            tabPage1.Controls.Add(UpdateBTN);
            tabPage1.Controls.Add(DegreeBox);
            tabPage1.Controls.Add(SalaryNum);
            tabPage1.Controls.Add(DepartmentBox);
            tabPage1.Controls.Add(NameTXT);
            tabPage1.Controls.Add(SalaryLbl);
            tabPage1.Controls.Add(DegreeLbl);
            tabPage1.Controls.Add(DepartmentLbl);
            tabPage1.Controls.Add(NameLbl);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(814, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Edit";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // SignOutBtn
            // 
            SignOutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SignOutBtn.BackColor = Color.DarkSalmon;
            SignOutBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignOutBtn.ForeColor = SystemColors.ControlText;
            SignOutBtn.Location = new Point(611, 351);
            SignOutBtn.Name = "SignOutBtn";
            SignOutBtn.Size = new Size(197, 51);
            SignOutBtn.TabIndex = 10;
            SignOutBtn.Text = "Sign Out";
            SignOutBtn.UseVisualStyleBackColor = false;
            SignOutBtn.Click += SignOutBtn_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UpdateBTN.BackColor = Color.DarkSalmon;
            UpdateBTN.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBTN.ForeColor = SystemColors.ControlText;
            UpdateBTN.Location = new Point(270, 313);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(233, 48);
            UpdateBTN.TabIndex = 9;
            UpdateBTN.Text = "Update";
            UpdateBTN.UseVisualStyleBackColor = false;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // DegreeBox
            // 
            DegreeBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DegreeBox.FormattingEnabled = true;
            DegreeBox.Items.AddRange(new object[] { "Master", "PH.D", "M.D", "Eng.D", " J.D", " M.D", "Eng.D", "TC", "TL", "PTC" });
            DegreeBox.Location = new Point(99, 231);
            DegreeBox.Name = "DegreeBox";
            DegreeBox.Size = new Size(238, 28);
            DegreeBox.TabIndex = 8;
            // 
            // SalaryNum
            // 
            SalaryNum.Location = new Point(402, 101);
            SalaryNum.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            SalaryNum.Name = "SalaryNum";
            SalaryNum.Size = new Size(226, 27);
            SalaryNum.TabIndex = 7;
            // 
            // DepartmentBox
            // 
            DepartmentBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.Location = new Point(439, 231);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(226, 28);
            DepartmentBox.TabIndex = 6;
            // 
            // NameTXT
            // 
            NameTXT.Location = new Point(99, 101);
            NameTXT.Name = "NameTXT";
            NameTXT.Size = new Size(238, 27);
            NameTXT.TabIndex = 4;
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.BackColor = Color.Transparent;
            SalaryLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalaryLbl.Location = new Point(402, 64);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(75, 31);
            SalaryLbl.TabIndex = 3;
            SalaryLbl.Text = "Salary";
            // 
            // DegreeLbl
            // 
            DegreeLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DegreeLbl.AutoSize = true;
            DegreeLbl.BackColor = Color.Transparent;
            DegreeLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DegreeLbl.Location = new Point(99, 184);
            DegreeLbl.Name = "DegreeLbl";
            DegreeLbl.Size = new Size(88, 31);
            DegreeLbl.TabIndex = 2;
            DegreeLbl.Text = "Degree";
            // 
            // DepartmentLbl
            // 
            DepartmentLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DepartmentLbl.AutoSize = true;
            DepartmentLbl.BackColor = Color.Transparent;
            DepartmentLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepartmentLbl.Location = new Point(439, 184);
            DepartmentLbl.Name = "DepartmentLbl";
            DepartmentLbl.Size = new Size(137, 31);
            DepartmentLbl.TabIndex = 1;
            DepartmentLbl.Text = "Department";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.BackColor = Color.Transparent;
            NameLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLbl.Location = new Point(99, 64);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(75, 31);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Name";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(11, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(822, 445);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(studentsBox);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(814, 409);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Students";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // studentsBox
            // 
            studentsBox.FormattingEnabled = true;
            studentsBox.Location = new Point(176, 17);
            studentsBox.Name = "studentsBox";
            studentsBox.Size = new Size(404, 364);
            studentsBox.TabIndex = 0;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 461);
            Controls.Add(tabControl1);
            Name = "InstructorForm";
            Text = "Instructor";
            FormClosing += InstructorForm_FormClosing;
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MCQnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)TFNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationNum).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryNum).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage4;
        private ComboBox CrsBox;
        private Label TFLbl;
        private Label MCQlbl;
        private Label DurationLbl;
        private Label CourseLbl;
        private TabPage tabPage2;
        private ListBox CoursesBox;
        private TabPage tabPage1;
        private Button UpdateBTN;
        private ComboBox DegreeBox;
        private NumericUpDown SalaryNum;
        private ComboBox DepartmentBox;
        private TextBox NameTXT;
        private Label SalaryLbl;
        private Label DegreeLbl;
        private Label DepartmentLbl;
        private Label NameLbl;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private Button createBtn;
        private NumericUpDown MCQnum;
        private NumericUpDown TFNum;
        private NumericUpDown DurationNum;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Button SignOutBtn;
        private ListBox studentsBox;
    }
}
