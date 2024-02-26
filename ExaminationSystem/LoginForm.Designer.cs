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
            BtnLogin.Location = new Point(391, 336);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(248, 45);
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
            label1.Location = new Point(408, 28);
            label1.Name = "label1";
            label1.Size = new Size(202, 39);
            label1.TabIndex = 1;
            label1.Text = "Login Account";
            // 
            // TBUsername
            // 
            TBUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBUsername.Location = new Point(391, 116);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(248, 33);
            TBUsername.TabIndex = 0;
            TBUsername.TextChanged += TBUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 86);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 170, 173);
            panel1.BackgroundImage = Properties.Resources.loginBg;
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 418);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(49, 123, 209);
            label3.Location = new Point(391, 85);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(49, 123, 209);
            label4.Location = new Point(391, 161);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // TBPassword
            // 
            TBPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBPassword.Location = new Point(391, 192);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(248, 33);
            TBPassword.TabIndex = 1;
            TBPassword.TextChanged += TBPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(49, 123, 209);
            label5.Location = new Point(391, 237);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 8;
            label5.Text = "Type";
            // 
            // CBType
            // 
            CBType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBType.FormattingEnabled = true;
            CBType.Location = new Point(391, 267);
            CBType.Name = "CBType";
            CBType.Size = new Size(248, 33);
            CBType.TabIndex = 2;
            CBType.SelectedIndexChanged += CBType_SelectedIndexChanged;
            // 
            // LMsg
            // 
            LMsg.AutoSize = true;
            LMsg.ForeColor = Color.LightCoral;
            LMsg.Location = new Point(394, 310);
            LMsg.Name = "LMsg";
            LMsg.Size = new Size(0, 15);
            LMsg.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 416);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management System | Login";
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
