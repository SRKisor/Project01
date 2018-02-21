using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Application
{
    class Program
    {
        private static string studentsFName;
        private static string studentsLName;
        private static int studentID = 2016140;
        private static int studentCount = 4;

        static int[] stuIDArray = new int[studentCount];
        static string[] stuNameArray = new string[studentCount];
        
        static void Main(string[] args)
        {
            Console.WriteLine("University Student Registration System");
            for (int i = 0; i < stuNameArray.Length; i++)
            {
                studentNameRegister();
                stuNameArray[i] = studentsFName + " " + studentsLName;
                stuIDArray[i] = studentID;
                studentID++;

                Console.WriteLine("\n");

                displayRegisterMessage();
                Console.WriteLine("Student Name: " + stuNameArray[i]);
                Console.WriteLine("Student ID: "+ stuIDArray[i]);

                Console.WriteLine("\n\n");
            }

            Console.ReadLine();
        }

        private static void studentNameRegister(){
            Console.WriteLine("Please enter your first name: ");
            studentsFName = Console.ReadLine();

            Console.WriteLine("Please enter your Last name: ");
            studentsLName = Console.ReadLine();
        }

        private static void displayRegisterMessage() {
            Console.WriteLine("You have registerd succsfully");
            Console.WriteLine("Your Registered Details");

        }

        
    }
}
