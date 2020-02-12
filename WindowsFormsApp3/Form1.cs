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
    public partial class btnCreateAdminDB : Form
    {
        SqlConnection conn;
        public btnCreateAdminDB()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["orderline"].ConnectionString);
            
        }

        private void buttonCreateTables_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Connected");
                 SqlCommand cmd = new SqlCommand("CREATE TABLE Student(" +
                     "ID int IDENTITY(1,1) PRIMARY KEY, FirstName VARCHAR(20), Surname VARCHAR(20), Email VARCHAR(20), Phone  VARCHAR(10), AddressL1 VARCHAR (50), AddressL2 VARCHAR (50), City VARCHAR (20), County VARCHAR (20), Level INT, Course VARCHAR (50) );", conn);
                 cmd.ExecuteNonQuery();
                 /*cmd = new SqlCommand("CREATE TABLE Surname(" +
                     "ID INT PRIMARY KEY, Surname VARCHAR(20));", conn);
                 cmd.ExecuteNonQuery();
                 cmd = new SqlCommand("CREATE TABLE Admin(" +
                    "ID INT PRIMARY KEY, Pass VARCHAR(20));", conn);
                //cmd.ExecuteNonQuery();
                /* cmd = new SqlCommand("CREATE TABLE Product(" +
                    "ID INT PRIMARY KEY, Name VARCHAR(20), Price INT);", conn);
                 cmd.ExecuteNonQuery();
                 cmd = new SqlCommand("CREATE TABLE Orders(" +
                    "ID INT PRIMARY KEY, OrderDate DATE, Customer INT," +
                    "FOREIGN KEY(Customer) REFERENCES Customer(ID));", conn);
                 cmd.ExecuteNonQuery();
                 cmd = new SqlCommand("CREATE TABLE OrderLine(" +
                    "OrderID INT, ProdID INT, Qty INT," +
                    "FOREIGN KEY(ProdID) REFERENCES Product(ID)," +
                    "FOREIGN KEY(OrderID) REFERENCES Orders(ID)," +
                    "PRIMARY KEY(ProdID,OrderID));", conn);
                 cmd.ExecuteNonQuery();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            //using (conn)
            //{
            //    conn.Open();
            //    MessageBox.Show("Connected");
            //}
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            new AddCustomerForm(conn).ShowDialog();
        }

        private void buttonShowCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Connected");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer;", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                    MessageBox.Show("Name: " + rdr[1] + "; ID: " +
                        rdr["ID"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Connected");


                SqlCommand cmd = new SqlCommand("INSERT INTO Admin " +
                    "VALUES(@Username,@Password)", conn);
                //cmd.Parameters.AddWithValue("@ID", 1);
                cmd.Parameters.AddWithValue("@Username", "Admin");
                cmd.Parameters.AddWithValue("@Password", "Admin");
               
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            //new AddAdminForm(conn).ShowDialog();
        }

        private void btnAdminCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Connected");
                SqlCommand cmd = new SqlCommand("CREATE TABLE Admin(" +
                    "ID int IDENTITY(1,1) PRIMARY KEY, Username VARCHAR(20), Password VARCHAR(20));", conn);
                cmd.ExecuteNonQuery();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
