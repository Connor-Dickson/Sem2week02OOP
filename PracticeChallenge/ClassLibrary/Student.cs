using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person
    {
        public int ID { get; set; }
        public Student(string fname, string sname, int yearofbirth, int id) : base(fname, sname, yearofbirth)
        {
            FName = fname;
            SName = sname;
            YearOfBirth = yearofbirth;
            ID = id;
        }
        public override string GetInfo()
        {
            string Info = String.Format("First Name: {0}, Surname: {1}, Year of Birth: {2}, ID: {3}", FName, SName, YearOfBirth, ID);
            return Info;
        }
    }
}
