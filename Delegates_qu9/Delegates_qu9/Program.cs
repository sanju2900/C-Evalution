/*
 Create a C# program to:
Create an Employee class and add about 5 employees. Write a method to give promotion. 
Get a value from the user as a trigger to give promotion to selected employees. Use Delegates
 */


namespace Delegates_qu9
{
    public delegate void Employee(string del_s);
    class employees
    {
        public string Name;

        public employees(string emp_name)
        {
            this.Name = emp_name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<employees> empList = new List<employees>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Employee Name{0}:", i);
                string str = Console.ReadLine();
                empList.Add(new employees(str));
            }
            Employee Emp = new Employee(promotion);
            foreach (var i in empList)
            {
                Emp.Invoke(i.Name);
            }
            Console.ReadKey();
        }
        public static void promotion(string employ_name)
        {
            
            Console.WriteLine("Did " +employ_name + " will be Promoted ? ");
            bool prmot = Boolean.Parse(Console.ReadLine());

            if (prmot == true)
                Console.WriteLine("{0} is Promoted ", employ_name);
            else
                Console.WriteLine("{0} is Not Promoted ",employ_name);
        }

    }
}