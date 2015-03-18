using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Course: COMP-123-Assignment-04
 * Section: 062
 * Student Name: LI XU
 * Student ID: 300735072
 * Date Last Modified:Feb 18, 2015
 * Revision History:Feb 18, 2015
 */
namespace COMP123_Assignment04_Airline_Reservations_System
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

        }

        //Menu method+++++++++++++++++++++++++++++++++++++++++++++++++++++
        private static void MainMenu()
        {
            int selection = 0;

            while (selection != 3)
            {
                Console.WriteLine("+++++++++++++++++++++++++++++++");
                Console.WriteLine("+ Airline_Reservations_System +");
                Console.WriteLine("+                             +");
                Console.WriteLine("+      1. First Class         +");
                Console.WriteLine("+      2. Economy Class       +");
                Console.WriteLine("+      3. Exit                +");
                Console.WriteLine("+                             +");
                Console.WriteLine("+++++++++++++++++++++++++++++++");
                Console.Write("Please make your selection: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Incorrect entry - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }
        }

        
        // UTILITY METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
