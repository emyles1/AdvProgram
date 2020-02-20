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
using System.Collections;

/*event handler for checking textboxes
 //hps://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.textboxbase.clear?view=netframework-4.8https:
    */
namespace WindowsFormsApp3
{
    public partial class AddStudent : Form
    {
        Logger log = new Logger();
        String LogTransaction = "";
        int mode;
        SqlConnection conn;
        class cc : Clear { }
        Clear cleartxt = new cc();
        Level Lvl = new Level();
        bool flag;

        public AddStudent(SqlConnection conn, int m)
        {
           
      
            mode = m;
            InitializeComponent();
            this.conn = conn;
            if (mode == 2)
                this.rbAddStudent.Checked = true;
            if (mode == 1)
                this.rbEditStudent.Checked = true;
            if (mode == 3)
                this.rbDeleteStudent.Checked = true;
            labelValue();

            dataGridView1.Visible = false;

        }


        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void rbAddStudent_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;

            cleartxt.ClearTxt(this);

            labelValue();

        }
        private void rbEditStudent_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
            mode = 1;
            labelValue();
            cleartxt.ClearTxt(this);
            //labelValue();

        }

        private void rbDeleteStudent_CheckedChanged(object sender, EventArgs e)
        {
            //lets start this today
            mode = 3;
            cleartxt.ClearTxt(this);
            labelValue();
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           

            if (rbAddStudent.Checked)
            {

                try
                {

                    using (SqlCommand cmd = new SqlCommand("StudentInsert", conn))
                    {
                        conn.Open();
                        // set command type
                        cmd.CommandType = CommandType.StoredProcedure;
                        // add one or more parameters
                        cmd.Parameters.AddWithValue("@FirstName", DBFirstName.Text);
                        cmd.Parameters.AddWithValue("@Surname", DBSurname.Text);
                        cmd.Parameters.AddWithValue("@Email", DBEmail.Text);
                        cmd.Parameters.AddWithValue("@Phone", DBPhone.Text);
                        cmd.Parameters.AddWithValue("@AddressL1", DBAddress1.Text);
                        cmd.Parameters.AddWithValue("@AddressL2", DBAddress1.Text);
                        cmd.Parameters.AddWithValue("@City", DBCity.Text);

                       cmd.Parameters.AddWithValue("@County", comboCounty.SelectedItem);

                        if (rdoBtnPost.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Level", EnumLevel.Postgrade); 
                        }
                        else if (rdoBtnUnder.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Level", EnumLevel.Undergrad);;
                        }

                        cmd.Parameters.AddWithValue("@Course", comboCourse.SelectedItem);

                        if (conn.State == ConnectionState.Closed
                            || conn.State == ConnectionState.Broken)
                            conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added");
                        LogTransaction = String.Format("Trasaction Date: {0} | New Student: {1}, {2} | Added", DateTime.Now, DBFirstName.Text, DBSurname.Text );
                        log.LogDB(LogTransaction);

                        conn.Close();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please ensure all fields have been filled");
                }

                
            }
            else if(rbEditStudent.Checked)
            {

               
                try
                {

                    using (SqlCommand cmd = new SqlCommand("StudentEdit", conn))
                    {
                       
                        conn.Open();
                        // set command type
                        cmd.CommandType = CommandType.StoredProcedure;
                        // add one or more parameters
                        cmd.Parameters.AddWithValue("@ID", txtStudID.Text);
                        cmd.Parameters.AddWithValue("@FirstName", DBFirstName.Text);
                        cmd.Parameters.AddWithValue("@Surname", DBSurname.Text);
                        cmd.Parameters.AddWithValue("@Email", DBEmail.Text);
                        cmd.Parameters.AddWithValue("@Phone", DBPhone.Text);
                        cmd.Parameters.AddWithValue("@AddressL1", DBAddress1.Text);
                        cmd.Parameters.AddWithValue("@AddressL2", DBAddress2.Text);
                        cmd.Parameters.AddWithValue("@City", DBCity.Text);
                        cmd.Parameters.AddWithValue("@County", comboCounty.SelectedItem);
                        if (rdoBtnPost.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Level", EnumLevel.Postgrade);
                        }
                        else if (rdoBtnUnder.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Level", EnumLevel.Undergrad); ;
                        }
                     
                        cmd.Parameters.AddWithValue("@Course", comboCourse.SelectedItem);

                        if (conn.State == ConnectionState.Closed
                            || conn.State == ConnectionState.Broken)
                            conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated");

                    }
                }
                finally
                {
                    LogTransaction = String.Format("Transaction Date: {0} | Student: {1} {2} | Edited", DateTime.Now, DBFirstName.Text, DBSurname.Text);
                    log.LogDB(LogTransaction);

                    conn.Close();
                }

            }

            else if(rbDeleteStudent.Checked)
            {
             
                try
                {
                    using (SqlCommand cmd = new SqlCommand("StudentDelete", conn))
                    {
                        conn.Open();
                        // set command type
                        cmd.CommandType = CommandType.StoredProcedure;
                        // add one or more parameters
                        cmd.Parameters.AddWithValue("@ID", txtStudID.Text);
              
                        if (conn.State == ConnectionState.Closed
                            || conn.State == ConnectionState.Broken)
                            conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                    }
                }
                finally
                {
                    LogTransaction = String.Format("Transaction Date: {0} | Student ID: {1} | Deleted", DateTime.Now, txtStudID.Text );
                    log.LogDB(LogTransaction);
                    conn.Close();
                }

            }
            cleartxt.ClearTxt(this);
            labelValue();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLoadStd_Click(object sender, EventArgs e)
        {

            string ID = txtStudID.Text;

            try
            {

                //change this to a stored procedure

                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Student where id=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DBFirstName.Text = reader["FirstName"].ToString();
                        DBSurname.Text = reader["Surname"].ToString();
                        DBEmail.Text = reader["Email"].ToString();
                        DBPhone.Text = reader["Phone"].ToString();
                        DBAddress1.Text = reader["AddressL1"].ToString();
                        DBAddress2.Text = reader["AddressL2"].ToString();
                        DBCity.Text = reader["City"].ToString();
                        comboCounty.Text = reader["County"].ToString();
                        string rdoBtnPoster = reader["level"].ToString();
              
                         if (rdoBtnPoster=="0")
                        {
                            rdoBtnPost.Checked=true;                     
                        }
                        else 
                        {
                            
                            rdoBtnUnder.Checked = true;
                        }
                        comboCourse.Text = reader["Course"].ToString();
                        
                    }

                    if (txtStudID.Text == "" && DBFirstName.Text == "")
                    {
                        MessageBox.Show("Please enter a student ID");
                        //adding a flag so items wont get updated to disabled when no data pulled
                        flag = true;
                        
                       
                    }
                    else if (txtStudID.Text == txtStudID.Text && DBFirstName.Text == "")
                    {
                        MessageBox.Show("Student doesnt exist");
                        flag = true;
                        cleartxt.ClearTxt(this);
                    }
                    
                }

            }
            finally
            {
                LogTransaction = String.Format("Trasaction Date: {0},Loaded Student ID: {1}", DateTime.Now, txtStudID.Text);
                log.LogDB(LogTransaction);
                conn.Close();
            }



                if (rbEditStudent.Checked && txtStudID.Text != null && flag ==false)
                {
                DBAddress1.Enabled = true;
                DBFirstName.Enabled = false;
                DBSurname.Enabled = false;
                DBEmail.Enabled = true;
                DBPhone.Enabled = true;
                DBAddress2.Enabled = true;
                DBCity.Enabled = true;
                //DBCounty.Enabled = true;
                //DBCourse.Enabled = false;
                comboCounty.Enabled = true;
                comboCourse.Enabled = false;
                //comboxLevel.Enabled = true;
                txtStudID.Enabled = false;
               
            }
        }



        public void labelValue()
        {
            int value = mode;
            //better to user a switch statment here
            if (value == 1)
            {

                txtStudID.Visible = true;
                txtStudID.Enabled = true;
                btnLoadStd.Visible = true;
                label11.Visible = true;

                label1.Text = "Edit First Name";
                label2.Text = "Edit Surname";
                label3.Text = "Edit Email";
                label4.Text = "Edit Phone";
                label5.Text = "Edit Address Line 1";
                label6.Text = "Edit Address Line 2";
                label7.Text = "Edit City";
                label8.Text = "Edit County";
                label9.Text = "Edit Level";
                label10.Text = "Edit Course";
                label11.Text = "Load Student ID";
                btnSubmit.Text = "Edit Student";

                DBAddress1.Enabled = false;
                DBFirstName.Enabled = false;
                DBSurname.Enabled = false;
                DBEmail.Enabled = false;
                DBPhone.Enabled = false;
                DBAddress2.Enabled = false;
                DBCity.Enabled = false;
                //DBCounty.Enabled = false;
                comboCounty.Enabled = false;
                //DBCourse.Enabled = false;
                comboCourse.Enabled = false;
                //comboxLevel.Enabled = false;
            }

            else if (value == 2)
            {
                label11.Visible = false;
                txtStudID.Visible = false;
                btnLoadStd.Visible = false;

                label1.Text = "Add First Name";
                label2.Text = "Add Surname";
                label3.Text = "Add Email";
                label4.Text = "Add Phone";
                label5.Text = "Add Address Line 1";
                label6.Text = "Add Address Line 2";
                label7.Text = "Add City";
                label8.Text = "Add County";
                label9.Text = "Add Level";
                label10.Text = "Add Course";
                btnSubmit.Text = "Add Student";

                DBAddress1.Enabled = true;
                DBFirstName.Enabled = true;
                DBSurname.Enabled = true;
                DBEmail.Enabled = true;
                DBPhone.Enabled = true;
                DBAddress2.Enabled = true;
                DBCity.Enabled = true;
                //DBCounty.Enabled = true;
                comboCounty.Enabled = true;
                //DBCourse.Enabled = true;
                comboCourse.Enabled = true;
                //comboxLevel.Enabled = true;
            }

            else if (value == 3)
            {
                txtStudID.Visible = true;
                btnLoadStd.Visible = true;
                label11.Visible = true;

                label1.Text = "Delete First Name";
                label2.Text = "Delete Surname";
                label3.Text = "Delete Email";
                label4.Text = "Delete Phone";
                label5.Text = "Delete Address Line 1";
                label6.Text = "Delete Address Line 2";
                label7.Text = "Delete City";
                label8.Text = "Delete County";
                label9.Text = "Delete Level";
                label10.Text = "Delete Course";
                label11.Text = "Load Student ID";
                btnSubmit.Text = "Delete Student";

                DBAddress1.Enabled = false;
                DBFirstName.Enabled = false;
                DBSurname.Enabled = false;
                DBEmail.Enabled = false;
                DBPhone.Enabled = false;
                DBAddress2.Enabled = false;
                DBCity.Enabled = false;
                //DBCounty.Enabled = false;
                comboCounty.Enabled = false;
                //DBCourse.Enabled = false;
                comboCourse.Enabled = false;
                //comboxLevel.Enabled = false;
            }

        }

        private void btnViewDB_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
 
        }
    }
}