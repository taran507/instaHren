namespace instagramm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.logText = new System.Windows.Forms.ListBox();
            this.loginOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(49, 327);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(117, 45);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.loginButtonClick);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(102, 54);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(150, 20);
            this.textLogin.TabIndex = 1;
            this.textLogin.Text = "login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "password";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // logText
            // 
            this.logText.FormattingEnabled = true;
            this.logText.Location = new System.Drawing.Point(102, 208);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(150, 95);
            this.logText.TabIndex = 2;
            this.logText.SelectedIndexChanged += new System.EventHandler(this.logText_SelectedIndexChanged);
            // 
            // loginOut
            // 
            this.loginOut.Location = new System.Drawing.Point(202, 327);
            this.loginOut.Name = "loginOut";
            this.loginOut.Size = new System.Drawing.Size(117, 45);
            this.loginOut.TabIndex = 0;
            this.loginOut.Text = "Out";
            this.loginOut.UseVisualStyleBackColor = true;
            this.loginOut.Click += new System.EventHandler(this.loginOutButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 407);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.loginOut);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "her";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox logText;
        private System.Windows.Forms.Button loginOut;
    }
}

