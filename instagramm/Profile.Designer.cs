namespace instagramm
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PhotoProfile = new System.Windows.Forms.PictureBox();
            this.UploadPhoto = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoProfile
            // 
            this.PhotoProfile.Location = new System.Drawing.Point(24, 27);
            this.PhotoProfile.Name = "PhotoProfile";
            this.PhotoProfile.Size = new System.Drawing.Size(150, 150);
            this.PhotoProfile.TabIndex = 0;
            this.PhotoProfile.TabStop = false;
            // 
            // UploadPhoto
            // 
            this.UploadPhoto.Location = new System.Drawing.Point(309, 374);
            this.UploadPhoto.Name = "UploadPhoto";
            this.UploadPhoto.Size = new System.Drawing.Size(144, 23);
            this.UploadPhoto.TabIndex = 1;
            this.UploadPhoto.Text = "Upload Photo";
            this.UploadPhoto.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(387, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UploadPhoto);
            this.Controls.Add(this.PhotoProfile);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Activated += new System.EventHandler(this.Profile_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoProfile;
        private System.Windows.Forms.Button UploadPhoto;
        private System.Windows.Forms.ListBox listBox1;
    }
}