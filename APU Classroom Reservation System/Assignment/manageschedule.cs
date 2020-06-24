using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Assignment
{
    public partial class manageschedule : Form
    {
        OleDbConnection source;
        OleDbDataAdapter adp;
        DataSet ds;
        OleDbCommandBuilder build;
        public manageschedule()
        {
            InitializeComponent();
        }

        public string un { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            SdlMenu sm = new SdlMenu();
            sm.un = un;
            sm.Show();
            this.Hide();
        }

        private void manageschedule_Load(object sender, EventArgs e)
        {
            try
            {
                source = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                  Environment.CurrentDirectory + "\\IOOPAssignment.accdb");

                source.Open();
                adp = new OleDbDataAdapter("SELECT * FROM [Classroom] ", source);
                build = new OleDbCommandBuilder(adp);
                ds = new DataSet();
                adp.Fill(ds);
                roomtable.DataSource = ds.Tables[0];



            }
            catch
            {
                MessageBox.Show("Fail to load file.");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommandBuilder hi = new OleDbCommandBuilder(adp);
                adp.Update(ds.Tables[0]);
                MessageBox.Show("Data updated successfully.");
            }
            catch
            {
                MessageBox.Show("Failed to load file.");
            }

        }
    }
}
