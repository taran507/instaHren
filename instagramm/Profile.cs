using InstagramApiSharp.API;
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
        public Profile(UserSessionData user, IInstaApi api)
        {
            InitializeComponent();
            if (api.IsUserAuthenticated) { 
                listBox1.Items.Add("Log In"); }
            PhotoProfile.Image = Image.FromFile("C:\\Users\\taran\\Pictures\\ghjdthrf\\_MG_6341.jpg");
        }
        public Profile()
        {
            InitializeComponent();
        }
        private void Profile_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
