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
        int mode;
        class cc : Clear { }

        SqlConnection conn;
        Clear cleartxt = new cc();
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

        }


        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void rbAddStudent_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
         
            labelValue();

        }
        private void rbEditStudent_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
            mode = 1;
            labelValue();
       
        }

        private void rbDeleteStudent_CheckedChanged(object sender, EventArgs e)
        {
            //lets start this today
            mode = 3;
            labelValue();
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           

            if (rbAddStudent.Checked)
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Student " +
                        "VALUES(@FirstName, @Surname,@Email,@Phone,@AddressL1,@AddressL2,@City,@County,@Level,@Course)", conn);
                    //cmd.Parameters.AddWithValue("@ID", DBStudNo.Text);
                    cmd.Parameters.AddWithValue("@FirstName", DBFirstName.Text);
                    cmd.Parameters.AddWithValue("@Surname", DBSurname.Text);
                    cmd.Parameters.AddWithValue("@Email", DBEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", DBPhone.Text);
                    cmd.Parameters.AddWithValue("@AddressL1", DBAddress1.Text);
                    cmd.Parameters.AddWithValue("@AddressL2", DBAddress2.Text);
                    cmd.Parameters.AddWithValue("@City", DBCity.Text);
                    cmd.Parameters.AddWithValue("@County", DBCounty.Text);
                    cmd.Parameters.AddWithValue("@Level", comboxLevel.SelectedItem);
                    cmd.Parameters.AddWithValue("@Course", DBCourse.Text);

                    if (conn.State == ConnectionState.Closed
                        || conn.State == ConnectionState.Broken)
                        conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                }
                finally
                {
                    conn.Close();
                }



                //DBFirstName.Clear();
                //cleartxt.ClearTxt();

            }
            else if(rbEditStudent.Checked)
            {
               
                try
                {
                    string cmdText = "UPDATE Student SET Firstname = " +
                        "@FirstName, Surname = @Surname, Email = @Email, " +
                        "Phone = @Phone, AddressL1 = @AddressL1, " +
                        "AddressL2 = @AddressL2, City = @City, County = @County, " +
                        "Course = @Course, Level = @Level "
                        + "Where ID = @ID";
                    SqlCommand cmd = new SqlCommand(cmdText, conn);
                    cmd.Parameters.AddWithValue("@ID", txtStudID.Text);
                    cmd.Parameters.AddWithValue("@FirstName", DBFirstName.Text);
                    cmd.Parameters.AddWithValue("@Surname", DBSurname.Text);
                    cmd.Parameters.AddWithValue("@Email", DBEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", DBPhone.Text);
                    cmd.Parameters.AddWithValue("@AddressL1", DBAddress1.Text);
                    cmd.Parameters.AddWithValue("@AddressL2", DBAddress2.Text);
                    cmd.Parameters.AddWithValue("@City", DBCity.Text);
                    cmd.Parameters.AddWithValue("@County", DBCounty.Text);
                    cmd.Parameters.AddWithValue("@Level", comboxLevel.SelectedItem);
                    cmd.Parameters.AddWithValue("@Course", DBCourse.Text);

                    if (conn.State == ConnectionState.Closed
                        || conn.State == ConnectionState.Broken)
                        conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                }
                finally
                {
                    conn.Close();
                }

               // cleartxt.ClearTxt();
            }

            else if(rbDeleteStudent.Checked)
            {
                int ID = int.Parse(txtStudID.Text);
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete from Student where id=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", ID);


                    if (conn.State == ConnectionState.Closed
                        || conn.State == ConnectionState.Broken)
                        conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                }
                finally
                {
                    conn.Close();
                }

                clear();
               // cleartxt.ClearTxt();
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
                        DBCounty.Text = reader["County"].ToString();
                        comboxLevel.Text = reader["level"].ToString();
                        DBCourse.Text = reader["Course"].ToString();

                        //MessageBox.Show("test" + reader["FirstName"]);
                    }
                }
            
            conn.Close();



            if (rbEditStudent.Checked && txtStudID.Text != null)
            {
                DBAddress1.Enabled = true;
                DBFirstName.Enabled = true;
                DBSurname.Enabled = true;
                DBEmail.Enabled = true;
                DBPhone.Enabled = true;
                DBAddress2.Enabled = true;
                DBCity.Enabled = true;
                DBCounty.Enabled = true;
                DBCourse.Enabled = true;
                comboxLevel.Enabled = true;
                txtStudID.Enabled = false;
            }
        }


        public void clear()
        {
            DBFirstName.Clear();
            DBSurname.Clear();
            DBEmail.Clear();
            DBPhone.Clear();
            DBAddress1.Clear();
            DBAddress2.Clear();
            DBCity.Clear();
            DBCounty.Clear();
            DBCourse.Clear();
            txtStudID.Clear();
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

                DBAddress1.Enabled = false;
                DBFirstName.Enabled = false;
                DBSurname.Enabled = false;
                DBEmail.Enabled = false;
                DBPhone.Enabled = false;
                DBAddress2.Enabled = false;
                DBCity.Enabled = false;
                DBCounty.Enabled = false;
                DBCourse.Enabled = false;
                comboxLevel.Enabled = false;
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

                DBAddress1.Enabled = true;
                DBFirstName.Enabled = true;
                DBSurname.Enabled = true;
                DBEmail.Enabled = true;
                DBPhone.Enabled = true;
                DBAddress2.Enabled = true;
                DBCity.Enabled = true;
                DBCounty.Enabled = true;
                DBCourse.Enabled = true;
                comboxLevel.Enabled = true;
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

                DBAddress1.Enabled = false;
                DBFirstName.Enabled = false;
                DBSurname.Enabled = false;
                DBEmail.Enabled = false;
                DBPhone.Enabled = false;
                DBAddress2.Enabled = false;
                DBCity.Enabled = false;
                DBCounty.Enabled = false;
                DBCourse.Enabled = false;
                comboxLevel.Enabled = false;
            }

        }
    }
}