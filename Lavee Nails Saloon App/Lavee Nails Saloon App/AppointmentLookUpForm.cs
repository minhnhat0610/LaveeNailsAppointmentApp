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
    public partial class AppointmentLookUpForm : Form
    {
        
        public AppointmentLookUpForm()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form sf = new StartForm();
            sf.StartPosition = this.StartPosition;
            sf.Show();
            this.Hide();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
