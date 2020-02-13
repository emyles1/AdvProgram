using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        SqlConnection conn;
        string rdr;
        public Login()
        {
            //Look at this implementation between Form 1 and AddCustomerForm. Guessing that this needs to be only initalized once then passed to the rest
            //at this moment its initialized on the Form 1 form and here on the login form
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["orderline"].ConnectionString);
            //this.conn = conn;

            btnRefresh.Visible = false;
            dataGridView1.Visible = false;
            groupBox1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string username = txtUName.Text;
            string password = txtPass.Text;

            try
            {
                conn.Open();
                /* MessageBox.Show("Connected");
                 SqlCommand cmd = new SqlCommand("SELECT password FROM Admin where Username = " +
                     "VALUES(@username)", conn);
                 cmd.Parameters.AddWithValue("@username", txtUName.Text);
                 string rdr = (string)cmd.ExecuteScalar();
                 MessageBox.Show("Name: " + rdr);*/

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT Password FROM Admin where Username = '"+ username +"'";
                cmd.Connection = conn;
                rdr = (string)cmd.ExecuteScalar();
               // MessageBox.Show("Pass: " + rdr);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
            finally
            {
                conn.Close();
            }


            if (rdr == txtPass.Text)
            {
                
                groupBox1.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Please try Again");
            }
        }

        private void btnDataHis_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnRefresh.Visible = true;
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            new AddStudent(conn).ShowDialog();
        }



        private void btnEditStudent_Click(object sender, EventArgs e)
        {
          
            new AddStudent(conn).ShowDialog();
           


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new AddStudent(conn).ShowDialog();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //sql connection object
               // using (SqlConnection conn = new SqlConnection(conn))
                {

                    //retrieve the SQL Server instance version
                    string query = @"SELECT * FROM Student;";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnXmlStud_Click(object sender, EventArgs e)
        {
            new StudXML(conn).ShowDialog();
        }
    }
}
    
