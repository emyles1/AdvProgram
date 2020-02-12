using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Clear
    {
        
        public void ClearTxt()
        {
            AddStudent Student = new AddStudent();

            Student.DBFirstName.Clear();
            Student.DBSurname.Clear();
            Student.DBEmail.Clear();
            Student.DBPhone.Clear();
            Student.DBAddress1.Clear();
            Student.DBAddress2.Clear();
            Student.DBCity.Clear();
            Student.DBCounty.Clear();
            Student.DBCourse.Clear();
            Student.txtStudID.Clear();
        }




    }
}
