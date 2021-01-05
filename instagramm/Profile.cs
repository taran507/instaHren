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
        private LoginForm loginForm;
        private UploadPhoto uploadPhotoForm;
        private IResult<InstaUserInfo> profile = null;
        private Files files;
        public Profile()
        {
            InitializeComponent();
            Loadform();
        }
        private void Loadform()
        {
            loginForm = new LoginForm(this);
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK)
            {
                UsrInfo();
                Thread.Sleep(1000);
                PhotoProfile.ImageLocation = profile.Value.ProfilePicUrl;
                Follovers.Text = "Follovers: " + profile.Value.FollowerCount;
                Folloving.Text = "Folloving: " + profile.Value.FollowingCount;
                Post.Text = "Post: " + profile.Value.MediaCount;
            }
            else
            {
                this.Close();
            }
        }
        private async void UsrInfo()
        {
            profile = await api.UserProcessor.GetUserInfoByUsernameAsync(user.UserName);  
        }

        private async  void Exit_Click(object sender, EventArgs e)
        {
            var logoutres = await api.LogoutAsync();
            loginForm = new LoginForm(this);
            loginForm.ShowDialog();
        }

        private async void UploadPhoto(object sender, EventArgs e) //
        {
            /*var res = await api.MediaProcessor.UploadPhotoAsync(image, "new"); //так выглядит загрузка фото
            listBox1.Items.Add(res.Info);*/
        }


        private void OpenFile_Click(object sender, EventArgs e)
        {
            files = new Files();
            uploadPhotoForm = new UploadPhoto(files);
            uploadPhotoForm.ShowDialog();

            if (uploadPhotoForm.DialogResult == DialogResult.OK)
            {
                foreach (string file in files.filePath)
                {
                    //pictureBox1.ImageLocation = file;
                }
                richTextBox1.Text = files.caption;
                pictureBox1.ImageLocation = files.filePath.Last();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            api.LogoutAsync();
            Loadform();
        }
    }
}
