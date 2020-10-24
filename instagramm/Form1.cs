using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;

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
        private ListBox listBox;

        public LoginForm()
        {
            InitializeComponent();
            user = new UserSessionData();
            user.UserName = userName;
            user.Password = userPassword;
            listBox = logText;
        }

        private async void loginButtonClick(object sender, EventArgs e)
        {
                api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .Build();

            var loginResult = await api.LoginAsync();

            if (loginResult.Succeeded)
            {
                listBox.Items.Add("Log In!");
                Profile profile = new Profile(user, api);
                profile.Show();
                Close();
            }
            else
            {
                listBox.Items.Add("Not Log In!");
            }
            
        }


        private async void loginOutButtonClick(object sender, EventArgs e)
        {
            var outResult = await api.LogoutAsync();
            if (outResult.Succeeded)
            {
                listBox.Items.Add("LogOut!");
            }
        }
    }
}
