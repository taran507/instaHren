using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.API.Processors;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
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
        private IResult<InstaUserInfo> profile = null;
        public Profile()
        {
            InitializeComponent();
            if (user == null)
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
            UsrInfo();
            Thread.Sleep(1000);
            PhotoProfile.ImageLocation = profile.Value.ProfilePicUrl;
            Follovers.Text = "Follovers: "+profile.Value.FollowerCount;
            Folloving.Text = "Folloving: " + profile.Value.FollowingCount;
            Post.Text = "Post: " + profile.Value.MediaCount;
        }
        
        
        private async void Login()
        {
            user = new UserSessionData();
            user.UserName = userName;
            user.Password = userPassword;

            api = InstaApiBuilder.CreateBuilder().SetUser(user).Build();
            var res = await api.LoginAsync();
            Debug.WriteLine("Log in "+res.Info);

        }
        private async void UsrInfo()
        {
            profile = await api.UserProcessor.GetUserInfoByUsernameAsync("taran507");  
        }

        private async  void Exit_Click(object sender, EventArgs e)
        {
            var logoutres = await api.LogoutAsync();
            loginForm = new LoginForm(this);
            loginForm.ShowDialog();
        }

        private async void UploadPhoto_Click(object sender, EventArgs e) //
        {
            var res = await api.MediaProcessor.UploadPhotoAsync(image, "new"); //так выглядит загрузка фото
            listBox1.Items.Add(res.Info);
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
            listBox1.Items.Add(openFile.FileName);
        }
    }
}
