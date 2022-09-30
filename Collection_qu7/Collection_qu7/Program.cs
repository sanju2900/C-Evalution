/*
 Write a C# program that uses a Queue to store a list of people. Create a class called Person.cs with two 
properties (name and age) and a ToString() method to print the result.

Then define a Queue and request the information (name and age) of 5 people from the user, you will have to 
store the information in the queue.  Finally print the result of the queue on screen. 
 */


using System.Collections;

namespace Collection_qu7
{
    public class Queue_obj
    {
        
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public override string ToString()
            {
                return Name + " - " + Age;
            }
        }

        public static void Main(string[] args)
        {
            Queue list = new Queue();
            

            int total = 5;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Enter the Name Person: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Age : ");
                int age = int.Parse(Console.ReadLine());

                list.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }

    }

}