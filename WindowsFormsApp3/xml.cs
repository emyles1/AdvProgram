using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class xml : Form
    {
        private DataSet ds;
        public xml()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (ds == null)
            {
                ds = new DataSet("GameStop");
                dt = new DataTable("Game");
                dt.Columns.Add("StockID");
                dt.Columns.Add("Title");
                dt.Columns.Add("Year");
                dt.Columns.Add("Description");
                ds.Tables.Add(dt);
            }
            dt = ds.Tables["Game"];
            DataRow row = dt.NewRow();
            row["StockID"] = txtID.Text;
            row["Title"] = txtTitle.Text;
            row["Year"] = txtYear.Text;
            row["Description"] = txtDesc.Text;
            txtID.Clear(); txtTitle.Clear();
            dt.Rows.Add(row);
            dt.AcceptChanges();
            output.Text = "Record Created";
            output.Visible = true;
        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            if(txtFN.Text =="")
            {
                txtFN.Text = "Games.xml";
            }
            ds.WriteXml(txtFN.text);
            output.Text = "Saved";
        }

        private void btnLoad_Click_Click(object sender, EventArgs e)
        {
            if (ds == null)
            {
                ds = new DataSet();
            }
            if (txtFN.Text == "")
            {
                txtFN.Text = "Games.xml";
            }
            string fileN = txtFN.Text;
            ds.ReadXml(fileN, XmlReadMode.InferSchema);
            if (!ds.Tables.Contains("Game")) throw new Exception();
        }

        private void btnView_Click_Click(object sender, EventArgs e)
        {
            if (ds == null || txtID.Text=="")
            {
                MessageBox.Show("Not Loaded or Selected");
            }
            else
            {
                DataTable ds = ds.Tables["Game"];
                string expr = string.Format("StockID={0}, textID.Text");
                DataRow[] r = dt.Select(expr);
                txtID.Text = (string)r[0]["StockID"];
                txtDesc.Text = (string)r[0]["Description"];
                txtTitle.Text = (string)r[0]["Title"];
                txtYear.Text = (string)r[0]["Year"];
            }
        }
    }
}
