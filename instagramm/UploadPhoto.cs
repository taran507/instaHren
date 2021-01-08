using InstagramApiSharp.Classes.Models;
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
    public partial class UploadPhoto : Form
    {
        private OpenFileDialog openFile;
        private Files files;

        public UploadPhoto(Files files)
        {
            InitializeComponent();
            this.files = files;
            dateTimePicker1.CustomFormat = "dd,MM-HH:mm";
        }

        private async void Open_file_botton_Click(object sender, EventArgs e)
        {
            openFile = openFileDialog1;
            openFile.ShowDialog();
            await Show_pictures(openFile.FileNames);
        }
        private Task Show_pictures(string[] photos)
        {
            bool i = true;
            foreach (string file in photos)
            {
                files.filePath.Add(file);
                if (i)
                {
                    pictureBox1.Image = Image.FromFile(file);
                    i = false;
                }
                tableLayoutPanel1.Controls.Add(new PictureBox()
                {
                    Image = Image.FromFile(file),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill,
                });
            }
            return Task.CompletedTask;
        }
        private void Upload_photo_Click(object sender, EventArgs e)
        {
            files.caption = richTextBox1.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
