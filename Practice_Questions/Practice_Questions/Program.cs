using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean restart = true;

            do
            {

                Console.WriteLine("Please choose which task you want to execute");
                Console.WriteLine("For task 1 push 1");
                Console.WriteLine("For task 2 push 2");
                Console.WriteLine("For task 3 push 3");
                Console.WriteLine("For task 4 push 4");
                Console.WriteLine("For task 5 push 5");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Task1();
                }
                else if (choice == 2)
                {
                    Task2();
                }
                else if (choice == 3)
                {
                    Task3();
                }
                else if (choice == 4)
                {
                    Task4();
                }
                else
                {
                    Task5();
                }

                Console.WriteLine("Do you want to run another task, Y/N");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }
                Console.Clear();
            } while (restart);


        }
        public static void Task1() 
        {
            //Task1 - Vowel or Consonant

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------ Question 1 ------------------");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Please enter a letter and I will tell you whether it's a vowel or a consonant.");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine($"{userInput} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{userInput} is a consonant");
                    break;
            }
            
          //  Console.WriteLine("Please press enter to exit");
          //  Console.ReadKey();

            Console.ReadLine();

        }

        public static void Task2()
        {
            //Task2 - BMI Calculator

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------ Question 2 ------------------");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("This app will calculate your BMI (Body Mass Index)");
            Console.WriteLine("Please enter your weight in Kg's: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Now please enter your height in Cm's: ");
            float height = (float.Parse(Console.ReadLine()))/100;

            Console.WriteLine("Your BMI is: " + weight / (height * height));


        }
        public static void Task3()
        {
            //Task3 - Loop 20 times

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------ Question 3 ------------------");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("This app will calculate the sum of 20 numbers.");

            float total =0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Please enter number {i}:");
                total = total + float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum of the numbers you entered is: {total}");
        }

        public static void Task4()
        {
            //Task4 - Factorial of 10

           
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------ Question 4 ------------------");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("This app will calculate the factorial of 10");

            int i = 1;
            int total = 1; 
            while(i<= 10)
            {
                total*= i;
                i++;
            }

            Console.WriteLine($"The factorial of 10 is: {total}");


        }

        public static void Task5()
        {
            //Task 5 - Quadratic Equation Calculator

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------ Question 5 ------------------");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("This app will calculate a quadratic equation");

            double a, b, c, ans1, ans2;

            Console.WriteLine("Please enter in the value for a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the value for b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the value for c");
            c = double.Parse(Console.ReadLine());

            ans1 = (-1 * b + Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / (2 * a);
            ans2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            Console.WriteLine($"The value of x is {ans1} and {ans2}");

            Console.ReadLine();

        }
    }
    }

