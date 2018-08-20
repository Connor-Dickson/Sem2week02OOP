using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Staff : Person
    {
        public string Username { get; set; }
        public Staff(string fname, string sname, int yearofbirth, string username) : base(fname, sname, yearofbirth)
        {
            FName = fname;
            SName = sname;
            YearOfBirth = yearofbirth;
            Username = username;
        }
        public override string GetInfo()
        {
            string Info = String.Format("First Name: {0}, Surname: {1}, Year of Birth: {2}, Username: {3}", FName, SName, YearOfBirth, Username);
            return Info;
        }
    }
}
