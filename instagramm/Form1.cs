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
        }

        private async void loginButtonClick(object sender, EventArgs e)
        {
            

            if (loginResult.Succeeded)
            {
                
            }
            else
            {
                
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
