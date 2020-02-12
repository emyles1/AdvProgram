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
        private DataSet ds;
        SqlConnection conn;
        public StudXML()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["orderline"].ConnectionString);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /* if (ds == null)
             {
                 ds = new DataSet();
             }
             if (txtFN.Text == "")
             {
                 //txtFN.Text = "Games.xml";
                 txtFN.Text = "Student.xml";
             }
             string fileN = txtFN.Text;
             ds.ReadXml(fileN, XmlReadMode.InferSchema);
             //if (!ds.Tables.Contains("Game")) throw new Exception();
             if (!ds.Tables.Contains("Student")) throw new Exception();*/

            string ID = txtID.Text;

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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == "")
            {
                //txtFN.Text = "Games.xml";
                txtFN.Text = "Student.xml";
            }
            ds.WriteXml(txtFN.Text);
            //output.Text = "Saved";
            MessageBox.Show("Saved");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
                dt.Columns.Add("Level");
                dt.Columns.Add("Course");
                ds.Tables.Add(dt);
            }
            dt = ds.Tables["Student"];
            DataRow row = dt.NewRow();
            //row["StockID"] = txtID.Text;
            row["StudentID"] = txtID.Text;
            row["Name"] = DBFirstName.Text;
            row["Surname"] = DBSurname.Text;
            row["Email"] = DBEmail.Text;
            row["Phone"] = DBPhone.Text;
            row["Address Line 1"] = DBAddress1.Text;
            row["Address Line 2"] = DBAddress2.Text;
            row["City"] = DBCity.Text;
            row["County"] = DBCounty.Text;
            row["Level"] = comboxLevel.Text;
            row["Course"] = DBCourse.Text;

            // txtID.Clear(); txtDesc.Clear(); txtTitle.Clear(); txtYear.Clear();
            dt.Rows.Add(row);
            dt.AcceptChanges();
            //output.Text = "Record Created";
            //output.Visible = true;
            MessageBox.Show("Record Created");
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            using (SqlCommand cmd = new SqlCommand("studentReturn", conn))
            {
                conn.Open();
                // set command type
                cmd.CommandType = CommandType.StoredProcedure;
                // add one or more parameters
                cmd.Parameters.AddWithValue("@IDStud", 1);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //read the data
                    while (reader.Read())
                    {
                      
                        DBFirstName.Text = reader["FirstName"].ToString();
                        DBSurname.Text = reader["Surname"].ToString();
                        DBEmail.Text = reader["Email"].ToString();
                        DBPhone.Text = reader["Phone"].ToString();
                    }
                }
            }

           /* Xml working code
            if (ds == null || txtID.Text == "")
            {
                MessageBox.Show("Not Loaded or Selected");
            }
            else
            {
                DataTable dt = ds.Tables["Student"];
                string expr = string.Format("StudentID={0}", txtID.Text);
                DataRow[] r = dt.Select(expr);
                txtID.Text = (string)r[0]["StudentID"];
                DBFirstName.Text = (string)r[0]["Name"];
                DBSurname.Text = (string)r[0]["Surname"];
                DBEmail.Text = (string)r[0]["Email"];
                DBPhone.Text = (string)r[0]["Phone"];
                DBAddress1.Text = (string)r[0]["Address Line 1"];
                DBAddress2.Text = (string)r[0]["Address Line 2"];
                DBCity.Text = (string)r[0]["City"];
                DBCounty.Text = (string)r[0]["County"];
                comboxLevel.Text = (string)r[0]["Level"];
                DBCourse.Text = (string)r[0]["Course"];
                DBEmail.Text = (string)r[0]["Email"];
            }*/
        }
    
    }
}
