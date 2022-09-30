/*
 Write a C# program to calculate the multiplication table and the factorial of the given number.
Get the number as an input from the user. 
 
 */


namespace Math_operation_qu5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double factorial = 1.0;
            Console.WriteLine("Enter the number for table and factorial : ");
            int n= Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Table of "+ n +" is : ");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("n x "+i+ " = "+ n*i);
            }
            Console.WriteLine("Factorial of " + n + " is : ");
            for (int i = 1; i <= n; ++i)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of " + n + " = " + factorial);
        }
    }
}