using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{   
    public partial class Form1 : Form
    {
        Boolean go = false;
        int time;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (time >= 100)
            {
                go = true;
            }
            if (go == true)
            {
                this.Opacity = this.Opacity - 0.05;
                if (this.Opacity <= 0)
                {
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                    time = 0;
                    timer1.Enabled = false;
                }
            }
        }
    }
}
