using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ePOSOne.btnProduct;
using System.IO;

namespace Lavee_Nails_Saloon_App
{
    public partial class DatePick : Form
    {
        private bool LockMode = false;
        private string AppDate;
        Form c = new ClientInformation();

        StreamReader readFile;
        StreamWriter file;


        public DatePick()
        {
            InitializeComponent();
        }

        private void DatePick_Load(object sender, EventArgs e)
        {            
            readFile = new StreamReader("FullHours.txt");
            AppDate = AppointmentDate.Value.ToShortDateString();
            ReadToFile(MorningTimePanel);
            ReadToFile(AfternoonTimePanel);
            ReadToFile(EveningTimePanel);
            readFile.Close();

            

        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left -= 20;
            MorningTimePanel.Left -= 20;
            if(MorningTimePanel.Left <= 0)
            {
                timer1.Stop();
            }

        }

        private void MorningButton_Click(object sender, EventArgs e)
        {
            MorningTimePanel.Visible = true;
            timer1.Start();

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Left += 20;
            MorningTimePanel.Left += 20;
            if (MorningTimePanel.Left >= this.Width)
            {
                panel1.Left = (this.Width - panel1.Width) / 2;
                MorningTimePanel.Visible = false;
                timer2.Stop();
            }
        }

        private void AfternoonButton_Click(object sender, EventArgs e)
        {
            MorningTimePanel.Visible = false;
            AfternoonTimePanel.Visible = true;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel1.Left -= 20;
            AfternoonTimePanel.Left -= 20;
            if(AfternoonTimePanel.Left <= 0)
            {
                timer3.Stop();
            }
        }

        private void GoBackButton2_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            panel1.Left += 20;
            AfternoonTimePanel.Left += 20;
            if (AfternoonTimePanel.Left >= this.Width)
            {
                panel1.Left = (this.Width - panel1.Width) / 2;
                AfternoonTimePanel.Visible = false;
                timer4.Stop();
            }
        }

        private void EveningButton_Click(object sender, EventArgs e)
        {
            EveningTimePanel.Visible = true;
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            panel1.Left -= 20;
            EveningTimePanel.Left -= 20;
            if(EveningTimePanel.Left <= 20)
            {
                timer5.Stop();
            }
        }

        private void GoBackButton3_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            panel1.Left += 20;
            EveningTimePanel.Left += 20;
            if(EveningTimePanel.Left >= this.Width)
            {
                panel1.Left = (this.Width - panel1.Width) / 2;
                EveningTimePanel.Visible = false;
                timer6.Stop();
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            c.StartPosition = this.StartPosition;
            //c.Location = this.Location;
            c.Show();
            this.Hide();        
        }

        private void GoBackButton4_MouseEnter(object sender, EventArgs e)
        {
            GoBackButton4.Width += 10;
            GoBackButton4.Height += 10;
        }

        private void GoBackButton4_MouseLeave(object sender, EventArgs e)
        {
            GoBackButton4.Width -= 10;
            GoBackButton4.Height -= 10;
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

        private void GoBackButton4_Click(object sender, EventArgs e)
        {
            Form sf = new StartForm();
            sf.StartPosition = this.StartPosition;
            //sf.Location = this.Location;
            sf.Show();
            this.Close();
        }

        private void LockButton1_Click(object sender, EventArgs e)
        {
            if(LockMode)
            {
                LockMode = false;
                LockButton1.BackgroundImage = Properties.Resources.lock2;
            }
            else
            {
                LockMode = true;
                LockButton1.BackgroundImage = Properties.Resources._lock;
            }
            
        }

        private void LockButton2_Click(object sender, EventArgs e)
        {
            if (LockMode)
            {
                LockMode = false;
                LockButton2.BackgroundImage = Properties.Resources.lock2;
            }
            else
            {
                LockMode = true;
                LockButton2.BackgroundImage = Properties.Resources._lock;
            }
        }

        private void LockButton3_Click(object sender, EventArgs e)
        {
            if (LockMode)
            {
                LockMode = false;
                LockButton3.BackgroundImage = Properties.Resources.lock2;
            }
            else
            {
                LockMode = true;
                LockButton3.BackgroundImage = Properties.Resources._lock;
            }
        }

        private void AppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            AppDate = AppointmentDate.Value.ToShortDateString();

            UnlockAllButton();

            readFile = new StreamReader("FullHours.txt");
            ReadToFile(MorningTimePanel);
            ReadToFile(AfternoonTimePanel);
            ReadToFile(EveningTimePanel);
            readFile.Close();


        }

