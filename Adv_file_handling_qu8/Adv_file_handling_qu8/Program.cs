/*
 Write a C# program to create a file with a name given by the user. Add atleast 10 lines of content to the file. 
Get 2 inputs from the user, old word and new word and replace the old word with the new word throughout the file. 
You can show a little bit of content to the user as hints for the old word. 
 
 */


namespace Adv_file_handling_qu8

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file name you want : ");
            string name = Console.ReadLine();
            string file_Name = @"C:\Users\kumari.sanjana\OneDrive - Entain Group\Desktop\ivy training" + name + ".txt";
            try
            {
                StreamWriter s_name = File.AppendText(file_Name);

                s_name.WriteLine("Hello my first line is here");
                s_name.WriteLine("It's my second line");
                s_name.WriteLine("Here is Third Line");
                s_name.WriteLine("Here is 4th Line added");
                s_name.WriteLine("Here is 5th Line added");
                s_name.WriteLine("Here is 6th Line added");
                s_name.WriteLine("Here is 7th Line added");
                s_name.WriteLine("Here is 8th Line added");
                s_name.WriteLine("Here is 9th Line added");
                s_name.WriteLine("Here is 10th Line added");

                s_name.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamReader sorc = File.OpenText(file_Name))
                {
                    string str = "";
                    while ((str = sorc.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                    sorc.Close();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the text you wanna replaced");
            string OldText = Console.ReadLine();

            Console.WriteLine("Enter the text you want in the file");
            string NewText = Console.ReadLine();

            string text = File.ReadAllText(file_Name);
            text = text.Replace(OldText, NewText);
            File.WriteAllText(file_Name, text); Console.ReadKey();

        }
    }
}


