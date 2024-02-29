/**
 * @title Login Form
 * @author A.Rahman Khallaf
 * @date February 27, 2024 
 * @description Examination System | Login Form
 */

using System.Diagnostics;
using ExaminationSystem.Context;
using ExaminationSystem.Entities;
using ExaminationSystem.Types;

namespace ExaminationSystem
{
    public partial class LoginForm : Form
    {
        ExaminationContext context = new();
        public LoginForm()
        {
            InitializeComponent();
            //Adding Type values to the ComboBox
            foreach (var t in Enum.GetValues(typeof(UserType)))
            {
                this.CBType.Items.Add(t);
            }
            if (this.CBType.Items.Count > 1)
                CBType.SelectedIndex = 0;

            //Dispose Context on Form Closing
            this.FormClosing += (e, v) => context?.Dispose();
        }
        async void login()
        {
            // watting msg
            LogSuccess("Please wait. Verifying ...");
            BtnLogin.Enabled = false;
            BtnLogin.Text = "Loading ...";


            // Validate User
            string username = this.TBUsername.Text.Trim();
            string password = this.TBPassword.Text.Trim();

            // Redirect User Accorting to it's Type
            if ((UserType)this.CBType.SelectedIndex == UserType.Instructor)
            {
                InstructorLogin user = await Task.Run(async () =>
                {
                    return context?.InstructorLogins.FirstOrDefault(
                    user =>
                        user.UserName == username &&
                        user.Password == password
                );
                });

                if (user != null)
                {
                    InstructorForm insForm = new(user?.InsId ?? -1);
                    insForm.Show();
                    this.Hide();
                    return;
                }
            }

            if ((UserType)this.CBType.SelectedIndex == UserType.Student)
            {

                // Validate User

                StudentLogin user = await Task.Run(async () =>
                {
                    return context?.StudentLogins.FirstOrDefault(
                    user =>
                        user.UserName == username &&
                        user.Password == password
                );
                });
                if (user != null)
                {
                    // User Form
                    StudentForm insForm = new(user?.StdId ?? -1);
                    insForm.Show();
                    this.Hide();
                    return;

                }
            }

            //LogError("Undefined Error Occurs! :(");
            LogError("Incorrect username or password.");
            BtnLogin.Text = "Login";
            BtnLogin.Enabled = true;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        void LogError(string msg)
        {
            LMsg.ForeColor = Color.LightCoral;
            Trace.WriteLine(msg);
            //LMsg.Invoke(new Action<string>(UpdateLTimerText), text);
            LMsg.Text = msg;
        }

        void LogSuccess(string msg)
        {
            Trace.WriteLine(msg);
            LMsg.ForeColor = Color.LightGreen;
            LMsg.Text = msg;
        }

        void ResetLMsg()
        {
            LMsg.Text = "";

        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {
            ResetLMsg();
        }

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {
            ResetLMsg();
        }

        private void CBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetLMsg();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TBPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
                e.Handled = true;
            }
        }

        private void TBUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
                e.Handled = true;
            }
        }

        private void CBType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
                e.Handled = true;
            }
        }
    }
}
