using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace instagramm
{
    public partial class Profile : Form
    {
        #region Hidden
        private readonly string userName = "may_yartr";
        private readonly string userPassword = "52364g68";
        #endregion
        public UserSessionData user { get; set; }
        public IInstaApi api { get; set; }

        LoginForm loginForm;
        public Profile()
        {
            InitializeComponent();
            if (user==null)
            {
                loginForm = new LoginForm(this);
                loginForm.ShowDialog();
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    listBox1.Items.Add("user: " + user.UserName);
                    listBox1.Items.Add("password: " + user.Password);

                }
            }
            else
            {
                Login();
            }
        }
        /*private void Profile_Activated(object sender, EventArgs e)
        {
            
        }*/
        private async void Login()
        {
            user = new UserSessionData();
            user.UserName = userName;
            user.Password = userPassword;

            api = InstaApiBuilder.CreateBuilder().SetUser(user).Build();
            var res = await api.LoginAsync();
            Debug.WriteLine("Log in "+res.Info);

        }

        private async  void Exit_Click(object sender, EventArgs e)
        {
            var logoutres = await api.LogoutAsync();
            Debug.WriteLine("LogoutRes: " + logoutres.Info);
        }
    }
}
