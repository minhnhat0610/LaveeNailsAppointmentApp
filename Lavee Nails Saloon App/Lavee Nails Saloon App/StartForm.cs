using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Lavee_Nails_Saloon_App
{
    public partial class StartForm : Form
    {
        Form dp = new DatePick();
        Form La = new AppointmentLookUpForm();
        public StartForm()
        {
            InitializeComponent();

        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MorningButton_Click(object sender, EventArgs e)
        {
            dp.StartPosition = this.StartPosition;
            //dp.Location = this.Location;
            dp.Show();
            this.Hide();
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

        private void LookUpAppointmentButton_Click(object sender, EventArgs e)
        {
            La.StartPosition = this.StartPosition;
            La.Show();
            this.Hide();
        }
    }
}
