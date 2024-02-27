namespace ExaminationSystem
{
    partial class ExamForm
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
            panel1 = new Panel();
            LSubject = new Label();
            LAcademicYear = new Label();
            LProggress = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            BTNNextQuestion = new Button();
            BTNPreviousQuestion = new Button();
            panel2 = new Panel();
            LQuestChoices4 = new Label();
            label6 = new Label();
            label1 = new Label();
            LQuestChoices3 = new Label();
            TBQustionHeader = new TextBox();
            RBQuestChoices4 = new RadioButton();
            RBQuestChoices3 = new RadioButton();
            RBQuestChoices2 = new RadioButton();
            RBQuestChoices1 = new RadioButton();
            PanelQustionShortcut = new Panel();
            BTNSubmit = new Button();
            panel4 = new Panel();
            PanelProgressBar = new Panel();
            label3 = new Label();
            LStudentName = new Label();
            panel3 = new Panel();
            CBFlag = new CheckBox();
            label7 = new Label();
            LTimer = new Label();
            textBox1 = new TextBox();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 123, 209);
            panel1.Controls.Add(LSubject);
            panel1.Controls.Add(LAcademicYear);
            panel1.Controls.Add(LProggress);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 37);
            panel1.TabIndex = 0;
            // 
            // LSubject
            // 
            LSubject.AutoSize = true;
            LSubject.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LSubject.ForeColor = Color.White;
            LSubject.Location = new Point(79, 6);
            LSubject.Name = "LSubject";
            LSubject.Size = new Size(34, 25);
            LSubject.TabIndex = 5;
            LSubject.Text = "CS";
            // 
            // LAcademicYear
            // 
            LAcademicYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LAcademicYear.AutoSize = true;
            LAcademicYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LAcademicYear.ForeColor = Color.White;
            LAcademicYear.Location = new Point(873, 6);
            LAcademicYear.Name = "LAcademicYear";
            LAcademicYear.Size = new Size(99, 25);
            LAcademicYear.TabIndex = 4;
            LAcademicYear.Text = "2023/2024";
            // 
            // LProggress
            // 
            LProggress.Anchor = AnchorStyles.Top;
            LProggress.AutoSize = true;
            LProggress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LProggress.ForeColor = Color.White;
            LProggress.Location = new Point(496, 6);
            LProggress.Name = "LProggress";
            LProggress.Size = new Size(59, 25);
            LProggress.TabIndex = 3;
            LProggress.Text = "15/20";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(815, 6);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 2;
            label5.Text = "Year:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(400, 6);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 1;
            label4.Text = "Proggress:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 0;
            label2.Text = "Subject: ";
            // 
            // BTNNextQuestion
            // 
            BTNNextQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTNNextQuestion.BackColor = Color.FromArgb(49, 123, 209);
            BTNNextQuestion.Cursor = Cursors.Hand;
            BTNNextQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNNextQuestion.ForeColor = Color.White;
            BTNNextQuestion.Location = new Point(600, 376);
            BTNNextQuestion.Name = "BTNNextQuestion";
            BTNNextQuestion.Size = new Size(81, 42);
            BTNNextQuestion.TabIndex = 1;
            BTNNextQuestion.Text = "Next";
            BTNNextQuestion.UseVisualStyleBackColor = false;
            BTNNextQuestion.Click += BTNNextQuestion_Click;
            // 
            // BTNPreviousQuestion
            // 
            BTNPreviousQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTNPreviousQuestion.BackColor = Color.FromArgb(49, 123, 209);
            BTNPreviousQuestion.Cursor = Cursors.Hand;
            BTNPreviousQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNPreviousQuestion.ForeColor = Color.White;
            BTNPreviousQuestion.Location = new Point(513, 377);
            BTNPreviousQuestion.Name = "BTNPreviousQuestion";
            BTNPreviousQuestion.Size = new Size(81, 41);
            BTNPreviousQuestion.TabIndex = 0;
            BTNPreviousQuestion.Text = "Previous";
            BTNPreviousQuestion.UseVisualStyleBackColor = false;
            BTNPreviousQuestion.Click += BTNPreviousQuestion_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(LQuestChoices4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(LQuestChoices3);
            panel2.Controls.Add(TBQustionHeader);
            panel2.Controls.Add(RBQuestChoices4);
            panel2.Controls.Add(RBQuestChoices3);
            panel2.Controls.Add(RBQuestChoices2);
            panel2.Controls.Add(RBQuestChoices1);
            panel2.Location = new Point(12, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 283);
            panel2.TabIndex = 2;
            // 
            // LQuestChoices4
            // 
            LQuestChoices4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LQuestChoices4.Location = new Point(19, 220);
            LQuestChoices4.Name = "LQuestChoices4";
            LQuestChoices4.Size = new Size(32, 36);
            LQuestChoices4.TabIndex = 12;
            LQuestChoices4.Text = "D-";
            LQuestChoices4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 135);
            label6.Name = "label6";
            label6.Size = new Size(26, 36);
            label6.TabIndex = 11;
            label6.Text = "B-";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 87);
            label1.Name = "label1";
            label1.Size = new Size(32, 36);
            label1.TabIndex = 10;
            label1.Text = "A-";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LQuestChoices3
            // 
            LQuestChoices3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LQuestChoices3.Location = new Point(25, 180);
            LQuestChoices3.Name = "LQuestChoices3";
            LQuestChoices3.Size = new Size(26, 36);
            LQuestChoices3.TabIndex = 9;
            LQuestChoices3.Text = "C-";
            LQuestChoices3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TBQustionHeader
            // 
            TBQustionHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBQustionHeader.BackColor = Color.White;
            TBQustionHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBQustionHeader.Location = new Point(17, 14);
            TBQustionHeader.Multiline = true;
            TBQustionHeader.Name = "TBQustionHeader";
            TBQustionHeader.ReadOnly = true;
            TBQustionHeader.ScrollBars = ScrollBars.Vertical;
            TBQustionHeader.Size = new Size(635, 59);
            TBQustionHeader.TabIndex = 5;
            // 
            // RBQuestChoices4
            // 
            RBQuestChoices4.Cursor = Cursors.Hand;
            RBQuestChoices4.Font = new Font("Segoe UI", 12F);
            RBQuestChoices4.Location = new Point(54, 224);
            RBQuestChoices4.Name = "RBQuestChoices4";
            RBQuestChoices4.Size = new Size(590, 34);
            RBQuestChoices4.TabIndex = 4;
            RBQuestChoices4.TabStop = true;
            RBQuestChoices4.Text = "radioButton4";
            RBQuestChoices4.UseVisualStyleBackColor = true;
            RBQuestChoices4.CheckedChanged += RBQuestChoices4_CheckedChanged;
            // 
            // RBQuestChoices3
            // 
            RBQuestChoices3.Cursor = Cursors.Hand;
            RBQuestChoices3.Font = new Font("Segoe UI", 12F);
            RBQuestChoices3.Location = new Point(54, 182);
            RBQuestChoices3.Name = "RBQuestChoices3";
            RBQuestChoices3.Size = new Size(590, 36);
            RBQuestChoices3.TabIndex = 3;
            RBQuestChoices3.TabStop = true;
            RBQuestChoices3.Text = "radioButton3";
            RBQuestChoices3.UseVisualStyleBackColor = true;
            RBQuestChoices3.CheckedChanged += RBQuestChoices3_CheckedChanged;
            // 
            // RBQuestChoices2
            // 
            RBQuestChoices2.Cursor = Cursors.Hand;
            RBQuestChoices2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBQuestChoices2.Location = new Point(54, 134);
            RBQuestChoices2.Name = "RBQuestChoices2";
            RBQuestChoices2.Size = new Size(590, 42);
            RBQuestChoices2.TabIndex = 2;
            RBQuestChoices2.TabStop = true;
            RBQuestChoices2.Text = "radioButton2";
            RBQuestChoices2.UseVisualStyleBackColor = true;
            RBQuestChoices2.CheckedChanged += RBQuestChoices2_CheckedChanged;
            // 
            // RBQuestChoices1
            // 
            RBQuestChoices1.Cursor = Cursors.Hand;
            RBQuestChoices1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBQuestChoices1.Location = new Point(54, 88);
            RBQuestChoices1.Name = "RBQuestChoices1";
            RBQuestChoices1.Size = new Size(590, 40);
            RBQuestChoices1.TabIndex = 1;
            RBQuestChoices1.TabStop = true;
            RBQuestChoices1.Text = "radioButton1";
            RBQuestChoices1.UseVisualStyleBackColor = true;
            RBQuestChoices1.CheckedChanged += RBQuestChoices1_CheckedChanged;
            // 
            // PanelQustionShortcut
            // 
            PanelQustionShortcut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelQustionShortcut.AutoScroll = true;
            PanelQustionShortcut.AutoScrollMinSize = new Size(10, 0);
            PanelQustionShortcut.BackColor = Color.White;
            PanelQustionShortcut.Location = new Point(2, 2);
            PanelQustionShortcut.MaximumSize = new Size(286, 279);
            PanelQustionShortcut.MinimumSize = new Size(286, 279);
            PanelQustionShortcut.Name = "PanelQustionShortcut";
            PanelQustionShortcut.Padding = new Padding(5);
            PanelQustionShortcut.Size = new Size(286, 279);
            PanelQustionShortcut.TabIndex = 3;
            // 
            // BTNSubmit
            // 
            BTNSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTNSubmit.Cursor = Cursors.Hand;
            BTNSubmit.Location = new Point(873, 44);
            BTNSubmit.Name = "BTNSubmit";
            BTNSubmit.Size = new Size(104, 31);
            BTNSubmit.TabIndex = 4;
            BTNSubmit.Text = "Submit";
            BTNSubmit.UseVisualStyleBackColor = true;
            BTNSubmit.Click += BTNSubmit_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(PanelProgressBar);
            panel4.Location = new Point(9, 431);
            panel4.Name = "panel4";
            panel4.Size = new Size(968, 19);
            panel4.TabIndex = 5;
            // 
            // PanelProgressBar
            // 
            PanelProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelProgressBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelProgressBar.BackColor = Color.FromArgb(255, 192, 128);
            PanelProgressBar.Location = new Point(0, 0);
            PanelProgressBar.Name = "PanelProgressBar";
            PanelProgressBar.Size = new Size(20, 19);
            PanelProgressBar.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 47);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 6;
            label3.Text = "Name: ";
            // 
            // LStudentName
            // 
            LStudentName.AutoSize = true;
            LStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LStudentName.Location = new Point(59, 47);
            LStudentName.Name = "LStudentName";
            LStudentName.Size = new Size(135, 21);
            LStudentName.TabIndex = 7;
            LStudentName.Text = "Mohamed Ahmed";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(49, 123, 209);
            panel3.Controls.Add(PanelQustionShortcut);
            panel3.Location = new Point(685, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 283);
            panel3.TabIndex = 8;
            // 
            // CBFlag
            // 
            CBFlag.Appearance = Appearance.Button;
            CBFlag.Cursor = Cursors.Hand;
            CBFlag.Location = new Point(12, 379);
            CBFlag.Name = "CBFlag";
            CBFlag.Size = new Size(104, 41);
            CBFlag.TabIndex = 10;
            CBFlag.Text = "Flag";
            CBFlag.TextAlign = ContentAlignment.MiddleCenter;
            CBFlag.UseVisualStyleBackColor = true;
            CBFlag.CheckedChanged += CBFlag_CheckedChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(687, 385);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 11;
            label7.Text = "Time: ";
            // 
            // LTimer
            // 
            LTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LTimer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTimer.Location = new Point(755, 379);
            LTimer.Name = "LTimer";
            LTimer.Size = new Size(217, 39);
            LTimer.TabIndex = 12;
            LTimer.Text = "00:00:00";
            LTimer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(963, 48);
            textBox1.TabIndex = 13;
            textBox1.Text = "Notes:\r\nAdd Your Temp notes Here It will be removed after the end of the exam.";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(49, 123, 209);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(9, 456);
            panel5.Name = "panel5";
            panel5.Size = new Size(968, 51);
            panel5.TabIndex = 14;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 511);
            Controls.Add(panel5);
            Controls.Add(LTimer);
            Controls.Add(label7);
            Controls.Add(CBFlag);
            Controls.Add(panel3);
            Controls.Add(LStudentName);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(BTNSubmit);
            Controls.Add(panel2);
            Controls.Add(BTNPreviousQuestion);
            Controls.Add(BTNNextQuestion);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 550);
            Name = "ExamForm";
            Text = "Exam Form";
            FormClosing += ExamForm_FormClosing;
            Load += ExamForm_Load;
            SizeChanged += ExamForm_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BTNNextQuestion;
        private Button BTNPreviousQuestion;
        private Panel panel2;
        private Panel PanelQustionShortcut;
        private Button BTNSubmit;
        private RadioButton RBQuestChoices4;
        private RadioButton RBQuestChoices3;
        private RadioButton RBQuestChoices2;
        private RadioButton RBQuestChoices1;
        private Panel panel4;
        private Panel PanelProgressBar;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label LSubject;
        private Label LAcademicYear;
        private Label LProggress;
        private Label LStudentName;
        private Panel panel3;
        private TextBox TBQustionHeader;
        private CheckBox CBFlag;
        private Label label8;
        private Label LQuestChoices3;
        private Label LQuestChoices4;
        private Label label6;
        private Label label1;
        private Label label7;
        private Label LTimer;
        private TextBox textBox1;
        private Panel panel5;
    }
}