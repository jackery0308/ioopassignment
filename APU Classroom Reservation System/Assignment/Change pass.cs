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
    public partial class Change_pass : Form
    {
        public Change_pass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id,pass;
            id = unt.Text.ToString();
            pass = passt.Text.ToString();
            account acc = new account();
            if (acc.check_un(id) == "Success")
            {
                acc.changepass(id, pass);
                MessageBox.Show("Your password has been successfully changed.");
                Login lol = new Login();
                lol.Show();
                this.Hide();
            }
            else if (acc.check_un(id) == "Fail")
            {
                MessageBox.Show("Fail to load file.");
            }
            else if (acc.check_un(id) == "Failed")
            {
                MessageBox.Show("The username is not available.");
            }
      
        }
    }
}
