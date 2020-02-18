using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Logger
    {
        
        public void LogDB(string s)
        {
            // System.IO.File.WriteAllText(@"C:\Users\eamon\Desktop\Logger.txt", s);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\eamon\Desktop\Logger.txt", true))
            {
                file.WriteLine(s);
            }
           
        }

    }
}
