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



             //Switch conditionals

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


             // Need to change the conditional
             int nota;
             Console.WriteLine("Type your note...");
             nota = Convert.ToInt32(Console.ReadLine());

             if(0 <= nota && nota < 5 && nota < 6)
             {
                 Console.WriteLine("Aprobada");
             }
             else if (nota < 5 && nota >= 0 )
             {
                 Console.WriteLine("Suspenso");
             }
             else if (nota >= 6 && nota < 7)
             {
                 Console.WriteLine("Bien");
             }
             else
             // it doesn´t work with negative numbers. Need to change the conditional
             {
                 Console.WriteLine("No existe");
             }

             // imc

             double height, weight;

             Console.WriteLine("Type your height in m...");
             height = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Type your weight in kg...");
             weight = Convert.ToDouble(Console.ReadLine());

             double masaCorp = (weight / (Math.Pow(height, 2)));

             if (1 <= masaCorp && masaCorp <= 16)
             {
                 Console.WriteLine("Delgadez Severa");
             }
             else if (16 < masaCorp && masaCorp < 16.99)
             {
                 Console.WriteLine("Delagez moderada");
             }
             else if (17 <= masaCorp && masaCorp <= 18.49)
             {
                 Console.WriteLine("Delagez aceptable");
             }
             else if (18.50 <= masaCorp && masaCorp <= 24.99)
             {
                 Console.WriteLine("Peso normal");
             }
             else if (25 <= masaCorp && masaCorp <= 29.99)
             {
                 Console.WriteLine("Sobrepeso");
             }
             else if (30 <= masaCorp && masaCorp <= 34.99)
             {
                 Console.WriteLine("Obeso: Tipo I");
             }
             else if (35 <= masaCorp && masaCorp <= 40)
             {
                 Console.WriteLine("Obeso: Tipo II");
             }
             else if (40 <= masaCorp )
             {
                 Console.WriteLine("Obeso: Tipo III");
             }
             else
             {
                 Console.WriteLine("Wrong data. Type it again");
             }

            //Greetings

            bool paid, vip, balanceIsPositive;
            // for a user to be able to type Y/N
            Console.WriteLine("Did you pay? (Y/N)");
            string paymentAnswer = Console.ReadLine();
            if (paymentAnswer == "Y")
            {
                paid = true;
            }
            else
            {
                paid = false;
            }

            Console.WriteLine("Are you a VIP? (Y/N)");
            string vipAnswer = Console.ReadLine();
            if (vipAnswer == "Y")
            {
                vip = true;
            }
            else
            {
                vip = false;
            }

            Console.WriteLine("Is your balance porsitive? (Y/N)");
            string balanceAnswer = Console.ReadLine();
            if (balanceAnswer == "Y")
            {
                balanceIsPositive = true;
            }
            else
            {
                balanceIsPositive = false;
            }

            if (paid == true && balanceIsPositive == true)
            {
                if (vip == true )
                {
                    Console.WriteLine("Welcome! Que pase un buen día!");
                }
                else
                {
                    Console.WriteLine("Welcome!");
                }
            }
            else
            {
                Console.WriteLine("You should pay!");
            }
            */

            /* Results of the run
            * Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
            *Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, 
            * mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            */

            int place;
            Console.WriteLine("What is your place? Type a number...");
            place = Convert.ToInt32(Console.ReadLine());

            if (place == 1)
            {
                Console.WriteLine("Ganaste! Medalla de oro.");
            }
            else if (place == 2)
            {
                Console.WriteLine("Lo importante es participar. Medalla de plata.");
            }
            else if (place == 3)
            {
                Console.WriteLine("Lo importante es participar. Medalla de bronce.");
            }
            else
            {
                Console.WriteLine("Lo importante es participar.");
            }

            /* Los puestos 1, 2 y 3 ven el mensaje "orgullo al podio", 
            *  el resto ven el mensaje "Se acabó la carrera". Hazlo usando un if / else y usando switch
            */
            Console.WriteLine("What is your place, again?");

            // For a user to be able to type the place again.
            Console.ReadLine();

            switch (place)
            {
                case 1:
                    Console.WriteLine("Orgullo al podio.");
                    break;
                case 2:
                    Console.WriteLine("Orgullo al podio.");
                    break;
                case 3:
                    Console.WriteLine("Orgullo al podio.");
                    break;
                default:
                    Console.WriteLine("Se acabó la carrera!");
                    break;
            }




                Console.ReadLine();

        }
    }
}
