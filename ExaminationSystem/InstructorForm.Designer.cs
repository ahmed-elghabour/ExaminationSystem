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
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MCQnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TFNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationNum).BeginInit();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryNum).BeginInit();
            tabControl1.SuspendLayout();
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
            tabPage4.Location = new Point(4, 27);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(679, 303);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Create Exam";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createBtn.BackColor = Color.Coral;
            createBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.Location = new Point(248, 235);
            createBtn.Margin = new Padding(3, 2, 3, 2);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(192, 34);
            createBtn.TabIndex = 8;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // MCQnum
            // 
            MCQnum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MCQnum.Location = new Point(418, 183);
            MCQnum.Margin = new Padding(3, 2, 3, 2);
            MCQnum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MCQnum.Name = "MCQnum";
            MCQnum.Size = new Size(186, 23);
            MCQnum.TabIndex = 7;
            // 
            // TFNum
            // 
            TFNum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TFNum.Location = new Point(94, 183);
            TFNum.Margin = new Padding(3, 2, 3, 2);
            TFNum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            TFNum.Name = "TFNum";
            TFNum.Size = new Size(218, 23);
            TFNum.TabIndex = 6;
            // 
            // DurationNum
            // 
            DurationNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DurationNum.Location = new Point(418, 100);
            DurationNum.Margin = new Padding(3, 2, 3, 2);
            DurationNum.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            DurationNum.Name = "DurationNum";
            DurationNum.Size = new Size(186, 23);
            DurationNum.TabIndex = 5;
            // 
            // CrsBox
            // 
            CrsBox.FormattingEnabled = true;
            CrsBox.Location = new Point(94, 100);
            CrsBox.Margin = new Padding(3, 2, 3, 2);
            CrsBox.Name = "CrsBox";
            CrsBox.Size = new Size(218, 23);
            CrsBox.TabIndex = 4;
            CrsBox.Text = "Choose course";
            // 
            // TFLbl
            // 
            TFLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TFLbl.AutoSize = true;
            TFLbl.BackColor = Color.Transparent;
            TFLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TFLbl.Location = new Point(94, 146);
            TFLbl.Name = "TFLbl";
            TFLbl.Size = new Size(191, 25);
            TFLbl.TabIndex = 3;
            TFLbl.Text = "True or False Number";
            // 
            // MCQlbl
            // 
            MCQlbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MCQlbl.AutoSize = true;
            MCQlbl.BackColor = Color.Transparent;
            MCQlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MCQlbl.Location = new Point(418, 146);
            MCQlbl.Name = "MCQlbl";
            MCQlbl.Size = new Size(129, 25);
            MCQlbl.TabIndex = 2;
            MCQlbl.Text = "MCQ Number";
            // 
            // DurationLbl
            // 
            DurationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DurationLbl.AutoSize = true;
            DurationLbl.BackColor = Color.Transparent;
            DurationLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DurationLbl.Location = new Point(418, 61);
            DurationLbl.Name = "DurationLbl";
            DurationLbl.Size = new Size(86, 25);
            DurationLbl.TabIndex = 1;
            DurationLbl.Text = "Duration";
            // 
            // CourseLbl
            // 
            CourseLbl.AutoSize = true;
            CourseLbl.BackColor = Color.Transparent;
            CourseLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CourseLbl.Location = new Point(94, 61);
            CourseLbl.Name = "CourseLbl";
            CourseLbl.Size = new Size(126, 25);
            CourseLbl.TabIndex = 0;
            CourseLbl.Text = "Course Name";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(CoursesBox);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(679, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Courses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CoursesBox
            // 
            CoursesBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CoursesBox.FormattingEnabled = true;
            CoursesBox.ItemHeight = 15;
            CoursesBox.Location = new Point(103, 4);
            CoursesBox.Margin = new Padding(3, 2, 3, 2);
            CoursesBox.Name = "CoursesBox";
            CoursesBox.Size = new Size(377, 274);
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
            tabPage1.Location = new Point(4, 27);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(711, 303);
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
            SignOutBtn.Location = new Point(535, 263);
            SignOutBtn.Margin = new Padding(3, 2, 3, 2);
            SignOutBtn.Name = "SignOutBtn";
            SignOutBtn.Size = new Size(172, 38);
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
            UpdateBTN.Location = new Point(236, 235);
            UpdateBTN.Margin = new Padding(3, 2, 3, 2);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(204, 36);
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
            DegreeBox.Location = new Point(87, 173);
            DegreeBox.Margin = new Padding(3, 2, 3, 2);
            DegreeBox.Name = "DegreeBox";
            DegreeBox.Size = new Size(209, 23);
            DegreeBox.TabIndex = 8;
            // 
            // SalaryNum
            // 
            SalaryNum.Location = new Point(352, 76);
            SalaryNum.Margin = new Padding(3, 2, 3, 2);
            SalaryNum.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            SalaryNum.Name = "SalaryNum";
            SalaryNum.Size = new Size(198, 23);
            SalaryNum.TabIndex = 7;
            // 
            // DepartmentBox
            // 
            DepartmentBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.Location = new Point(384, 173);
            DepartmentBox.Margin = new Padding(3, 2, 3, 2);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(198, 23);
            DepartmentBox.TabIndex = 6;
            // 
            // NameTXT
            // 
            NameTXT.Location = new Point(87, 76);
            NameTXT.Margin = new Padding(3, 2, 3, 2);
            NameTXT.Name = "NameTXT";
            NameTXT.Size = new Size(209, 23);
            NameTXT.TabIndex = 4;
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.BackColor = Color.Transparent;
            SalaryLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalaryLbl.Location = new Point(352, 48);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(63, 25);
            SalaryLbl.TabIndex = 3;
            SalaryLbl.Text = "Salary";
            // 
            // DegreeLbl
            // 
            DegreeLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DegreeLbl.AutoSize = true;
            DegreeLbl.BackColor = Color.Transparent;
            DegreeLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DegreeLbl.Location = new Point(87, 138);
            DegreeLbl.Name = "DegreeLbl";
            DegreeLbl.Size = new Size(73, 25);
            DegreeLbl.TabIndex = 2;
            DegreeLbl.Text = "Degree";
            // 
            // DepartmentLbl
            // 
            DepartmentLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DepartmentLbl.AutoSize = true;
            DepartmentLbl.BackColor = Color.Transparent;
            DepartmentLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepartmentLbl.Location = new Point(384, 138);
            DepartmentLbl.Name = "DepartmentLbl";
            DepartmentLbl.Size = new Size(112, 25);
            DepartmentLbl.TabIndex = 1;
            DepartmentLbl.Text = "Department";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.BackColor = Color.Transparent;
            NameLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLbl.Location = new Point(87, 48);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(62, 25);
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
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(719, 334);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Location = new Point(4, 27);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(679, 303);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Students";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 346);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
