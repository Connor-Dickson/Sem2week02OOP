using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace ConsoleMenu
{
    class Program
    {
      
        static void Main(string[] args)
        {
            

            
            int menuChoice = 0;

            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();
            List<Admin> adminList = new List<Admin>();

            while(menuChoice != 5)
            {
                Console.WriteLine("Welcome-");
                Console.WriteLine("1. Create Student");
                Console.WriteLine("2. Create Teacher");
                Console.WriteLine("3. Create Admin");
                Console.WriteLine("4. View People");
                Console.WriteLine("5. Exit");
                int choice = int.Parse(Console.ReadLine());
            


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Create Student");

                        Console.WriteLine("Enter First Name");
                        string sfirstName = Console.ReadLine();

                        Console.WriteLine("Enter Surname");
                        string sSurname = Console.ReadLine();

                        try
                        {
                            Console.WriteLine("Enter Year of Birth");
                            int testYear = int.Parse(Console.ReadLine());
                            if(testYear < 1900 || testYear > 2018)
                            {
                                throw new BirthYearException();
                            }
                        }
                        
                        catch (BirthYearException byex)
                        {
                            Console.WriteLine(byex.Message);
                        }

                        int sBirthYear = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Student ID");
                        int sID = int.Parse(Console.ReadLine());

                        Student student = new Student(sfirstName, sSurname, sBirthYear, sID);

                        studentList.Add(student);
                        break;

                    case 2:

                        Console.WriteLine("Create Teacher");

                        Console.WriteLine("Enter First Name");
                        string tfirstName = Console.ReadLine();

                        Console.WriteLine("Enter Surname");
                        string tSurname = Console.ReadLine();

                        Console.WriteLine("Enter Year of Birth");
                        int tBirthYear = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Username");
                        string tUsername = Console.ReadLine();

                        Console.WriteLine("Enter Expertise");
                        string tExpertise = Console.ReadLine();

                        Teacher teacher = new Teacher(tfirstName, tSurname, tBirthYear, tUsername, tExpertise);

                        teacherList.Add(teacher);
                        break;

                    case 3:

                        Console.WriteLine("Create Admin");

                        Console.WriteLine("Enter First Name");
                        string afirstName = Console.ReadLine();

                        Console.WriteLine("Enter Surname");
                        string aSurname = Console.ReadLine();

                        Console.WriteLine("Enter Year of Birth");
                        int aBirthYear = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Office Number");
                        int aOfficeno = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Username");
                        string aUsername = Console.ReadLine();

                        Admin admin = new Admin(afirstName, aSurname, aBirthYear, aOfficeno, aUsername);

                        adminList.Add(admin);
                        break;

                    case 4:
                        Console.WriteLine("Students: ");

                        foreach(var details in studentList)
                        {
                            
                            Console.WriteLine("First Name: {0}, Surname: {1}, Year of Birth: {2}, ID: {3}", 
                                details.FName, details.SName, details.YearOfBirth, details.ID);
                        }

                        Console.WriteLine("Teachers: ");

                        foreach(var details in teacherList)
                        {
                            Console.WriteLine("First Name: {0}, Surname: {1}, Year of Birth: {2}, Username: {3}, Expertise: {4}", 
                                details.FName, details.SName, details.YearOfBirth, details.Username, details.Expertise);
                        }
                        

                        Console.WriteLine("Admins: ");

                        foreach(var details in adminList)
                        {
                            Console.WriteLine("First Name: {0}, Surname: {1}, Year of Birth: {2}, OfficeNo: {3}, Username: {4}", 
                                details.FName, details.SName, details.YearOfBirth, details.OfficeNo, details.Username);
                        }
                        break;
                    case 5:
                        menuChoice = 5;
                        break;
                }
            }
        }
    }
}
