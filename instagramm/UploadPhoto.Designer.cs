namespace instagramm
{
    partial class UploadPhoto
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
            System.Windows.Forms.GroupBox groupBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadPhoto));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Open_file_botton = new System.Windows.Forms.Button();
            this.Upload_photo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PhotoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Пост = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhotoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoEllipsis = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Location = new System.Drawing.Point(4, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "История";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoEllipsis = true;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox2.Location = new System.Drawing.Point(4, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 16);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Карусель";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoEllipsis = true;
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox3.Location = new System.Drawing.Point(4, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(92, 16);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Видео";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Open_file_botton
            // 
            this.Open_file_botton.BackColor = System.Drawing.Color.DodgerBlue;
            this.Open_file_botton.ForeColor = System.Drawing.Color.White;
            this.Open_file_botton.Location = new System.Drawing.Point(377, 321);
            this.Open_file_botton.Name = "Open_file_botton";
            this.Open_file_botton.Size = new System.Drawing.Size(75, 23);
            this.Open_file_botton.TabIndex = 1;
            this.Open_file_botton.Text = "Open file";
            this.Open_file_botton.UseVisualStyleBackColor = false;
            this.Open_file_botton.Click += new System.EventHandler(this.Open_file_botton_Click);
            // 
            // Upload_photo
            // 
            this.Upload_photo.BackColor = System.Drawing.Color.DodgerBlue;
            this.Upload_photo.ForeColor = System.Drawing.Color.White;
            this.Upload_photo.Location = new System.Drawing.Point(377, 350);
            this.Upload_photo.Name = "Upload_photo";
            this.Upload_photo.Size = new System.Drawing.Size(75, 23);
            this.Upload_photo.TabIndex = 2;
            this.Upload_photo.Text = "Ok";
            this.Upload_photo.UseVisualStyleBackColor = false;
            this.Upload_photo.Click += new System.EventHandler(this.Upload_photo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Corbel Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 66);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Tag = "comment";
            this.richTextBox1.Text = "Комментарий...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // PhotoPanel
            // 
            this.PhotoPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.PhotoPanel.ColumnCount = 2;
            this.PhotoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.24419F));
            this.PhotoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.75581F));
            this.PhotoPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.PhotoPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.PhotoPanel.Location = new System.Drawing.Point(12, 12);
            this.PhotoPanel.Name = "PhotoPanel";
            this.PhotoPanel.RowCount = 8;
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PhotoPanel.Size = new System.Drawing.Size(332, 289);
            this.PhotoPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.PhotoPanel.SetRowSpan(this.pictureBox1, 8);
            this.pictureBox1.Size = new System.Drawing.Size(284, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Пост
            // 
            this.Пост.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Пост.Location = new System.Drawing.Point(4, 99);
            this.Пост.Name = "Пост";
            this.Пост.Size = new System.Drawing.Size(92, 16);
            this.Пост.TabIndex = 11;
            this.Пост.Text = "Пост";
            this.Пост.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Пост.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.checkBox1);
            groupBox1.Controls.Add(this.Пост);
            groupBox1.Controls.Add(this.checkBox2);
            groupBox1.Controls.Add(this.checkBox3);
            groupBox1.Enabled = false;
            groupBox1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(359, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(102, 129);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(360, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // UploadPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 389);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PhotoPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Upload_photo);
            this.Controls.Add(this.Open_file_botton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadPhoto";
            this.Text = "Instagram Poster";
            this.PhotoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button Open_file_botton;
        private System.Windows.Forms.Button Upload_photo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel PhotoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox Пост;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}