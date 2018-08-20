using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Person
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int YearOfBirth { get; set; }
        public Person(string fname, string sname, int yearofbirth)
        {
            FName = fname;
            SName = sname;
            YearOfBirth = yearofbirth;
        }
        public string GetName()
        {
            string Name = FName + " " + SName;
            return Name;
            
        }
        public int GetAge()
        {
            int Age = DateTime.Now.Year - YearOfBirth;
            return Age;
        }
        public abstract string GetInfo();
    }
}
