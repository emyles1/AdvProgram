using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddCustomerForm : Form
    {
        SqlConnection conn;
        public AddCustomerForm(System.Data.SqlClient.SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO FirstName " +
                    "VALUES(@ID,@Name)", conn);
                cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                cmd.Parameters.AddWithValue("@Name", textBoxName.Text);

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
        }
    }
}
