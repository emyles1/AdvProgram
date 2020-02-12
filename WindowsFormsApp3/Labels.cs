using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Labels
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressL1 { get; set; }
        public string AddressL2 { get; set; }

        public string Level { get; set; }
        public string Course { get; set; }
        public Labels()
        { }

        public Labels(string firstname, string surname, string email, string phone, string addressl1)
        {
            Firstname = firstname;
            Surname = surname;
            Email = email;
            Phone = phone;
            AddressL1 = addressl1;
        }

        }
}