        private void UnlockAllButton()
        {
            LockMode = false;
            foreach(Button button in MorningTimePanel.Controls)
            {
                if(button.GetType().ToString() == "ePOSOne.btnProduct.Button_WOC")
                LockAButton((ePOSOne.btnProduct.Button_WOC)button);
            }

            foreach (Button button in AfternoonTimePanel.Controls)
            {
                if (button.GetType().ToString() == "ePOSOne.btnProduct.Button_WOC")
                    LockAButton((ePOSOne.btnProduct.Button_WOC)button);
            }

            foreach (Button button in EveningTimePanel.Controls)
            {
                if (button.GetType().ToString() == "ePOSOne.btnProduct.Button_WOC")
                    LockAButton((ePOSOne.btnProduct.Button_WOC)button);
            }
        }


        private void WriteToFile(Button button)
        {
            string text = AppDate + " : " + button.Name; ;
            string text2;
            

            if (button.Text == "Full")
            {
                if(FindText(button) != 1)
                {
                    file = new StreamWriter("FullHours.txt", true);
                    file.WriteLine(text);
                }

                file.Close();
            }
            else
            {
                file = new StreamWriter("Tempfile.txt", true);
                readFile = new StreamReader("FullHours.txt");
                readFile.BaseStream.Position = 0;

                do
                {
                    text2 = readFile.ReadLine();
                    if (text2 != text && text2 != null)
                    {
                        file.WriteLine(text2);
                    }
                    else
                    {
                      
                    }
                }

                while (text2 != null);
                file.Close();
                readFile.Close();

                File.Delete("FullHours.txt");
                File.Move("Tempfile.txt", "FullHours.txt");
            }

            
        }

        private int FindText(Button button)
        {
            string text;
            string text2;
            readFile = new StreamReader("FullHours.txt");
            readFile.BaseStream.Position = 0;

            do
            {
                try
                {
                    text = readFile.ReadLine();
                    text2 = text.Substring(0, 9);

                    if (text == null)
                    {
                        readFile.Close();
                        return -1;
                    }
                    else
                    {
                        if (text2 == AppDate)
                        {
                            if (text.Substring(12) == button.Name)
                            {
                                readFile.Close();
                                return 1;
                            }
                        }
                    }
                }

                catch (Exception)
                {
                    break;
                }

            }

            while (text != null);

            readFile.Close();
            return -1;
        }

        private void ReadToFile(Panel panel)
        {
            string text;
            string text2;
            readFile.BaseStream.Position = 0;

            do
            {
                try
                {
                    text = readFile.ReadLine();
                    text2 = text.Substring(0, 9);
                }

                catch (Exception)
                {
                    break;
                }
  
                if (text2 == AppDate)
                {
                    foreach (Button button in panel.Controls)
                    {
                        
                        if (button.Name == text.Substring(12))
                        {
                            LockMode = true;
                            LockAButton((ePOSOne.btnProduct.Button_WOC)button);
                        }
                    }
                }
            }
            while (text != null);

            
        }

        

