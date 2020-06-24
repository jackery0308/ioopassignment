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
    public partial class Login : Form
    {
        string pass, un;
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Change_pass cpass = new Change_pass();
            cpass.Show();
            this.Hide();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            un = unt.Text;
            pass = passt.Text;
            account acc = new account();
            

            name= acc.name(un);
            
            if (acc.check_acc(un, pass) == "Lecturer")
            {              
                LecMenu lec = new LecMenu();
                lec.un = unt.Text;
                lec.Show();
                this.Hide();
            }
            else if (acc.check_acc(un, pass) == "Student")
            {
                Std_Menu menu1 = new Std_Menu();
                menu1.un = unt.Text;
                menu1.Show();
                this.Hide();
            }
            else if (acc.check_acc(un, pass) == "Scheduler")
            {
                SdlMenu sdl = new SdlMenu();
                sdl.un = unt.Text;
                sdl.Show();
                this.Hide();
            }
            else if (acc.check_acc(un, pass) == "GG")
            {
                MessageBox.Show("Incorrect user ID or Password.");
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
