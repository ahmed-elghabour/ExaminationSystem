using System.Diagnostics;
//using BLL.Context;
//using BLL.Entities;

namespace ExaminationSystem
{
    public partial class LoginForm : Form
    {
        //HotelManagementSystemContext context = new();
        public LoginForm()
        {
            InitializeComponent();
            // Adding Type values to the ComboBox
            //foreach (var t in Enum.GetValues(typeof(UserType)))
            //{
            //    this.CBType.Items.Add(t);
            //}
            //if (this.CBType.Items.Count > 1)
            //    CBType.SelectedIndex = 0;

            // Dispose Context on Form Closing
            //this.FormClosing += (e, v) => context?.Dispose();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {   // watting msg
            LogSuccess("Please wait. Verifying ...");

            // Searh User
            //User? user = context?.Users?.FirstOrDefault(
            //    user =>
            //        user.Username == this.TBUsername.Text.Trim() &&
            //        user.Password == this.TBPassword.Text.Trim() &&
            //        user.Type == (UserType)this.CBType.SelectedIndex
            //);

            //// Validate User
            //if (user == null)
            //{
            //    LogError("Incorrect username or password.");
            //    return;
            //}

            //// Redirect User Accorting to it's Type
            //if (user.Type == UserType.Frontend)
            //{
            //    return;
            //}

            //if (user.Type == UserType.Frontend)
            //{
            //    //return;
            //}
            LogError("Undefined Error Occurs! :(");
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
    }
}
