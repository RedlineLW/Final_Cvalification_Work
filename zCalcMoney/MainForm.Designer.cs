namespace zCalcMoney
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.hourBox = new MetroFramework.Controls.MetroTextBox();
            this.hourNightBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.holHoursBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.checkBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.checkBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.checkBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.Location = new System.Drawing.Point(23, 112);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(323, 20);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.Text = "Помощник машиниста";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.Checked = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(23, 76);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(323, 20);
            this.metroRadioButton2.TabIndex = 1;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "Машинист";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(23, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(182, 36);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Дневные часы";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourBox
            // 
            // 
            // 
            // 
            this.hourBox.CustomButton.Image = null;
            this.hourBox.CustomButton.Location = new System.Drawing.Point(101, 2);
            this.hourBox.CustomButton.Name = "";
            this.hourBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.hourBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hourBox.CustomButton.TabIndex = 1;
            this.hourBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hourBox.CustomButton.UseSelectable = true;
            this.hourBox.CustomButton.Visible = false;
            this.hourBox.Lines = new string[0];
            this.hourBox.Location = new System.Drawing.Point(211, 138);
            this.hourBox.MaxLength = 32767;
            this.hourBox.Name = "hourBox";
            this.hourBox.PasswordChar = '\0';
            this.hourBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hourBox.SelectedText = "";
            this.hourBox.SelectionLength = 0;
            this.hourBox.SelectionStart = 0;
            this.hourBox.ShortcutsEnabled = true;
            this.hourBox.Size = new System.Drawing.Size(135, 36);
            this.hourBox.TabIndex = 3;
            this.hourBox.UseSelectable = true;
            this.hourBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hourBox.WaterMarkFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // hourNightBox
            // 
            // 
            // 
            // 
            this.hourNightBox.CustomButton.Image = null;
            this.hourNightBox.CustomButton.Location = new System.Drawing.Point(101, 2);
            this.hourNightBox.CustomButton.Name = "";
            this.hourNightBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.hourNightBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hourNightBox.CustomButton.TabIndex = 1;
            this.hourNightBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hourNightBox.CustomButton.UseSelectable = true;
            this.hourNightBox.CustomButton.Visible = false;
            this.hourNightBox.Lines = new string[0];
            this.hourNightBox.Location = new System.Drawing.Point(211, 180);
            this.hourNightBox.MaxLength = 32767;
            this.hourNightBox.Name = "hourNightBox";
            this.hourNightBox.PasswordChar = '\0';
            this.hourNightBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hourNightBox.SelectedText = "";
            this.hourNightBox.SelectionLength = 0;
            this.hourNightBox.SelectionStart = 0;
            this.hourNightBox.ShortcutsEnabled = true;
            this.hourNightBox.Size = new System.Drawing.Size(135, 36);
            this.hourNightBox.TabIndex = 5;
            this.hourNightBox.UseSelectable = true;
            this.hourNightBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hourNightBox.WaterMarkFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(23, 180);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(182, 36);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Ночные часы";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // holHoursBox
            // 
            // 
            // 
            // 
            this.holHoursBox.CustomButton.Image = null;
            this.holHoursBox.CustomButton.Location = new System.Drawing.Point(101, 2);
            this.holHoursBox.CustomButton.Name = "";
            this.holHoursBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.holHoursBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.holHoursBox.CustomButton.TabIndex = 1;
            this.holHoursBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.holHoursBox.CustomButton.UseSelectable = true;
            this.holHoursBox.CustomButton.Visible = false;
            this.holHoursBox.Lines = new string[0];
            this.holHoursBox.Location = new System.Drawing.Point(211, 222);
            this.holHoursBox.MaxLength = 32767;
            this.holHoursBox.Name = "holHoursBox";
            this.holHoursBox.PasswordChar = '\0';
            this.holHoursBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.holHoursBox.SelectedText = "";
            this.holHoursBox.SelectionLength = 0;
            this.holHoursBox.SelectionStart = 0;
            this.holHoursBox.ShortcutsEnabled = true;
            this.holHoursBox.Size = new System.Drawing.Size(135, 36);
            this.holHoursBox.TabIndex = 7;
            this.holHoursBox.UseSelectable = true;
            this.holHoursBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.holHoursBox.WaterMarkFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(23, 222);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(182, 36);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Праздничные часы";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(308, 76);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(169, 30);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Сотрудник";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(445, 76);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(332, 30);
            this.metroComboBox1.TabIndex = 10;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 272);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(145, 36);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Рассчитать";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 314);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(145, 36);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Сохранить в базу";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(185, 272);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(592, 36);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Сумма: ";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(23, 398);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(145, 36);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Изменить коэф-ы";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(352, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(425, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Премия за выслугу лет";
            this.checkBox1.UseSelectable = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(352, 231);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(425, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Премия за безаварийность";
            this.checkBox2.UseSelectable = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(352, 254);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(425, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Премия за работу на тяж. и длинносоставных поездах";
            this.checkBox3.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(185, 314);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(592, 36);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(352, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(425, 92);
            this.listBox1.TabIndex = 19;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(23, 356);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(145, 36);
            this.metroButton4.TabIndex = 20;
            this.metroButton4.Text = "База данных";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(661, 7);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 23);
            this.metroLabel7.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(710, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 36);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.holHoursBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.hourNightBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Расчёт заработной платы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox hourBox;
        private MetroFramework.Controls.MetroTextBox hourNightBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox holHoursBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroCheckBox checkBox1;
        private MetroFramework.Controls.MetroCheckBox checkBox2;
        private MetroFramework.Controls.MetroCheckBox checkBox3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}