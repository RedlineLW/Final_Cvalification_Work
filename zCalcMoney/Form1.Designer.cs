namespace zCalcMoney
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.loginBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.passwordBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            // 
            // 
            // 
            this.loginBox.CustomButton.Image = null;
            this.loginBox.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.loginBox.CustomButton.Name = "";
            this.loginBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.loginBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginBox.CustomButton.TabIndex = 1;
            this.loginBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginBox.CustomButton.UseSelectable = true;
            this.loginBox.CustomButton.Visible = false;
            this.loginBox.Lines = new string[0];
            this.loginBox.Location = new System.Drawing.Point(111, 84);
            this.loginBox.MaxLength = 32767;
            this.loginBox.Name = "loginBox";
            this.loginBox.PasswordChar = '\0';
            this.loginBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginBox.SelectedText = "";
            this.loginBox.SelectionLength = 0;
            this.loginBox.SelectionStart = 0;
            this.loginBox.ShortcutsEnabled = true;
            this.loginBox.Size = new System.Drawing.Size(162, 36);
            this.loginBox.TabIndex = 0;
            this.loginBox.UseSelectable = true;
            this.loginBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(83, 172);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(162, 36);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Авторизироваться";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // passwordBox
            // 
            // 
            // 
            // 
            this.passwordBox.CustomButton.Image = null;
            this.passwordBox.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.passwordBox.CustomButton.Name = "";
            this.passwordBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordBox.CustomButton.TabIndex = 1;
            this.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordBox.CustomButton.UseSelectable = true;
            this.passwordBox.CustomButton.Visible = false;
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(111, 130);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(162, 36);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.UseSelectable = true;
            this.passwordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordBox.WaterMarkFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(21, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 36);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Логин";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(21, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 36);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Пароль";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorizationForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(324, 233);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.loginBox);
            this.Name = "AuthorizationForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox loginBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox passwordBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

