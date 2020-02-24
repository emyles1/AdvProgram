using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Clear
    {
        public void ClearTxt(Form f)
        {

            foreach (Control c in f.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Clear();
                else if (c is ComboBox)
                    (c as ComboBox).SelectedItem = null;
                else if (c is ComboBox)
                    (c as RadioButton).Checked = false;
            }
        }

    }
}
