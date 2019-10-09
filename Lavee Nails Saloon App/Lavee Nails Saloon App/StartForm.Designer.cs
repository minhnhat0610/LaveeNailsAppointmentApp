namespace Lavee_Nails_Saloon_App
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.LaveeLabel = new System.Windows.Forms.Label();
            this.PickYourDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoPicturebox = new System.Windows.Forms.PictureBox();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.LookUpAppointmentButton = new Lavee_Nails_Saloon_App.CustomButton();
            this.BookAppointmentButton = new Lavee_Nails_Saloon_App.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LaveeLabel
            // 
            this.LaveeLabel.AutoSize = true;
            this.LaveeLabel.Font = new System.Drawing.Font("Watermelon Script Demo", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaveeLabel.ForeColor = System.Drawing.Color.White;
            this.LaveeLabel.Location = new System.Drawing.Point(33, 89);
            this.LaveeLabel.Name = "LaveeLabel";
            this.LaveeLabel.Size = new System.Drawing.Size(338, 81);
            this.LaveeLabel.TabIndex = 26;
            this.LaveeLabel.Text = "Lavee Nails";
            // 
            // PickYourDateLabel
            // 
            this.PickYourDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickYourDateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickYourDateLabel.ForeColor = System.Drawing.Color.White;
            this.PickYourDateLabel.Location = new System.Drawing.Point(20, 186);
            this.PickYourDateLabel.Name = "PickYourDateLabel";
            this.PickYourDateLabel.Size = new System.Drawing.Size(365, 36);
            this.PickYourDateLabel.TabIndex = 29;
            this.PickYourDateLabel.Text = "You Are Welcome To Our Saloon";
            this.PickYourDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "What Would You Like Today ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoPicturebox
            // 
            this.LogoPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPicturebox.BackgroundImage")));
            this.LogoPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPicturebox.Location = new System.Drawing.Point(165, 12);
            this.LogoPicturebox.Name = "LogoPicturebox";
            this.LogoPicturebox.Size = new System.Drawing.Size(75, 74);
            this.LogoPicturebox.TabIndex = 27;
            this.LogoPicturebox.TabStop = false;
            // 
            // ExitIcon
            // 
            this.ExitIcon.BackColor = System.Drawing.Color.Transparent;
            this.ExitIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitIcon.BackgroundImage")));
            this.ExitIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.Location = new System.Drawing.Point(358, 12);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(35, 35);
            this.ExitIcon.TabIndex = 25;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            this.ExitIcon.MouseEnter += new System.EventHandler(this.ExitIcon_MouseEnter);
            this.ExitIcon.MouseLeave += new System.EventHandler(this.ExitIcon_MouseLeave);
            // 
            // LookUpAppointmentButton
            // 
            this.LookUpAppointmentButton.BackColor = System.Drawing.Color.Fuchsia;
            this.LookUpAppointmentButton.FlatAppearance.BorderSize = 0;
            this.LookUpAppointmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LookUpAppointmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.LookUpAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LookUpAppointmentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.LookUpAppointmentButton.Location = new System.Drawing.Point(48, 493);
            this.LookUpAppointmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.LookUpAppointmentButton.Name = "LookUpAppointmentButton";
            this.LookUpAppointmentButton.Size = new System.Drawing.Size(308, 45);
            this.LookUpAppointmentButton.TabIndex = 37;
            this.LookUpAppointmentButton.Text = "Look Up Appointments";
            this.LookUpAppointmentButton.UseVisualStyleBackColor = false;
            this.LookUpAppointmentButton.Click += new System.EventHandler(this.LookUpAppointmentButton_Click);
            // 
            // BookAppointmentButton
            // 
            this.BookAppointmentButton.BackColor = System.Drawing.Color.Fuchsia;
            this.BookAppointmentButton.FlatAppearance.BorderSize = 0;
            this.BookAppointmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BookAppointmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.BookAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookAppointmentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.BookAppointmentButton.Location = new System.Drawing.Point(48, 355);
            this.BookAppointmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.BookAppointmentButton.Name = "BookAppointmentButton";
            this.BookAppointmentButton.Size = new System.Drawing.Size(308, 45);
            this.BookAppointmentButton.TabIndex = 36;
            this.BookAppointmentButton.Text = "Book An Appointment";
            this.BookAppointmentButton.UseVisualStyleBackColor = false;
            this.BookAppointmentButton.Click += new System.EventHandler(this.MorningButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(405, 706);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LookUpAppointmentButton);
            this.Controls.Add(this.BookAppointmentButton);
            this.Controls.Add(this.PickYourDateLabel);
            this.Controls.Add(this.LogoPicturebox);
            this.Controls.Add(this.LaveeLabel);
            this.Controls.Add(this.ExitIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.PictureBox LogoPicturebox;
        private System.Windows.Forms.Label LaveeLabel;
        private System.Windows.Forms.Label PickYourDateLabel;
        private CustomButton BookAppointmentButton;
        private CustomButton LookUpAppointmentButton;
        private System.Windows.Forms.Label label1;
    }
}