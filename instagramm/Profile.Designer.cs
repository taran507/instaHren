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
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Follovers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoProfile
            // 
            this.PhotoProfile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PhotoProfile.Location = new System.Drawing.Point(24, 27);
            this.PhotoProfile.Name = "PhotoProfile";
            this.PhotoProfile.Size = new System.Drawing.Size(150, 150);
            this.PhotoProfile.TabIndex = 0;
            this.PhotoProfile.TabStop = false;
            // 
            // UploadPhoto
            // 
            this.UploadPhoto.Location = new System.Drawing.Point(545, 374);
            this.UploadPhoto.Name = "UploadPhoto";
            this.UploadPhoto.Size = new System.Drawing.Size(144, 23);
            this.UploadPhoto.TabIndex = 1;
            this.UploadPhoto.Text = "Upload Photo";
            this.UploadPhoto.UseVisualStyleBackColor = true;
            this.UploadPhoto.Click += new System.EventHandler(this.UploadPhoto_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 160);
            this.listBox1.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(695, 374);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 4;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_ClickAsync);
            // 
            // Follovers
            // 
            this.Follovers.AutoSize = true;
            this.Follovers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Follovers.Location = new System.Drawing.Point(269, 27);
            this.Follovers.Name = "Follovers";
            this.Follovers.Size = new System.Drawing.Size(72, 20);
            this.Follovers.TabIndex = 5;
            this.Follovers.Text = "Follovers";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Follovers);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UploadPhoto);
            this.Controls.Add(this.PhotoProfile);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoProfile;
        private System.Windows.Forms.Button UploadPhoto;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label Follovers;
    }
}