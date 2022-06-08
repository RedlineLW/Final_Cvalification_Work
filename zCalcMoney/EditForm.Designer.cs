namespace zCalcMoney
{
    partial class EditForm
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
            this.roleComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelRole = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.fioBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.b_dayBox = new MetroFramework.Controls.MetroTextBox();
            this.messageLabel = new MetroFramework.Controls.MetroLabel();
            this.brigadaComboBox = new MetroFramework.Controls.MetroComboBox();
            this.empTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // roleComboBox1
            // 
            this.roleComboBox1.FormattingEnabled = true;
            this.roleComboBox1.ItemHeight = 23;
            this.roleComboBox1.Items.AddRange(new object[] {
            "Машинист",
            "Помощник машиниста"});
            this.roleComboBox1.Location = new System.Drawing.Point(124, 91);
            this.roleComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleComboBox1.Name = "roleComboBox1";
            this.roleComboBox1.Size = new System.Drawing.Size(196, 29);
            this.roleComboBox1.TabIndex = 42;
            this.roleComboBox1.UseSelectable = true;
            // 
            // metroLabelRole
            // 
            this.metroLabelRole.AutoSize = true;
            this.metroLabelRole.Location = new System.Drawing.Point(38, 94);
            this.metroLabelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabelRole.Name = "metroLabelRole";
            this.metroLabelRole.Size = new System.Drawing.Size(75, 19);
            this.metroLabelRole.TabIndex = 41;
            this.metroLabelRole.Text = "Должность";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(82, 224);
            this.metroCheckBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(208, 15);
            this.metroCheckBox1.TabIndex = 40;
            this.metroCheckBox1.Text = "Работает на тяж. и длин. составах";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(54, 188);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Бригада";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 129);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Дата рождения";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(67, 61);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "ФИО";
            // 
            // fioBox
            // 
            // 
            // 
            // 
            this.fioBox.CustomButton.Image = null;
            this.fioBox.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.fioBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fioBox.CustomButton.Name = "";
            this.fioBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.fioBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fioBox.CustomButton.TabIndex = 1;
            this.fioBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fioBox.CustomButton.UseSelectable = true;
            this.fioBox.CustomButton.Visible = false;
            this.fioBox.Lines = new string[0];
            this.fioBox.Location = new System.Drawing.Point(124, 61);
            this.fioBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fioBox.MaxLength = 32767;
            this.fioBox.Name = "fioBox";
            this.fioBox.PasswordChar = '\0';
            this.fioBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fioBox.SelectedText = "";
            this.fioBox.SelectionLength = 0;
            this.fioBox.SelectionStart = 0;
            this.fioBox.ShortcutsEnabled = true;
            this.fioBox.Size = new System.Drawing.Size(196, 19);
            this.fioBox.TabIndex = 30;
            this.fioBox.UseSelectable = true;
            this.fioBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fioBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(127, 253);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(79, 24);
            this.metroButton1.TabIndex = 29;
            this.metroButton1.Text = "Сохранить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // b_dayBox
            // 
            // 
            // 
            // 
            this.b_dayBox.CustomButton.Image = null;
            this.b_dayBox.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.b_dayBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_dayBox.CustomButton.Name = "";
            this.b_dayBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.b_dayBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.b_dayBox.CustomButton.TabIndex = 1;
            this.b_dayBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.b_dayBox.CustomButton.UseSelectable = true;
            this.b_dayBox.CustomButton.Visible = false;
            this.b_dayBox.Lines = new string[0];
            this.b_dayBox.Location = new System.Drawing.Point(124, 129);
            this.b_dayBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_dayBox.MaxLength = 32767;
            this.b_dayBox.Name = "b_dayBox";
            this.b_dayBox.PasswordChar = '\0';
            this.b_dayBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.b_dayBox.SelectedText = "";
            this.b_dayBox.SelectionLength = 0;
            this.b_dayBox.SelectionStart = 0;
            this.b_dayBox.ShortcutsEnabled = true;
            this.b_dayBox.Size = new System.Drawing.Size(196, 19);
            this.b_dayBox.TabIndex = 43;
            this.b_dayBox.UseSelectable = true;
            this.b_dayBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.b_dayBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(26, 284);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(297, 30);
            this.messageLabel.TabIndex = 44;
            // 
            // brigadaComboBox
            // 
            this.brigadaComboBox.FormattingEnabled = true;
            this.brigadaComboBox.ItemHeight = 23;
            this.brigadaComboBox.Location = new System.Drawing.Point(124, 186);
            this.brigadaComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brigadaComboBox.Name = "brigadaComboBox";
            this.brigadaComboBox.Size = new System.Drawing.Size(196, 29);
            this.brigadaComboBox.TabIndex = 45;
            this.brigadaComboBox.UseSelectable = true;
            // 
            // empTextBox
            // 
            // 
            // 
            // 
            this.empTextBox.CustomButton.Image = null;
            this.empTextBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.empTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empTextBox.CustomButton.Name = "";
            this.empTextBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.empTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empTextBox.CustomButton.TabIndex = 1;
            this.empTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empTextBox.CustomButton.UseSelectable = true;
            this.empTextBox.CustomButton.Visible = false;
            this.empTextBox.Lines = new string[0];
            this.empTextBox.Location = new System.Drawing.Point(124, 158);
            this.empTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empTextBox.MaxLength = 32767;
            this.empTextBox.Name = "empTextBox";
            this.empTextBox.PasswordChar = '\0';
            this.empTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empTextBox.SelectedText = "";
            this.empTextBox.SelectionLength = 0;
            this.empTextBox.SelectionStart = 0;
            this.empTextBox.ShortcutsEnabled = true;
            this.empTextBox.Size = new System.Drawing.Size(195, 19);
            this.empTextBox.TabIndex = 47;
            this.empTextBox.UseSelectable = true;
            this.empTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 158);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Трудоустроен";
            // 
            // metroLabel11
            // 
            this.metroLabel11.Location = new System.Drawing.Point(210, 7);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(105, 19);
            this.metroLabel11.TabIndex = 48;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 322);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.empTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.brigadaComboBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.b_dayBox);
            this.Controls.Add(this.roleComboBox1);
            this.Controls.Add(this.metroLabelRole);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.fioBox);
            this.Controls.Add(this.metroButton1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Изменение данных";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox roleComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabelRole;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox fioBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox b_dayBox;
        private MetroFramework.Controls.MetroLabel messageLabel;
        private MetroFramework.Controls.MetroComboBox brigadaComboBox;
        private MetroFramework.Controls.MetroTextBox empTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}