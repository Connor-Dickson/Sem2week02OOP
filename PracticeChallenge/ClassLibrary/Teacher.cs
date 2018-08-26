using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Staff
    {
        public string Expertise { get; set; }
        public Teacher(string fname, string sname, int yearofbirth, string username, string expertise) : base(fname, sname, yearofbirth, username)
        {
            FName = fname;
            SName = sname;
            YearOfBirth = yearofbirth;
            Expertise = expertise;
            Username = username;
        }
        public override string GetInfo()
        {
            string Info = String.Format("First Name: {0}, Surname: {1}, Year of Birth: {2}, Username: {3}, Expertise: {4}", FName, SName, YearOfBirth, Username, Expertise); 
            return Info;
        }
    }
}
