using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Admin : Staff
    {
        public int OfficeNo { get; set; }
        public Admin(string fname, string sname, int yearofbirth, int officeno, string username) : base(fname, sname, yearofbirth, username)
        {
            FName = fname;
            SName = sname;
            YearOfBirth = yearofbirth;
            OfficeNo = officeno;
            Username = username;
        }
        public override string GetInfo()
        {
            string Info = String.Format("First Name: {0}, Surname: {1}, Year of Birth: {2}, OfficeNo: {3}, Username: {4}", FName, SName, YearOfBirth, OfficeNo, Username);
            return Info;
        }
    }
}
