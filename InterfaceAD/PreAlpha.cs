using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePowShell
{
    public partial class PreAlpha : Form
    {
        public PreAlpha()
        {
            InitializeComponent();
            // timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            /*
            MainPage frm = new MainPage();
            frm.Show();

            this.Hide();
            timer1.Stop();
            */
        }
        int i = 10;
        private void Timer_countdown_Tick(object sender, EventArgs e)
        {
            /*
            if (label_countdown.Text == "0 Seconds")
            {
                timer_countdown.Stop();
            }
            i--;
            label_countdown.Text = i.ToString() + " " + "Seconds";
            */
        }
    }
}