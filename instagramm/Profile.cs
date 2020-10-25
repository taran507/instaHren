using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instagramm
{
    public partial class Profile : Form
    {
        private static UserSessionData user;
        private static IInstaApi api;
        public Profile()
        {
            InitializeComponent();
            user = new UserSessionData();

            PhotoProfile.Image = Image.FromFile("C:\\Users\\taran\\Pictures\\ghjdthrf\\_MG_6341.jpg");
        }
        private void Profile_Activated(object sender, EventArgs e)
        {
            
        }
        public async Task<IResult<InstaLoginResult>> LoginSucceded(UserSessionData user1)
        {
            api = InstaApiBuilder.CreateBuilder().SetUser(user1).Build();
            var loginRes = await api.LoginAsync();
            return loginRes;
            
        }
    }
}
