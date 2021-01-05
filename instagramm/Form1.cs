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
        private readonly string userName = "dfsgf.dsfg";//"may_yartr";
        private readonly string userPassword = " pn&1IeXabIA2";//"52364g68";
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
            try
            {
                var res = await api.LoginAsync();
                if (res.Succeeded)
                {
                    profile.api = api;
                    profile.user = user;
                    DialogResult = DialogResult.OK;
                    //this.Close();
                }
                else if (res.Info.ToString() == "Unknown: Challenge is required.")
                {

                    Debug.WriteLine("Error: " + api.GetCurrentDevice().DeviceModel);

                }
                else
                {
                    textBox2.Text = "Error!";
                    MessageBox.Show("Error: " + res.Info);
                }
            }catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        
    }
}
