namespace Lavee_Nails_Saloon_App
{
    partial class AppointmentLookUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentLookUpForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GoBackButton = new Lavee_Nails_Saloon_App.CustomButton();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.LaveeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelAppointment = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackgroundImage = global::Lavee_Nails_Saloon_App.Properties.Resources.back_arrow;
            this.GoBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackButton.FlatAppearance.BorderSize = 0;
            this.GoBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GoBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(35, 35);
            this.GoBackButton.TabIndex = 43;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ExitIcon
            // 
            this.ExitIcon.BackColor = System.Drawing.Color.Transparent;
            this.ExitIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitIcon.BackgroundImage")));
            this.ExitIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.Location = new System.Drawing.Point(869, 12);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(35, 35);
            this.ExitIcon.TabIndex = 44;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // LaveeLabel
            // 
            this.LaveeLabel.AutoSize = true;
            this.LaveeLabel.Font = new System.Drawing.Font("Watermelon Script Demo", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaveeLabel.ForeColor = System.Drawing.Color.White;
            this.LaveeLabel.Location = new System.Drawing.Point(289, 12);
            this.LaveeLabel.Name = "LaveeLabel";
            this.LaveeLabel.Size = new System.Drawing.Size(338, 81);
            this.LaveeLabel.TabIndex = 45;
            this.LaveeLabel.Text = "Lavee Nails";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orchid;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Request,
            this.CancelAppointment});
            this.dataGridView1.GridColor = System.Drawing.Color.Pink;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orchid;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent;
            this.dataGridView1.Size = new System.Drawing.Size(892, 515);
            this.dataGridView1.TabIndex = 46;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 90;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Request
            // 
            this.Request.HeaderText = "Request";
            this.Request.Name = "Request";
            this.Request.Width = 275;
            // 
            // CancelAppointment
            // 
            this.CancelAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAppointment.HeaderText = "";
            this.CancelAppointment.Name = "CancelAppointment";
            this.CancelAppointment.Text = "Cancel";
            this.CancelAppointment.Width = 25;
            // 
            // AppointmentLookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(916, 646);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LaveeLabel);
            this.Controls.Add(this.ExitIcon);
            this.Controls.Add(this.GoBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentLookUpForm";
            this.Text = "AppointmentLookUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton GoBackButton;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.Label LaveeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewButtonColumn CancelAppointment;
    }
}