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
        // instance variables+++++++++++++++++++++++++++++++++++++
        public static bool[] seats ={false,false,false,false,false,
                                   false,false,false,false,false};//total 10seats are empty
        //public static bool[] seats;
        public static int totalFirstClassSeats;
        public static int totalEconomyClassSeats;


        static void Main(string[] args)
        {
            MainMenu(); //Call the Menu method

        }

        //Private Menu Method+++++++++++++++++++++++++++++++++++++++++++++++++++++
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
                    Console.WriteLine(error.Message);
                }

                switch (selection)
                {
                    case 1:
                        ConditionalFirstClass();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 2:
                        ConditionalEconomyClass();
                        Console.WriteLine();
                        Console.WriteLine();
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

                //Console.Clear(); // Clears the screen
            }
        }

        //Private Conditional Method+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //asks the customer if like to change to economy class when first class is full
        private static void ConditionalFirstClass()
        {
            string choose = "";
            if (totalFirstClassSeats == 5 && totalEconomyClassSeats < 5)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, first class is full! ");
                Console.WriteLine("Would like to change to economy class?");
                Console.Write("Press Y to change or N to the menu: ");

                choose = Console.ReadLine();
                if (choose == "N")
                {
                    Console.WriteLine();
                    Console.WriteLine("Next flight leaves in 3 hours.");
                }
                else if (choose == "Y")
                {
                    Console.WriteLine();
                    EconomyClassSection();
                }

            }
            else if (totalEconomyClassSeats == 5 && totalFirstClassSeats == 5)
            {
                Console.WriteLine("Sorry all seats are full!");
                Console.WriteLine();
            }
            else if (totalFirstClassSeats < 5)
            {
                Console.WriteLine();
                FirstClassSection();
            }
        }

        //asks the customer if like to change to first class when economy class is full
        private static void ConditionalEconomyClass()
        {
            string choose = "";
            if (totalEconomyClassSeats == 5 && totalFirstClassSeats < 5)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, economy class is full! ");
                Console.WriteLine("Would like to change to first class?");
                Console.Write("Press Y to change or N to the menu: ");

                choose = Console.ReadLine();
                if (choose == "N")
                {
                    Console.WriteLine("Next flight leaves in 3 hours.");
                }
                else if (choose == "Y")
                {
                    Console.WriteLine();
                    FirstClassSection();
                }

            }
            else if (totalEconomyClassSeats == 5 && totalFirstClassSeats == 5)
            {
                Console.WriteLine("Sorry all seats are full!");
                Console.WriteLine();
            }
            else if (totalEconomyClassSeats < 5)
            {
                Console.WriteLine();
                EconomyClassSection();
            }

        }

        //Private First class method++++++++++++++++++++++++++++++++++++++++++
        private static void FirstClassSection()
        {
            bool assignedSeat = false; //indicate the seat is aready assigned
            Random rand = new Random();
            int randomSeatNumber = 0;

            while (!assignedSeat)
            {
                assignedSeat = true;
                randomSeatNumber = rand.Next(1, 6);
                if (seats[randomSeatNumber] == true)
                {
                    assignedSeat = false;
                }

            }
            seats[randomSeatNumber] = true; //seat change to be assigned
            totalFirstClassSeats++;
            Console.WriteLine("Your seat number is {0} in first class", randomSeatNumber);
        }

        //Private Economy class method++++++++++++++++++++++++++++++++++++++++++
        private static void EconomyClassSection()
        {
            bool assignedSeat = false; //indicate the seat is aready assigned
            Random rand = new Random();
            int randomSeatNumber = 0;

            //keep looping until the empty seat has been found
            while (!assignedSeat)
            {
                assignedSeat = true;
                randomSeatNumber = rand.Next(6, 11);
                if (seats[randomSeatNumber] == true)
                {
                    assignedSeat = true;
                }

            }
            seats[randomSeatNumber] = true; //seat change to be occupied
            totalEconomyClassSeats++;
            Console.WriteLine("Your seat is {0} in economy class", randomSeatNumber);
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
