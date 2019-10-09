using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavee_Nails_Saloon_App
{
    public partial class ClientInformation : Form
    {

        public ClientInformation()
        {
            InitializeComponent();
        }

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            CheckNull();

            FirstNameTextBox.Text = "";
            FirstNameIcon.Image = Properties.Resources.nameicon1;
            FirstNamePanel.BackColor = Color.MediumVioletRed;

            LastNameIcon.Image = Properties.Resources.nameicon2;
            LastNamePanel.BackColor = Color.White;

            PhoneIcon.Image = Properties.Resources.phoneicon2;
            PhonePanel.BackColor = Color.White;

            EmailIcon.Image = Properties.Resources.emailicon2;
            EmailPanel.BackColor = Color.White;

            NoteLabel.ForeColor = Color.White;
            NotePanel.BackColor = Color.White;
        }

        private void LastNameTextBox_Click(object sender, EventArgs e)
        {
            CheckNull();

            LastNameTextBox.Text = "";
            LastNameIcon.Image = Properties.Resources.nameicon1;
            LastNamePanel.BackColor = Color.MediumVioletRed;

            FirstNameIcon.Image = Properties.Resources.nameicon2;
            FirstNamePanel.BackColor = Color.White;

            PhoneIcon.Image = Properties.Resources.phoneicon2;
            PhonePanel.BackColor = Color.White;

            EmailIcon.Image = Properties.Resources.emailicon2;
            EmailPanel.BackColor = Color.White;

            NoteLabel.ForeColor = Color.White;
            NotePanel.BackColor = Color.White;
        }

        private void PhoneTextBox_Click(object sender, EventArgs e)
        {
            CheckNull();

            PhoneTextBox.Text = "";
            PhoneIcon.Image = Properties.Resources.phoneicon1;
            PhonePanel.BackColor = Color.MediumVioletRed;

            LastNameIcon.Image = Properties.Resources.nameicon2;
            LastNamePanel.BackColor = Color.White;

            FirstNameIcon.Image = Properties.Resources.nameicon2;
            FirstNamePanel.BackColor = Color.White;

            EmailIcon.Image = Properties.Resources.emailicon2;
            EmailPanel.BackColor = Color.White;

            NoteLabel.ForeColor = Color.White;
            NotePanel.BackColor = Color.White;
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            CheckNull();

            EmailTextBox.Text = "";
            EmailIcon.Image = Properties.Resources.emailicon1;
            EmailPanel.BackColor = Color.MediumVioletRed;

            FirstNameIcon.Image = Properties.Resources.nameicon2;
            FirstNamePanel.BackColor = Color.White;

            LastNameIcon.Image = Properties.Resources.nameicon2;
            LastNamePanel.BackColor = Color.White;

            PhoneIcon.Image = Properties.Resources.phoneicon2;
            PhonePanel.BackColor = Color.White;

            NoteLabel.ForeColor = Color.White;
            NotePanel.BackColor = Color.White;
        }

        private void NoteTextBox_Click(object sender, EventArgs e)
        {
            CheckNull();

            NoteLabel.ForeColor = Color.MediumVioletRed;
            NotePanel.BackColor = Color.MediumVioletRed;

            FirstNameIcon.Image = Properties.Resources.nameicon2;
            FirstNamePanel.BackColor = Color.White;

            LastNameIcon.Image = Properties.Resources.nameicon2;
            LastNamePanel.BackColor = Color.White;

            PhoneIcon.Image = Properties.Resources.phoneicon2;
            PhonePanel.BackColor = Color.White;

            EmailIcon.Image = Properties.Resources.emailicon2;
            EmailPanel.BackColor = Color.White;
        }

        
        private void ContinueButton_MouseEnter(object sender, EventArgs e)
        {
            ContinueButton.ForeColor = Color.Fuchsia;
        }

        private void ContinueButton_MouseLeave(object sender, EventArgs e)
        {
            ContinueButton.ForeColor = Color.White;
        }

        private void CheckNull()
        {
            if (FirstNameTextBox.Text == "")
                FirstNameTextBox.Text = "First Name";
            if (LastNameTextBox.Text == "")
                LastNameTextBox.Text = "Last Name";
            if (PhoneTextBox.Text == "")
                PhoneTextBox.Text = "Phone Number";
            if (EmailTextBox.Text == "")
                EmailTextBox.Text = "Email";
        }


        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContinueButton_Enter(object sender, EventArgs e)
        {
            ContinueButton.BackColor = Color.MediumVioletRed;
        }

        private void ContinueButton_Leave(object sender, EventArgs e)
        {
            ContinueButton.BackColor = Color.Fuchsia;
        }

        private void GoBackButton_MouseEnter(object sender, EventArgs e)
        {
            GoBackButton.Width += 10;
            GoBackButton.Height += 10;
        }

        private void GoBackButton_MouseLeave(object sender, EventArgs e)
        {
            GoBackButton.Width -= 10;
            GoBackButton.Height -= 10;
        }

        private void ExitIcon_MouseEnter(object sender, EventArgs e)
        {
            ExitIcon.Width += 5;
            ExitIcon.Height += 5;
        }

        private void ExitIcon_MouseLeave(object sender, EventArgs e)
        {
            ExitIcon.Width -= 5;
            ExitIcon.Height -= 5;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form dp = new DatePick();
            dp.StartPosition = this.StartPosition;
            //dp.Location = this.Location;
            dp.Show();
            this.Hide();
        }
    }

    public class CustomButton : Button
    {
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
