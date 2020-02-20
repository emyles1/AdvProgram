using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class StudXML : Form
    {
        class cc : Clear { }
        Clear cleartxt = new cc();
        private DataSet ds;
        SqlConnection conn;
        Logger log = new Logger();
        String LogTransaction = "";
        public StudXML(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            string ID = txtID.Text;
            cleartxt.ClearTxt(this);
            using (SqlCommand cmd = new SqlCommand("studentReturn", conn))
            {
                try
                {
                    conn.Open();
                    // set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    // add one or more parameters
                    cmd.Parameters.AddWithValue("@IDStud", ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //read the data
                        while (reader.Read())
                        {
                            //I have to fill the ID Value again as the ClearTxt() method removes it and that method is requried to ensure 
                            //previous fields are cleared in the event of an empty student returned
                            txtID.Text = ID;

                            DBFirstName.Text = reader["FirstName"].ToString();
                            DBSurname.Text = reader["Surname"].ToString();
                            DBEmail.Text = reader["Email"].ToString();
                            DBPhone.Text = reader["Phone"].ToString();
                            DBAddress1.Text = reader["AddressL1"].ToString();
                            DBAddress2.Text = reader["AddressL2"].ToString();
                            DBCity.Text = reader["City"].ToString();
                            DBcomboCounty.Text = reader["County"].ToString();
                            string rdoBtnPoster = reader["level"].ToString();

                            if (rdoBtnPoster == "0")
                            {
                                rdbtnPost.Checked = true;
                            }
                            else
                            {

                                rdbtnUnder.Checked = true;
                            }
                            DBcomboCourse.Text = reader["Course"].ToString();

                            /*DBFirstName.Text = reader["FirstName"].ToString();
                            DBSurname.Text = reader["Surname"].ToString();
                            DBEmail.Text = reader["Email"].ToString();
                            DBPhone.Text = reader["Phone"].ToString();
                            DBAddress1.Text = reader["AddressL1"].ToString();
                            DBAddress2.Text = reader["AddressL2"].ToString();
                            DBCity.Text = reader["City"].ToString();
                            DBCounty.Text = reader["County"].ToString();
                            comboxLevel.Text = reader["level"].ToString();
                            DBCourse.Text = reader["Course"].ToString();*/

                            //Create logging string and send to LogDB Method
                            LogTransaction = String.Format("Transaction Date: {0} | Student ID: {1}  | Name: {2} {3} | Loaded from StudXML Page ", DateTime.Now, ID, DBFirstName.Text, DBSurname.Text);
                            log.LogDB(LogTransaction);
                        }

                    }
                }
                finally
                {
                    //Ensure the returned search actually displays some data
                    if (DBFirstName.Text == "")
                    {
                        LogTransaction = String.Format("Transaction Date: {0} | Student ID: {1}  | Not Found | ", DateTime.Now, ID, DBFirstName.Text, DBSurname.Text);
                        log.LogDB(LogTransaction);
                        MessageBox.Show("Record not found");
                    }
                   
                    conn.Close();
                }


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == "")
            { 
                txtFN.Text = "Student.xml";
            }
            ds.WriteXml(txtFN.Text);
  
            MessageBox.Show("Saved");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Create XML for student
            DataTable dt;
            if (ds == null)
            {
                ds = new DataSet("StudentDB");
                dt = new DataTable("Student");
                dt.Columns.Add("StudentID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Surname");
                dt.Columns.Add("Email");
                dt.Columns.Add("Phone");
                dt.Columns.Add("Address Line 1");
                dt.Columns.Add("Address Line 2");
                dt.Columns.Add("City");
                dt.Columns.Add("County");
               // dt.Columns.Add("Level");
                dt.Columns.Add("Course");
                ds.Tables.Add(dt);
            }
            dt = ds.Tables["Student"];
            DataRow row = dt.NewRow();

            row["StudentID"] = txtID.Text;
            row["Name"] = DBFirstName.Text;
            row["Surname"] = DBSurname.Text;
            row["Email"] = DBEmail.Text;
            row["Phone"] = DBPhone.Text;
            row["Address Line 1"] = DBAddress1.Text;
            row["Address Line 2"] = DBAddress2.Text;
            row["City"] = DBCity.Text;
            row["County"] = DBcomboCounty.Text;
           // row["Level"] = comboxLevel.Text;
            row["Course"] = DBcomboCourse.Text;


            dt.Rows.Add(row);
            dt.AcceptChanges();

            MessageBox.Show("Record Created");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            

            string ID = txtID.Text;
            cleartxt.ClearTxt(this);
            using (SqlCommand cmd = new SqlCommand("studentReturn", conn))
            {
                try
                {
                    conn.Open();
                    // set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    // add one or more parameters
                    cmd.Parameters.AddWithValue("@IDStud", ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //read the data
                        while (reader.Read())
                        {
                            //I have to fill the ID Value again as the ClearTxt() method removes it and that method is requried to ensure 
                            //previous fields are cleared in the event of an empty student returned
                            txtID.Text = ID;
                            DBFirstName.Text = reader["FirstName"].ToString();
                            DBSurname.Text = reader["Surname"].ToString();
                            DBEmail.Text = reader["Email"].ToString();
                            DBPhone.Text = reader["Phone"].ToString();
                            DBAddress1.Text = reader["AddressL1"].ToString();
                            DBAddress2.Text = reader["AddressL2"].ToString();
                            DBCity.Text = reader["City"].ToString();
                            DBcomboCounty.Text = reader["County"].ToString();
                            //DBcomboxLevel.Text = reader["level"].ToString();
                            DBcomboCourse.Text = reader["Course"].ToString();
                        }
                    }
                }
                finally
                {
                    if (DBFirstName.Text == "")
                        MessageBox.Show("Record not found");
                    conn.Close();
                }
                
            }

          
        }
    
    }
}
