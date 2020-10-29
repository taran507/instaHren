using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.API.Processors;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
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
        private OpenFileDialog openFile;
        private LoginForm loginForm;
        private InstaImageUpload image;
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
            loginForm = new LoginForm(this);
            loginForm.ShowDialog();
        }

        private void UploadPhoto_Click(object sender, EventArgs e)
        {

        }

        private async void OpenFile_ClickAsync(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.ShowDialog();
            image = new InstaImageUpload
            {
                Height = 0,
                Width = 0,
                Uri = openFile.FileName
            };
            var res = await api.MediaProcessor.UploadPhotoAsync(image,"new");
            listBox1.Items.Add(res.Info);

        }
    }
}
