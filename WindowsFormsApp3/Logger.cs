using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Logger
    {
        public object Service { get; private set; }

        public void LogDB(string s)
        {


            string fileName = "Logger.txt";
            if (!File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            }

            // System.IO.File.WriteAllText(@"C:\Users\eamon\Desktop\Logger.txt", s);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
            {
                file.WriteLine(s);
            }

        }
    }
}
