namespace zCalcMoney
{
    partial class AddForm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.fioBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.messageLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRole = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.brigadaComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(156, 317);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 30);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Добавить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // fioBox
            // 
            // 
            // 
            // 
            this.fioBox.CustomButton.Image = null;
            this.fioBox.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.fioBox.CustomButton.Name = "";
            this.fioBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fioBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fioBox.CustomButton.TabIndex = 1;
            this.fioBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fioBox.CustomButton.UseSelectable = true;
            this.fioBox.CustomButton.Visible = false;
            this.fioBox.Lines = new string[0];
            this.fioBox.Location = new System.Drawing.Point(166, 80);
            this.fioBox.MaxLength = 32767;
            this.fioBox.Name = "fioBox";
            this.fioBox.PasswordChar = '\0';
            this.fioBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fioBox.SelectedText = "";
            this.fioBox.SelectionLength = 0;
            this.fioBox.SelectionStart = 0;
            this.fioBox.ShortcutsEnabled = true;
            this.fioBox.Size = new System.Drawing.Size(261, 23);
            this.fioBox.TabIndex = 1;
            this.fioBox.UseSelectable = true;
            this.fioBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fioBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(90, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ФИО";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(166, 160);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(261, 30);
            this.metroDateTime1.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Дата рождения";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(73, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Бригада";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(106, 289);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(226, 17);
            this.metroCheckBox1.TabIndex = 13;
            this.metroCheckBox1.Text = "Работает на тяж. и длин. составах";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(41, 357);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(375, 20);
            this.messageLabel.TabIndex = 14;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Location = new System.Drawing.Point(267, 7);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(140, 23);
            this.metroLabel11.TabIndex = 25;
            // 
            // metroLabelRole
            // 
            this.metroLabelRole.AutoSize = true;
            this.metroLabelRole.Location = new System.Drawing.Point(51, 121);
            this.metroLabelRole.Name = "metroLabelRole";
            this.metroLabelRole.Size = new System.Drawing.Size(81, 20);
            this.metroLabelRole.TabIndex = 27;
            this.metroLabelRole.Text = "Должность";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Машинист",
            "Помощник машиниста"});
            this.metroComboBox1.Location = new System.Drawing.Point(166, 117);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(260, 30);
            this.metroComboBox1.TabIndex = 28;
            this.metroComboBox1.UseSelectable = true;
            // 
            // brigadaComboBox
            // 
            this.brigadaComboBox.FormattingEnabled = true;
            this.brigadaComboBox.ItemHeight = 24;
            this.brigadaComboBox.Location = new System.Drawing.Point(167, 203);
            this.brigadaComboBox.Name = "brigadaComboBox";
            this.brigadaComboBox.Size = new System.Drawing.Size(260, 30);
            this.brigadaComboBox.TabIndex = 29;
            this.brigadaComboBox.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(33, 248);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 20);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Трудоустроен";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(165, 243);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(261, 30);
            this.metroDateTime2.TabIndex = 32;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 393);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.brigadaComboBox);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabelRole);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.fioBox);
            this.Controls.Add(this.metroButton1);
            this.Name = "AddForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox fioBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel messageLabel;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabelRole;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox brigadaComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
    }
}