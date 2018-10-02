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
           

            /* Results of the run
            * Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
            *Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, 
            * mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            */

            //int place;
            //Console.WriteLine("What is your place? Type a number...");
            //place = Convert.ToInt32(Console.ReadLine());

            //if (place == 1)
            //{
            //    Console.WriteLine("Ganaste! Medalla de oro.");
            //}
            //else if (place == 2)
            //{
            //    Console.WriteLine("Lo importante es participar. Medalla de plata.");
            //}
            //else if (place == 3)
            //{
            //    Console.WriteLine("Lo importante es participar. Medalla de bronce.");
            //}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar.");
            //}

            ///* Los puestos 1, 2 y 3 ven el mensaje "orgullo al podio", 
            //*  el resto ven el mensaje "Se acabó la carrera". Hazlo usando un if / else y usando switch
            //*/
            //Console.WriteLine("What is your place, again?");

            //// For a user to be able to type the place again.
            //Console.ReadLine();

            //switch (place)
            //{
            //    case 1:
            //        Console.WriteLine("Orgullo al podio.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Orgullo al podio.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Orgullo al podio.");
            //        break;
            //    default:
            //        Console.WriteLine("Se acabó la carrera!");
            //        break;
            //}

            ///* Escribe un programa que pida al usuario 3 números. 
            // * Si el resultado de la suma de los dos primeros es igual al tercer número, mostrarlo en pantalla, 
            // * sino mostrar que el tercero no es la suma de los dos anteriores.
            // */

            //int num1, num2, num3;

            //Console.WriteLine("Type your first number...");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Type your second number...");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Type your third number...");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //if (num1 + num2 == num3)
            //{
            //    Console.WriteLine(num3);
            //}
            //else
            //{
            //    Console.WriteLine("Try it again...");
            //}

            //// Escribe un programa que convierta los segundos a horas, minutos y segundos.

            //float num6;

            //Console.WriteLine("How many seconds?...");
            //num6 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Alright. It`s " + (num6 / 360) + " horas and " + (num6/60) + " minutes and " + num6 + " seconds");

            /*Escribe un programa que pida dos valores del usuario y 
            *Si los dos valores son iguales muestre 0
            *Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            *Si no que muestre el más grande de los dos
            */

            //float num7, num8;

            //Console.WriteLine("Type a number...");
            //num7 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Type one more...");
            //num8 = Convert.ToSingle(Console.ReadLine());

            //if (num7 == num8)
            //{
            //    Console.WriteLine(0);
            //} else if (num7 % 6 == num8 % 6)
            //{
            //    if (num7 % 6 < num8 % 6)
            //    {
            //        Console.WriteLine(num7);
            //    } else
            //    {
            //        Console.WriteLine(num8);
            //    }
            //} else if (num7 < num8)
            //{
            //    Console.WriteLine(num8);
            //}
            //else
            //{
            //    Console.WriteLine(num7);
            //}

            //Escribe un programa que pida dos números enteros entre 25 y 75 y que diga si hay un dígito en común entre los dos números.

            //int num9, num10;

            //Console.WriteLine("Type a number between 25 and 75.");
            //num9 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Type one more number between 25 and 75.");
            //num10 = Convert.ToInt32(Console.ReadLine());

            //// to determine the digits
            //int a1 = num9 / 10;
            //int a2 = num10 / 10;

            //int b1 = num9 % 10;
            //int b2 = num10 % 10;

            //if ( a1 == a2 || a1 == b1 || a1 == b2 || a2 == b1 || a2 == b2 || b1 == b2)
            //{
            //    Console.WriteLine("There are some common digits in the numbers!");
            //} 
            //else
            //{
            //    Console.WriteLine("Nope. There are no common digits.");
            //}

            //// Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos que uno de los otros.

            //int a, b, c;

            //Console.WriteLine("Type a number.");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Type one more number.");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yeah, it will be the last one.");
            //c = Convert.ToInt32(Console.ReadLine());

            //if (a - 20 == b || b - 20 == a || a - 20 == c || b - 20 == c || c - 20 == a || c - 20 == b)
            //{
            //    Console.WriteLine("There is one number that is bigger than another on 20.");
            //}
            //else
            //{
            //    Console.WriteLine("Nope. Nothing here.");
            //}

            //// Si la edad es igual o inferior a 8 mostramos mensaje "Pasa al tobogán", 
            ////si no mostramos "Eres demasiado mayor para usar el tobogán"

            //int x;

            //Console.WriteLine("How old are you, kid?");
            //x = Convert.ToInt32(Console.ReadLine());

            //if (0 < x && x <= 8)
            //{
            //    Console.WriteLine("Pasa al tobogán!");
            //}
            //else if (x > 8)
            //{
            //    Console.WriteLine("Eres demasiado mayor para usar el tobogán!! ;)");
            //}
            //else
            //{
            //    Console.WriteLine("You can´t be " + x + " years old. LOL.");
            //}

            //Comprobar un string que tenga el valor del día de la semana (lunes, martes, ...). 
            //Mostrar en pantalla el día que dice que es si es entre lunes y viernes 
            //(Por ejemplo "Hoy es lunes") y si es fin de semana mostrar "Es fin de semana" Con switch y con if else.

            //string dayOfWeek;

            //Console.WriteLine("What is the day today?");
            //dayOfWeek = Console.ReadLine();

            ////to be able to type with capitals or in lower case
            //switch (dayOfWeek.ToLower())
            //{
            //    case "monday":
            //    Console.WriteLine("Today is monday");
            //    break;
            //    case "tuesday":
            //        Console.WriteLine("Today is tuesday.");
            //        break;
            //    case "wednesday":
            //        Console.WriteLine("Today is wednesday.");
            //        break;
            //    case "thursday":
            //        Console.WriteLine("Today is thursday.");
            //        break;
            //    case "friday":
            //        Console.WriteLine("Today is friday.");
            //        break;
            //    case "saturday":
            //        Console.WriteLine("Today is weekend!");
            //        break;
            //    case "sunday":
            //        Console.WriteLine("Today is weekend!");
            //        break;
            //    default:
            //        Console.WriteLine("This day doesn´t exist... Try again.");
            //        break;
            //}

            ////A partir de un valor de número entero, mostrar el mensaje 
            ////"El valor absoluto de -7 es 7". Si es menor que cero mostrar el valor en positivo, 
            ////si es positivo o cero mostrar ese mismo valor. 

            //int y;

            //Console.WriteLine("Type any number. It can be either positive or negative.");
            //y = Convert.ToInt32(Console.ReadLine());

            //if (y < 0)
            //{
            //    Console.WriteLine("El valor absoluto de " + y + " es " +  (-y));
            //}
            //else
            //{
            // Console.WriteLine("El valor absoluto de " + y + " es " + y);     
            //}

            // Decir el número de helados que queremos comprar. Cada helado vale 2 euros. Si compramos más de 10 helados, 
            // nos regalan uno gratis. Mostrar en pantalla el número de helados que nos dan y cuánto hemos pagado por ellos.

            //int g;
            //Console.WriteLine("How many ice-cream balls would you like to have?");
            //g = Convert.ToInt32(Console.ReadLine());

            //if (0 < g && g <= 10)
            //{
            //    Console.WriteLine("You have got " + g + " ice-cream balls for " + (g*2) + " euros.");
            //}
            //else if (g > 10)
            //    {
            //    Console.WriteLine("You have got " + (g +1) + " ice-cream balls for " + (g*2) + " euros.");
            //}
            //else
            //{
            //    Console.WriteLine("You went into negative numbers... Try again.");
            //}

            // Tenemos dos números, un numerador y un dividendo. Si el dividendo no es cero, mostramos 
            //el resultado de dividir el numerador por el dividendo. Si el dividendo es cero, mostramos 
            //el mensaje "No se puede dividir por cero"

           // int numerador, dividendo;

           // Console.WriteLine("Type a numerator...");
           // numerador = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Type a dividend...");
           // dividendo = Convert.ToInt32(Console.ReadLine());

           // if (dividendo != 0)
           // {
           //     Console.WriteLine(numerador / dividendo);
           // }
           // else
           // {
           //     Console.WriteLine("No se puede dividir por cero");
           // }

           // //Un año es bisiesto si se puede dividir por 4. Pero un año que se pueda dividir por
           // //100 NO es bisiesto a no ser que se pueda dividir por 400. A partir de un año, mostrar 
           // //en pantalla si es bisiesto o no

           // // Here is a formula. It´s a boolean!! Returns an indication whether the specified year is a leap year.
           // if (DateTime.IsLeapYear(2004))
           // {
           //     Console.WriteLine("es bisiesto");
           // }
           //else
           // {
           //     Console.WriteLine("no es bisiesto");
           // }

            // Con if else if: Mostrar en pantalla un menú con varias opciones. 
            //Dependiendo de lo que el usuario elija, mostrar en pantalla la selección. Hacerlo tanto con if else como con switch.

            int r;

            Console.WriteLine("Type a number...");
            r = Convert.ToInt32(Console.ReadLine());


            if (r == 0)
            {
                Console.WriteLine("Zero.");
            } else if (r >= 8)
            {
                Console.WriteLine("Tt´s eight or more.");
            }
            else
            {
                Console.WriteLine("It can be anything!");
            }


            Console.ReadLine();
        }
    }
}
