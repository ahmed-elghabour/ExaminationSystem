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

        private void BtnLogin_Click(object sender, EventArgs e)
        {   // watting msg
            LogSuccess("Please wait. Verifying ...");



            // Redirect User Accorting to it's Type
            if ((UserType)this.CBType.SelectedIndex == UserType.Instructor)
            {
                // Validate User
                var user = context?.InstructorLogins?.FirstOrDefault(
                    user =>
                        user.UserName == this.TBUsername.Text.Trim() &&
                        user.Password == this.TBPassword.Text.Trim()
                );

                InstructorForm insForm = new() { ID = user?.InsId ?? -1 };
                insForm.Show();
                this.Hide();
                return;
            }

            if ((UserType)this.CBType.SelectedIndex == UserType.Student)
            {
                // Validate User

                return;
            }

            LogError("Incorrect username or password.");
            //LogError("Undefined Error Occurs! :(");
        }

        void LogError(string msg)
        {
            LMsg.ForeColor = Color.LightCoral;
            LMsg.Text = msg;
        }

        void LogSuccess(string msg)
        {
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
    }
}
