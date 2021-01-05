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
        private InstaImageUpload image;

        public UploadPhoto(Files files)
        {
            InitializeComponent();
            this.files = files;
        }

        private void Open_file_botton_Click(object sender, EventArgs e)
        {
            openFile = openFileDialog1;
            openFile.ShowDialog();
            foreach (string file in openFile.FileNames)
            {
                files.filePath.Add(file);
            }
            files.caption = richTextBox1.Text;
            pictureBox1.ImageLocation = files.filePath.Last();
        }

        private void Upload_photo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
