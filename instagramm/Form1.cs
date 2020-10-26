using System;
using System.Diagnostics;
using System.Windows.Forms;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;

namespace instagramm
{
    public partial class LoginForm : Form
    {
        #region Hidden
        private readonly string userName = "may_yartr";
        private readonly string userPassword = "52364g68";
        #endregion
        private static UserSessionData user;
        private static IInstaApi api;
        private Profile profile;
        public LoginForm(Profile profile)
        {
            InitializeComponent();
            this.profile = profile;
            user = new UserSessionData();
            user.UserName = userName;
            user.Password = userPassword;
        }

        private async void loginButtonClick(object sender, EventArgs e)
        {
            api = InstaApiBuilder.CreateBuilder().SetUser(user).Build();
            var res = await api.LoginAsync();
            if (res.Succeeded)
            {
                profile.api = api;
                profile.user = user;
                DialogResult = DialogResult.OK;
            }
            else
            {
                textBox2.Text = "Error!";
                Debug.WriteLine("Error: " + res.Info);
            }
        }
        
    }
}