        private void LockAButton(ePOSOne.btnProduct.Button_WOC Button)
        {
            if (LockMode)
            {
                Button.ButtonColor = Color.Orchid;
                Button.Text = "Full";

                //Write to Full Appointment Hours to File

                LockButton1.BackgroundImage = Properties.Resources.lock2;
                LockButton2.BackgroundImage = Properties.Resources.lock2;
                LockButton3.BackgroundImage = Properties.Resources.lock2;
                LockMode = false;
            } 

            else
            {
                Button.ButtonColor = Color.Fuchsia;
                Button.Text = GenerateButtonName(Button);
                LockButton1.BackgroundImage = Properties.Resources.lock2;
                LockButton2.BackgroundImage = Properties.Resources.lock2;
                LockButton3.BackgroundImage = Properties.Resources.lock2;
                LockMode = false;
            }
        }

        private string GenerateButtonName(Button Button)
        {
            string text = Button.Name.Substring(6);
            string text2;
            int num;
            if(text.Length > 3)
            {
                text = text.Substring(0, 2) + ":" + text.Substring(2) + "am";                
            }

            else
            {
                text2 = text.Substring(0, 1);
                num = Convert.ToInt32(text2);
                if(num >= 9)
                {
                    text = text2 + ":" + text.Substring(1) + "am";
                }
                else
                {
                    text = text2 + ":" + text.Substring(1) + "pm";
                }
            }

            return text;
        }

        private void Button1200_Click(object sender, EventArgs e)
        {
            LockAButton(Button1200);
            WriteToFile(Button1200);

        }

        private void Button100_Click(object sender, EventArgs e)
        {
            LockAButton(Button100);
            WriteToFile(Button100);
        }

        private void Button1000_Click(object sender, EventArgs e)
        {
            LockAButton(Button1000);
            WriteToFile(Button1000);
        }

        private void Button1015_Click(object sender, EventArgs e)
        {
            LockAButton(Button1015);
            WriteToFile(Button1015);
        }

        private void Button1030_Click(object sender, EventArgs e)
        {
            LockAButton(Button1030);
            WriteToFile(Button1030);
        }

        private void Button1045_Click(object sender, EventArgs e)
        {
            LockAButton(Button1045);
            WriteToFile(Button1045);
        }

        private void Button1100_Click(object sender, EventArgs e)
        {
            LockAButton(Button1100);
            WriteToFile(Button1100);
        }

        private void Button1115_Click(object sender, EventArgs e)
        {
            LockAButton(Button1115);
            WriteToFile(Button1115);
        }

        private void Button1130_Click(object sender, EventArgs e)
        {
            LockAButton(Button1130);
            WriteToFile(Button1130);
        }

        private void Button1145_Click(object sender, EventArgs e)
        {
            LockAButton(Button1145);
            WriteToFile(Button1145);
        }

        private void Button115_Click(object sender, EventArgs e)
        {
            LockAButton(Button115);
            WriteToFile(Button115);
        }

        private void Button1215_Click(object sender, EventArgs e)
        {
            LockAButton(Button1215);
            WriteToFile(Button1215);
        }

        private void Button1230_Click(object sender, EventArgs e)
        {
            LockAButton(Button1230);
            WriteToFile(Button1230);
        }

        private void Button1245_Click(object sender, EventArgs e)
        {
            LockAButton(Button1245);
            WriteToFile(Button1245);
        }

        private void Button130_Click(object sender, EventArgs e)
        {
            LockAButton(Button130);
            WriteToFile(Button130);
        }

        private void Button145_Click(object sender, EventArgs e)
        {
            LockAButton(Button145);
            WriteToFile(Button145);
        }

        private void Button200_Click(object sender, EventArgs e)
        {
            LockAButton(Button200);
            WriteToFile(Button200);

        }

        private void Button215_Click(object sender, EventArgs e)
        {
            LockAButton(Button215);
            WriteToFile(Button215);
        }

        private void Button230_Click(object sender, EventArgs e)
        {
            LockAButton(Button230);
            WriteToFile(Button230);
        }

        private void Button245_Click(object sender, EventArgs e)
        {
            LockAButton(Button245);
            WriteToFile(Button245);
        }

        private void Button300_Click(object sender, EventArgs e)
        {
            LockAButton(Button300);
            WriteToFile(Button300);
        }

