/*
 Write a C# program that implements an abstract class Bird that has a Name property of type text
and three methods SetName (string name), GetName and Fly. 
The Fly method will be an abstract method of type void.
You will also need to create a Crow/Parrot class that implements the above Bird class and the Fly method should
say that the crow/parrot is flying. 
To test the program ask the user for a bird name and create a new Crow/Parrot type object from the Main program, 
give the Crow/Parrot object a name, and then execute the GetName and Fly methods.
 
 */



namespace abstract_qu4
{

    public class AbstractClass
    {
       

        public class Crow : Bird
        {
            public override void Fly()
            {
                Console.WriteLine("crow/parrot is flying : ");
            }
        }

        public abstract class Bird
        {
            private string Name;

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }

           
       public abstract void Fly();
        }
        public static void Main(string[] args)
        {
            Crow parrot = new Crow();
            Console.Write("Give the name of bird: ");
            parrot.SetName(Console.ReadLine());
            Console.WriteLine(parrot.GetName());
            parrot.Fly();
        }
    }

}