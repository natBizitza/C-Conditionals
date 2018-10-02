using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int num1, num2;

            Console.WriteLine("Type a number...");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type one more number...");
            num2 = Convert.ToInt32(Console.ReadLine());

               if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            } else {
                Console.WriteLine("Num1 is not equal num2.");
            }

            Console.WriteLine("Type a number...");

            int num3;
            num3 = Convert.ToInt32(Console.ReadLine());


            // The numer is odd or even? Par o impar?
            if(num3 % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            // Days of the week
            int num4;

            Console.WriteLine("Type a number...");
            num4 = Convert.ToInt32(Console.ReadLine());

            if (num4 == 1)
            {
                Console.WriteLine("Monday is here!!");
            }
            else if (num4 == 2)
            {
                Console.WriteLine("Tuesday ist da.");
            }
            else if (num4 == 3)
            {
                Console.WriteLine("Weeednesday");
            }
            else if (num4 == 4)
            {
                Console.WriteLine("Hello,Thursday!");
            }
            else if (num4 == 5)
            {
                Console.WriteLine("Friiiday");
            }
            else if (num4 == 6)
            {
                Console.WriteLine("Calm Saturday");
            }
            else if(num4 == 7)
            {
                Console.WriteLine("Sunday!");
            }
            else
            {
                Console.WriteLine("There is no day of the week with this number :(");
            }

    */

            //Switch confitionals

            int month;

            Console.WriteLine("Type a number of the month...");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("Februar");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("There is no corresponding month to this number");
                    break;
            }

            Console.ReadLine();

        }
    }
}
