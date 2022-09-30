/*
 Write a C# program to create a Phonebook. 
The Phonebook should take inputs from the user and store their numbers. 
Also ask for the user age and store their numbers as Students in a sub class. 
If the user gives a profession, store the numbers in the Service subclass. 
Display the numbers as a collection. 
Input: Rekha, 45, Doctor: Hema, 17 : Dheeraj, 34, Tennis player: Gaurav, 12: Bhavna,
33: Umang 24: Suresh, 66: Soni, 14, Siddhant, 28, Professor. 
Output: Students:
Hema, 17, Ph:No
Gaurav, 12, Ph:No
Soni, 14, Ph.No
Services and Professionals:
Rekha, 45, Doctor, Ph.No
Dheeraj, 34, Tennis player, Ph.No
Siddhant, 28, Professor, Ph.No
Citizens:
Bhavna, 33, Ph.No
Umang, 24, Ph.No
Suresh, 66, Ph.No
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace opps_qu2
{
    class phonebook
    {
        public long phoneNo;
        public string name;
        public int age;
        public string Profession;



        public phonebook(long phoneNo, string name, int age, string Profession)
        {
            this.phoneNo = phoneNo;
            this.name = name;
            this.age = age;
            this.Profession = Profession;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<phonebook> phoneList = new List<phonebook>();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(" Enter Phone List Number " + i);
                Console.WriteLine("Enter Your Phone Number :");
                int phn = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Your Age :");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Profession :");
                string profession = Console.ReadLine();
                phoneList.Add(new phonebook(phn, name, age, profession));



                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("\t\t PhoneList ");
            foreach (var i in phoneList)
            {
                Console.WriteLine("Name : " + i.name + ", Age : " + i.age + ", Profession : " + i.Profession + ", Phone No. : " + i.phoneNo);
            }



            Console.ReadKey();
        }
    }
}

