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
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        SqlConnection conn;
        string rdr;
        String LogTransaction = "";
        Logger log = new Logger();
        public Login()
        {
            //Look at this implementation between Form 1 and AddCustomerForm. Guessing that this needs to be only initalized once then passed to the rest
            //at this moment its initialized on the Form 1 form and here on the login form
            InitializeComponent();
           
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["orderline"].ConnectionString);
            
            rtextLogger.Text = File.ReadAllText(@"C: \Users\eamon\Desktop\Logger.txt");
            btnRefresh.Visible = false;
            
            groupBox1.Visible = false;
            rtextLogger.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string username = txtUName.Text;
            string password = txtPass.Text;

            if (btnLogin.Text == "Logout")
            {
                
                groupBox1.Visible = false;
                rtextLogger.Visible = false;
                btnRefresh.Visible = false;
                btnLogin.Text = "Login";
                LogTransaction = String.Format("Transaction Date: {0} | User: {1}  | Logged Off", DateTime.Now, txtUName.Text);
                log.LogDB(LogTransaction);
                conn.Close();
            }
            else

            try
                {
                    using (SqlCommand cmd = new SqlCommand("returnPassword", conn))
                    {
                        conn.Open();

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", txtUName.Text);


                        //cmd.Connection = conn;
                        rdr = (string)cmd.ExecuteScalar();

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
            finally
            {

                    if (rdr == txtPass.Text)
                    {

                        groupBox1.Visible = true;
                        btnLogin.Text = "Logout";
                        LogTransaction = String.Format("Transaction Date: {0} | User: {1}  | Logged On", DateTime.Now, txtUName.Text);
                        log.LogDB(LogTransaction);

                    }
                    else
                    {
                        MessageBox.Show("Please Try Again");
                        LogTransaction = String.Format("Transaction Date: {0} | User: {1}  | Attempted to Access", DateTime.Now, txtUName.Text);
                        log.LogDB(LogTransaction);
                    }

                    conn.Close();
            }




        }

        private void btnDataHis_Click(object sender, EventArgs e)
        {

            btnRefresh.Visible = true;
            rtextLogger.Visible = true;
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            new AddStudent(conn,2).ShowDialog();
        }



        private void btnEditStudent_Click(object sender, EventArgs e)
        {
          
            new AddStudent(conn,1).ShowDialog();
           


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new AddStudent(conn,3).ShowDialog();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            rtextLogger.Text = File.ReadAllText(@"C: \Users\eamon\Desktop\Logger.txt");


        }

        private void btnXmlStud_Click(object sender, EventArgs e)
        {
            new StudXML(conn).ShowDialog();
        }
    }
}
    