        private void Button315_Click(object sender, EventArgs e)
        {
            LockAButton(Button315);
            WriteToFile(Button315);
        }

        private void Button330_Click(object sender, EventArgs e)
        {
            LockAButton(Button330);
            WriteToFile(Button330);
        }

        private void Button345_Click(object sender, EventArgs e)
        {
            LockAButton(Button345);
            WriteToFile(Button345);
        }

        private void Button400_Click(object sender, EventArgs e)
        {
            LockAButton(Button400);
            WriteToFile(Button400);
        }

        private void Button415_Click(object sender, EventArgs e)
        {
            LockAButton(Button415);
            WriteToFile(Button415);
        }

        private void Button430_Click(object sender, EventArgs e)
        {
            LockAButton(Button430);
            WriteToFile(Button430);
        }

        private void Button445_Click(object sender, EventArgs e)
        {
            LockAButton(Button445);
            WriteToFile(Button445);
        }

        private void Button500_Click(object sender, EventArgs e)
        {
            LockAButton(Button500);
            WriteToFile(Button500);
        }

        private void Button515_Click(object sender, EventArgs e)
        {
            LockAButton(Button515);
            WriteToFile(Button515);
        }

        private void Button530_Click(object sender, EventArgs e)
        {
            LockAButton(Button530);
            WriteToFile(Button530);
        }

        private void Button545_Click(object sender, EventArgs e)
        {
            LockAButton(Button545);
            WriteToFile(Button545);
        }

        private void Button600_Click(object sender, EventArgs e)
        {
            LockAButton(Button600);
            WriteToFile(Button600);
        }

        private void Button615_Click(object sender, EventArgs e)
        {
            LockAButton(Button615);
            WriteToFile(Button615);
        }

        private void Button630_Click(object sender, EventArgs e)
        {
            LockAButton(Button630);
            WriteToFile(Button630);
        }

        private void Button645_Click(object sender, EventArgs e)
        {
            LockAButton(Button645);
            WriteToFile(Button645);
        }

        private void Button700_Click(object sender, EventArgs e)
        {
            LockAButton(Button700);
            WriteToFile(Button700);
        }

        private void Button715_Click(object sender, EventArgs e)
        {
            LockAButton(Button715);
            WriteToFile(Button715);
        }

        private void Button730_Click(object sender, EventArgs e)
        {
            LockAButton(Button730);
            WriteToFile(Button730);
        }

        private void Button900_Click(object sender, EventArgs e)
        {
            LockAButton(Button900);
            WriteToFile(Button900);
        }

        private void Button915_Click(object sender, EventArgs e)
        {
            LockAButton(Button915);
            WriteToFile(Button915);
        }

        private void Button930_Click(object sender, EventArgs e)
        {
            LockAButton(Button930);
            WriteToFile(Button930);
        }

        private void Button945_Click(object sender, EventArgs e)
        {
            LockAButton(Button945);
            WriteToFile(Button945);
        }

        
    }

    public class Button_WOC : Button
    {
        private Color _borderColor = Color.Silver;
        private Color _onHoverBorderColor = Color.Gray;
        private Color _buttonColor = Color.Red;
        private Color _onHoverButtonColor = Color.Yellow;
        private Color _textColor = Color.White;
        private Color _onHoverTextColor = Color.Gray;

        private bool _isHovering;
        private int _borderThickness = 6;
        private int _borderThicknessByTwo = 3;


        public Button_WOC()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };
        }




        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_isHovering ? _onHoverBorderColor : _borderColor);

            //Border
            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, Width - Height, 0, Height, Height);
            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);

            //Inner part. Button itself
            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness,
                Height - _borderThickness);
            g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo,
                Height - _borderThickness, Height - _borderThickness);
            g.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo,
                Width - Height - _borderThickness, Height - _borderThickness);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);

            //Button Text
            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }


        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public Color OnHoverBorderColor
        {
            get => _onHoverBorderColor;
            set
            {
                _onHoverBorderColor = value;
                Invalidate();
            }
        }

        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }
    }
}
