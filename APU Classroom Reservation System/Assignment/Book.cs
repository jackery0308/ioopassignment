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
    public partial class Book : Form
    {
        
        public Book()
        {
            InitializeComponent();
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {
            using (OleDbConnection source = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
             Environment.CurrentDirectory + "\\IOOPAssignment.accdb"))
            {
                try
                {
                    OleDbCommand data = new OleDbCommand();
                    source.Open();
                    data.CommandText = "Select distinct Class_ID FROM [Classroom]";
                    data.Connection = source;
                    OleDbDataReader dr = data.ExecuteReader();

                    while  (dr.Read())
                    {
                        classcb.Items.Add(dr[0].ToString ());
                        

                    }
                    source.Close();



                }
                catch
                {
                    MessageBox.Show("Fail to load file");
                    source.Close();
                }
                button1.Enabled = false;



            }
        }
        public string un { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            
            account acc = new account();
            
            if (acc.acctype(un) == "Lecturer")
            {
                LecMenu lec = new LecMenu();
                lec.un = un;
                lec.Show();
                this.Hide();
            }
            else if (acc.acctype(un) == "Student")
            {
                Std_Menu menu1 = new Std_Menu();
                menu1.un = un;
                menu1.Show();
                this.Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                user std = new user();
                string id, time, reason,describe;
            string date;
                id = classcb.SelectedItem.ToString();
                date =  datelist.SelectedItem.ToString();
                time = timelist.SelectedItem.ToString();
                reason = reasont.Text.ToString();
                describe = descript.Text.ToString();
            DateTime dt = DateTime.Today;
            try
            {
                if (addcheck.Checked == true)
                {
                    if (std.bookyes(id, un, date, time, reason, describe).ToString() == "Success" & DateTime.Parse(datelist.SelectedItem.ToString()) >= dt.AddDays(7))
                    {
                        MessageBox.Show("Successfully insert data.");

                    }
                    else if (DateTime.Parse(datelist.SelectedItem.ToString()) < dt.AddDays(7))
                    {
                        MessageBox.Show("You need to reserve before 7 days.");
                    }
                    else if (std.bookyes(id, un, date, time, reason, describe).ToString() == "Fail")
                    {
                        MessageBox.Show("Failed to load file");
                    }
                }
                else if (addcheck.Checked == false)
                {
                    if (std.bookno(id, un, date, time, reason).ToString() == "Success" & DateTime.Parse(datelist.SelectedItem.ToString()) >= dt.AddDays(3))
                    {
                        MessageBox.Show("Successfully to insert data.");
                    }
                    else if (DateTime.Parse(datelist.SelectedItem.ToString()) < dt.AddDays(3))
                    {
                        MessageBox.Show("You need to reserve before 3 days.");
                    }
                    else if (std.bookno(id, un, date, time, reason).ToString() == "Fail")
                    {
                        MessageBox.Show("Failed to load file");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Current System is using wrong date format.\nPlease try to change the date format to MM/dd/yyyy.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id;
           
                id = classcb.SelectedItem.ToString();
                button1.Enabled = true;
            
                
                using (OleDbConnection source = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
              Environment.CurrentDirectory + "\\IOOPAssignment.accdb"))
                {
                    OleDbCommand dates = new OleDbCommand();
                    OleDbCommand unlist = new OleDbCommand();
                    dates.CommandText = "SELECT DISTINCT Class_Date FROM [Classroom] WHERE Availability=Yes AND Class_ID='" + classcb.SelectedItem.ToString() + "'";
                    unlist.CommandText = "SELECT * FROM [Classroom] WHERE Availability=Yes AND Class_ID='" + classcb.SelectedItem.ToString() + "' ORDER BY Time_Slot ASC";
                    source.Open();
                    unlist.Connection = source;
                    dates.Connection = source;
                    OleDbDataReader da = dates.ExecuteReader();
                    OleDbDataReader dr = unlist.ExecuteReader();
                    datelist.Items.Clear();
                    timelist.Items.Clear();
                
                while (da.Read())
                    {
                        DateTime dateeee;
                        dateeee = DateTime.Parse(da[0].ToString());
                        datelist.Items.Add(dateeee.ToString ("MM/dd/yy"));
                   


                }
                    while (dr.Read())
                    {
                        
                        
                        timelist.Items.Add(dr[3].ToString());
                  
                    }
        

            }
         
        }

        private void classcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
