/*
 Write a C# program to copy the contents of one file to another file 
and encrypt the new file. Have any rule to differentiate the contents along with the encryption. 
 
 */

namespace File_Handling_qu6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string file;

            // Content in files before copying
            Console.WriteLine("Before copy:\n");
            file = File.ReadAllText("C:\\Users\\kumari.sanjana\\OneDrive - Entain Group\\Desktop\\hello\\testing.txt");
            Console.WriteLine("data in first:\n" + file);

            file = File.ReadAllText("C:\\Users\\kumari.sanjana\\OneDrive - Entain Group\\Desktop\\ivy training\\testing.txt");
            Console.WriteLine("data in last :\n" + file + "\n\n\n");

            // Copy file with overwriting
            File.Copy("C:\\Users\\kumari.sanjana\\OneDrive - Entain Group\\Desktop\\hello\\testing.txt", "C:\\Users\\kumari.sanjana\\OneDrive - Entain Group\\Desktop\\ivy training\\testing.txt", true);

            // Content in files after copying
            Console.WriteLine("After copy:\n");
            file = File.ReadAllText("C:\\Users\\kumari.sanjana\\OneDrive - Entain Group\\Desktop\\hello\\testing.txt");
            Console.WriteLine("data in first:\n" + file);

            file = File.ReadAllText("C:\\Users\\kumari.sanjana\\OneDrive - Entain Group\\Desktop\\ivy training\\testing.txt");
            Console.WriteLine("data in last :\n" + file + "\n\n\n");
        }
    }
}