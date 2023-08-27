using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace giraffe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
                        String phrase = " opaluku";
                        int age = 10;
                        char grade = 'A';
                        Double gpa = 3.3;
                        bool isMale = true;
                        Console.WriteLine(  phrase.Length);


                        Console.WriteLine("   /| ");
                        Console.WriteLine("  / |");
                        Console.WriteLine(" /  | ");
                        Console.WriteLine("/___| ");
            */


            /*    User input codes

              Console.Write("Enter your first name: ");
              string name =   Console.ReadLine();
              Console.Write("Enter your age: ");
              string age= Console.ReadLine();
              Console.WriteLine( "hello" + " "  + name + " you are " + " " + age);
           */

            /*    building a calaculator!
            */

            /*  int number = Convert.ToInt32("45");
              Console.WriteLine(number + 5);
              Console.ReadLine();
            */

            /* Console.Write("Enter a number: ");
             double num1 = Convert.ToDouble(Console.ReadLine());
             Console.Write("Enter another number: ");
             int num2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine(num1 * num2);

           */

            /* Array

            int[] luckyNumbers = { 4, 8, 9, 0, 23, 6, 34, };
           Console.WriteLine(luckyNumbers[2]);
          */

            /*  Methods */

            /*  Greetings("mike", 99);*/

            /* int cubbedNumber = cube(5);
             Console.WriteLine(cubbedNumber);

             Console.ReadLine() ; */


            /*  IF Statement!

                bool isMale = false;
                bool isTall = false;
            if(isMale && isTall)
            {
                Console.WriteLine( " you are a tall male ");

            } else if (isMale && !isTall)
            {

                Console.WriteLine(" you are a short male");
            } else if (!isMale && isTall)
            {
                Console.WriteLine(" you are not a male but you are tall");
            }
            else
            {
                Console.WriteLine(" you are not male and not tall");

            }
                 Console.ReadLine();  */

            /* Console.WriteLine(GetMax(20,10, 5));
              Console.ReadLine();*/


            /*building a calculator 

            Console.Write(" Enter a number:  ");
            double num1 =Convert.ToDouble (Console.ReadLine());

            Console.Write("Enter operator : ");
            string op = (Console.ReadLine());


            Console.Write(" Enter a number:  ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);

            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);

            }
            else if (op == "*")
            {

                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine(" Invalid operator  ");

            }
                    Console.ReadLine();  */



            /* Console.WriteLine(GetDay(82));
             Console.ReadLine();  */


            /*while loop 

               int index = 1;
          while ( index <= 5)

          {
              Console.WriteLine(index);
              index++;
          }

             Console.ReadLine(); */


            /* guess game
         string secretWord = "giraffe";
         string guess = " ";

         while ( guess !=secretWord)
         {
             Console.Write("Enter guess:  ");
                 guess = Console.ReadLine();

            }
                Console.WriteLine("you win!!");

              Console.ReadLine(); */

            /*  for loop */


            /* int[] luckyNumbers = { 4, 18, 15, 16, 23, 42 };
             for (int i = 0; i < luckyNumbers.Length; i++)
             {
                 Console.WriteLine(luckyNumbers[i]);
             }

                    Console.ReadLine(); */


            /*  Console.WriteLine(GetPow(4, 3));
              Console.ReadLine();  /*

            /* 2d array 
            int[,] numberGrid =
          {
            {1,2 },
            {3,4 }, 
            {5,6 }, 
           };
               Console.WriteLine(numberGrid[2,1]);
                  Console.ReadLine(); */

            /*int i = 0 */

            /*  for (int i = 0;  i < 10; i++ )
              {
                  Console.WriteLine(i);

                  if(i == 4)
                  {
                      break;
                  }

              }
                 Console.ReadLine(); */



            /* int age;
             Console.WriteLine( "Enter your age: ");
             bool lagos = int.TryParse( Console.ReadLine(), out age );
             Console.WriteLine(lagos);

             if (lagos)
             {
                 Console.WriteLine(" you're correct");


             }
             else
             {
                 Console.WriteLine(" you input a wrong information");
             }
                 Console.ReadLine();  */

            /*  Console.Write( " Enter your firstName: ");
              string firtName = Console.ReadLine();
              Console.Write(" Enter your lastName: ");
              string lastName = Console.ReadLine();
              Console.Write(" Enter your surname: ");
              string surname = Console.ReadLine();
              Console.Write(" Enter your age: ");
              int age = Convert.ToInt32(Console.ReadLine());
              string expresionMessage = ($" my first name is {firtName} and my last name & surname are  {lastName}, {surname}. my age is {age}." +
                  $"the time i submited this form is {DateTime.Now} ");

              if ( age < 18)
              {
                  Console.WriteLine(" this user is a minor");


              } else if (age >= 18)
              {
                  Console.WriteLine("  this user is matured and ready  for the challenge");
              }
              else
              {
                  Console.WriteLine("you're a robot");
              }

              Console.WriteLine(expresionMessage);
              Console.ReadLine(); */


            /* Assignment! */




            /* counterVariable = 0;
            do
            {

                excute your code
                countervariable++;

            } while(condition)
               execute codes as long as  CodeConditionStatement is met */

            Random random = new Random();
            int randomNumber = random.Next(1, 3);
            int numberofAttempts = 4;
            int playerGuess;

            Console.Write("Enter your guess: ");
            

            
                // Console.WriteLine(numberofAttempts);
            
                for (int i = 0; i <= numberofAttempts; i++)
                {
                 playerGuess = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine($"This is the looping part {i}");
                    if (playerGuess == randomNumber)
                    {
                        Console.WriteLine("You are correct");
                        break;
                    }
                    else if (playerGuess < randomNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (playerGuess > randomNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }else if(numberofAttempts == 4)
                    {
                       Console.WriteLine("Numbers of attempt has been reached");
                       break;
                    }
                   
                }

            Console.ReadLine();

        }


        static void Greetings(string name, int age)
        {
            Console.WriteLine(" good morning to all nupat coders and you " + name + " " + " and you're " + age);
        }


        static int cube(int num)
        {
            int result = num * num * num;
            return result;

        }


        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {

                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;

        }

        static string GetDay(int dayNum)
        {
            String dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;


                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;


                case 4:
                    dayName = "Thursday";
                    break;


                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid day number";
                    break;

            }
            return dayName;
        }

        static int GetPow(int baseNum, int PowerNum)
        {
            int result = 1;
            for (int i = 0; i < PowerNum; i++)
            {
                result = result * baseNum;

            }
            return result;
        }




        static int Multiply(int num, int num2)
        {
            return num * num2;
        }

    }

}





