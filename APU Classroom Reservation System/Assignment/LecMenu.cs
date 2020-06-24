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
    public partial class LecMenu : Form
    {
        public LecMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.un = un;
            b.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reservation_status rrs = new Reservation_status();
            rrs.un = un;
            rrs.Show();
            this.Hide();
        }

        public string un { get; set; }

        private void LecMenu_Load(object sender, EventArgs e)
        {
            account acc = new account();
            label2.Text = "Welcome, " + acc.name(un);
        }
    }
}
