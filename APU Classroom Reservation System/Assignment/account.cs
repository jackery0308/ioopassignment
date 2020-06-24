using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Assignment
{

    public class account
    {
        

        public string check_acc(string id, string pass)
        {
            using (OleDbConnection source = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            Environment.CurrentDirectory + "\\IOOPAssignment.accdb"))
            {
                try
                {

                    OleDbCommand unlist = new OleDbCommand();
                    source.Open();
                    unlist.CommandText = "SELECT * FROM [User] WHERE User_ID='" + id + "'";
                    unlist.Connection = source;
                    OleDbDataReader dr = unlist.ExecuteReader();
                    
                    if (dr.Read())
                    {
                        if (pass == dr[3].ToString())
                        {
                            return dr[2].ToString();
                        }
                        else
                        {

                            return "GG";
                        }
                    }
                    else
                    {
                        return "GG";
                        
                    }

                }
                catch
                {

                    return "Fail";///File GG
                 
                }

            }

        }

        public string check_un(string id)
        {
            using (OleDbConnection source = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            Environment.CurrentDirectory + "\\IOOPAssignment.accdb"))
            {
                try
                {

                    OleDbCommand unlist = new OleDbCommand();
                    source.Open();
                    unlist.CommandText = "SELECT * FROM [User] WHERE User_ID='" + id + "'";
                    unlist.Connection = source;
                    OleDbDataReader dr = unlist.ExecuteReader();
                    
                    if (dr.Read())
                    {
                        return "Success";
                
                    }
                    else
                    {
                        return "Failed";
             
                    }

                }
                catch
                {
                    return "Fail";///File gg
                 
                }
            }
        }

        public void changepass(string id, string pass)
        {
            using (OleDbConnection source = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
       Environment.CurrentDirectory + "\\IOOPAssignment.accdb"))
            {
                try
                {
                    
                    OleDbCommand cmdup = new OleDbCommand();
                    source.Open();
                    cmdup.CommandText = "UPDATE [User] SET [User_Password]=\'" + pass + "\' WHERE [User_ID]=\'" + id + "\'; ";
                    cmdup.CommandType = System.Data.CommandType.Text;
                    cmdup.Connection = source;
                    cmdup.ExecuteNonQuery();
                    
                }
                catch
                {
                    MessageBox.Show("Fail to load file.");
                    source.Close();
                }

            }
        }

        public string name(string id)
        {
            using (OleDbConnection source = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            Environment.CurrentDirectory + "\\IOOPAssignment.accdb"))
            {
                try
                {

                    OleDbCommand unlist = new OleDbCommand();
                    source.Open();
                    unlist.CommandText = "SELECT * FROM [User] WHERE User_ID='" + id + "'";
                    unlist.Connection = source;
                    OleDbDataReader dr = unlist.ExecuteReader();
                    
                    if (dr.Read())
                    {
                       
                        return dr[1].ToString();
               
                    }
                    else
                    {
                        return "GG";
               
                    }

                }
                catch
                {

                    return "Fail";///File GG
                  
                }

            }

        }

        public string acctype(string id)
        {
            using (OleDbConnection source = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            Environment.CurrentDirectory + "\\IOOPAssignment.accdb"))
            {
                try
                {

                    OleDbCommand unlist = new OleDbCommand();
                    source.Open();
                    unlist.CommandText = "SELECT * FROM [User] WHERE User_ID='" + id + "'";
                    unlist.Connection = source;
                    OleDbDataReader dr = unlist.ExecuteReader();
                    
                    if (dr.Read())
                    {
                        return dr[2].ToString ();
                  

                    }
                    else
                    {
                        return "Failed";
                    
                    }

                }
                catch
                {
                    return "Fail";///File gg
             
                }
            }
        }


    }
}
