namespace zCalcMoney
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.buhButton = new MetroFramework.Controls.MetroButton();
            this.kadrButton = new MetroFramework.Controls.MetroButton();
            this.brigButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(249, 6);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 23);
            this.metroLabel7.TabIndex = 22;
            // 
            // buhButton
            // 
            this.buhButton.Location = new System.Drawing.Point(33, 100);
            this.buhButton.Name = "buhButton";
            this.buhButton.Size = new System.Drawing.Size(225, 30);
            this.buhButton.TabIndex = 23;
            this.buhButton.Text = "Перейти к окну бухгалтера";
            this.buhButton.UseSelectable = true;
            this.buhButton.Click += new System.EventHandler(this.buhButton_Click);
            // 
            // kadrButton
            // 
            this.kadrButton.Location = new System.Drawing.Point(33, 143);
            this.kadrButton.Name = "kadrButton";
            this.kadrButton.Size = new System.Drawing.Size(225, 30);
            this.kadrButton.TabIndex = 24;
            this.kadrButton.Text = "Перейди к окну кадров";
            this.kadrButton.UseSelectable = true;
            this.kadrButton.Click += new System.EventHandler(this.kadrButton_Click);
            // 
            // brigButton
            // 
            this.brigButton.Location = new System.Drawing.Point(33, 188);
            this.brigButton.Name = "brigButton";
            this.brigButton.Size = new System.Drawing.Size(225, 30);
            this.brigButton.TabIndex = 25;
            this.brigButton.Text = "Перейти к окну бригадира";
            this.brigButton.UseSelectable = true;
            this.brigButton.Click += new System.EventHandler(this.brigButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 36);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.brigButton);
            this.Controls.Add(this.kadrButton);
            this.Controls.Add(this.buhButton);
            this.Controls.Add(this.metroLabel7);
            this.Name = "AdminForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton buhButton;
        private MetroFramework.Controls.MetroButton kadrButton;
        private MetroFramework.Controls.MetroButton brigButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}