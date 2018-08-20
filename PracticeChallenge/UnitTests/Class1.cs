using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ClassLibrary;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void When_GetInfo_Expect_StudentDetails()
        {
            var student = new Student("Scott", "Jenkins", 1996, 1020);
            Assert.AreEqual("First Name: Scott, Surname: Jenkins, Year of Birth: 1996, ID: 1020", student.GetInfo());
        }

        [TestCase]
        public void When_GetInfo_Expect_StaffDetails()
        {
            var staff = new Staff("Bob", "Geldof", 1987, "BG123");
            Assert.AreEqual("First Name: Bob, Surname: Geldof, Year of Birth: 1987, Username: BG123", staff.GetInfo());
        }

        [TestCase]
        public void When_GetInfo_Expect_TeacherDetails()
        {
            var teacher = new Teacher("Bon", "Scott", 1967, "Music", "BS123");
            Assert.AreEqual("First Name: Bon, Surname: Scott, Year of Birth: 1967, Username: BS123, Expertise: Music", teacher.GetInfo());
        }

        [TestCase]
        public void When_GetInfo_Expect_AdminDetails()
        {
            var admin = new Admin("Jim", "Bo", 1985, 123, "JB123");
            Assert.AreEqual("First Name: Jim, Surname: Bo, Year of Birth: 1985, OfficeNo: 123, Username: JB123", admin.GetInfo());
        }

        [TestCase]
        public void When_GetName_Expect_Name()
        {
            var student = new Student("Scott", "Jenkins", 1996, 1020);
            Assert.AreEqual("Scott Jenkins", student.GetName());
        }

        [TestCase]
        public void When_GetAge_Expect_Age()
        {
            var student = new Student("Scott", "Jenkins", 1996, 1020);
            Assert.AreEqual(22, student.GetAge());
        }
    }
}
