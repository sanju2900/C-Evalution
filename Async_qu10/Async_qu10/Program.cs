/*
 Create a C# program to:
The main task is to get a stage / event ready with the following tasks:
Flower decorations to be completed on stage.
Chief guest to be picked up from the airport. 
Co-ordinate with the caterers and set up the food area. 
Arrange the gifts to be distributed in the stage after the decorations are over. 
Start the function only when the Chief guest has arrived at the venue. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Async_qu10
{

    class Program
    {
        static async Task Main(string[] args)
        {
            flowerDecoration();
            cheifGuestPicked();
            foodArea();
            giftArranged();
            functionStarted();
            Console.ReadKey();
        }
        static async void flowerDecoration()
        {
            Console.WriteLine("Flower decorations to be completed on stage");
        }
        static async void cheifGuestPicked()
        {
            Console.WriteLine("Chief guest to be picked up from the airport.");
            await Task.Delay(5000);
            Console.WriteLine("Chief Guest Arrived at stage");
        }
        static async void giftArranged()
        {
            await Task.Delay(4000);
            Console.WriteLine("Arrange the gifts to be distributed in the stage ");
        }
        static async void functionStarted()
        {
            await Task.Delay(6000);
            Console.WriteLine("Started function as Chief guest has arrived at the venue. ");
        }
        static async void foodArea()
        {
            Console.WriteLine("Food Area has been Set for guests");
            
        }
       
    }
}

