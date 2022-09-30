
//Write a C# program to find the maximum and minum value in an array
namespace Array_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of value you want in array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array =new int[n];
            Console.WriteLine("Enter array elements : " );
            for (int i = 0; i < n; i++)
            {
               array[i]= Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0];
            int min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Maximum element of array is: "+max);
            Console.WriteLine("Minimum element of array is: " + min);
        }
    }
}