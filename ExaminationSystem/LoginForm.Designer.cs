namespace ExaminationSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            BtnLogin = new Button();
            label1 = new Label();
            TBUsername = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            TBPassword = new TextBox();
            label5 = new Label();
            CBType = new ComboBox();
            LMsg = new Label();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(49, 123, 209);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(447, 448);
            BtnLogin.Margin = new Padding(3, 4, 3, 4);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(283, 60);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 123, 209);
            label1.Location = new Point(466, 37);
            label1.Name = "label1";
            label1.Size = new Size(256, 49);
            label1.TabIndex = 1;
            label1.Text = "Login Account";
            // 
            // TBUsername
            // 
            TBUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBUsername.Location = new Point(447, 155);
            TBUsername.Margin = new Padding(3, 4, 3, 4);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(283, 39);
            TBUsername.TabIndex = 0;
            TBUsername.TextChanged += TBUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 170, 173);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 557);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(49, 123, 209);
            label3.Location = new Point(447, 113);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(49, 123, 209);
            label4.Location = new Point(447, 215);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // TBPassword
            // 
            TBPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBPassword.Location = new Point(447, 256);
            TBPassword.Margin = new Padding(3, 4, 3, 4);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(283, 39);
            TBPassword.TabIndex = 1;
            TBPassword.TextChanged += TBPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(49, 123, 209);
            label5.Location = new Point(447, 316);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 8;
            label5.Text = "Type";
            // 
            // CBType
            // 
            CBType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBType.FormattingEnabled = true;
            CBType.Location = new Point(447, 356);
            CBType.Margin = new Padding(3, 4, 3, 4);
            CBType.Name = "CBType";
            CBType.Size = new Size(283, 40);
            CBType.TabIndex = 2;
            CBType.SelectedIndexChanged += CBType_SelectedIndexChanged;
            // 
            // LMsg
            // 
            LMsg.AutoSize = true;
            LMsg.ForeColor = Color.LightCoral;
            LMsg.Location = new Point(450, 413);
            LMsg.Name = "LMsg";
            LMsg.Size = new Size(0, 20);
            LMsg.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(787, 555);
            Controls.Add(LMsg);
            Controls.Add(CBType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TBPassword);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(TBUsername);
            Controls.Add(BtnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Examination System | Login";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private Label label1;
        private TextBox TBUsername;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private TextBox TBPassword;
        private Label label5;
        private ComboBox CBType;
        private Label LMsg;
    }
}
