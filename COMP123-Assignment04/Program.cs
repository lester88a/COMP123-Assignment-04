using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment04_Rolling_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance variables+++++++++++++++++++++++++++++++
            int firstDice = 0;
            int secondDice = 0;
            int sum;
            int[] totalOfSumValue = new int[11];
            Random rnd = new Random();

            //for loop to roll the dice 36000 times
            for (int i = 0; i < 36000; i++)
            {
                firstDice = rnd.Next(1, 7);
                secondDice = rnd.Next(1, 7);
                sum = firstDice + secondDice;

                //switch statement to add up how many times each value is achieved
                switch (sum)
                {
                    case 2:
                        totalOfSumValue[0]++;
                        break;
                    case 3:
                        totalOfSumValue[1]++;
                        break;
                    case 4:
                        totalOfSumValue[2]++;
                        break;
                    case 5:
                        totalOfSumValue[3]++;
                        break;
                    case 6:
                        totalOfSumValue[4]++;
                        break;
                    case 7:
                        totalOfSumValue[5]++;
                        break;
                    case 8:
                        totalOfSumValue[6]++;
                        break;
                    case 9:
                        totalOfSumValue[7]++;
                        break;
                    case 10:
                        totalOfSumValue[8]++;
                        break;
                    case 11:
                        totalOfSumValue[9]++;
                        break;
                    case 12:
                        totalOfSumValue[10]++;
                        break;
                }
            }


            //Display to the console
            Console.WriteLine("SumValue \t TotalOfSum");
            for (int index = 0; index < totalOfSumValue.Length; index++)
            {
                Console.WriteLine(" {0} \t\t {1} ", index + 2, totalOfSumValue[index]);
            }

            WaitForKey();
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
