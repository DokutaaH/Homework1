using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1

            string[] names = new string[5];
            string[] phones = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("please enter name " + i);
                string nameInput = Console.ReadLine();

                while (nameInput == "" || nameInput == " ")
                {
                    Console.WriteLine("please enter a correct name");
                    nameInput = Console.ReadLine();
                }

                names[i] = nameInput;

                Console.WriteLine("please enter phone (only 11 digits are allowed)");
                bool phoneInputToParse = false;

                do
                {
                    string phoneInput = Console.ReadLine();
                    phoneInputToParse = long.TryParse(phoneInput, out long result);

                    if (result > 9999999999 && result < 100000000000)
                    {
                        phones[i] = phoneInput;
                    }
                    else
                    {
                        phoneInputToParse = false;
                    }

                    if (phoneInputToParse == false)
                    {
                        Console.WriteLine("please enter a phone with only 11 digits");
                    }
                } while (phoneInputToParse == false);
            }

            Console.WriteLine("the list you entered is as follows:");
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine("line " + j + ": " + names[j] + " - " + phones[j]);
            }

            // Homework 2

            double a;
            double b;
            double c;
            bool tryParse = false;

            Console.WriteLine("Please enter digit a");

            do
            {
                string lineToParse = Console.ReadLine();
                tryParse = double.TryParse(lineToParse, out double result);

                if (!tryParse)
                {
                    Console.WriteLine("Please enter a digit");
                }

                a = result;
               
            } while (!tryParse);

            Console.WriteLine("Please enter digit b");

            do
            {
                string lineToParse = Console.ReadLine();
                tryParse = double.TryParse(lineToParse, out double result);

                if (!tryParse)
                {
                    Console.WriteLine("Please enter a digit");
                }

                b = result;

            } while (!tryParse);

            Console.WriteLine("Please enter operation (only +, -, *, / and % are allowed)");
            
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    c = a + b;
                    Console.WriteLine($"{a} {op} {b} = {c}");
                    break;

                case "-":
                    c = a - b;
                    Console.WriteLine($"{a} {op} {b} = {c}");
                    break;

                case "*":
                    c = a * b;
                    Console.WriteLine($"{a} {op} {b} = {c}");
                    break;

                case "/":
                    c = a / b;
                    Console.WriteLine($"{a} {op} {b} = {c}");
                    break;

                case "%":
                    c = a % b;
                    Console.WriteLine($"{a} {op} {b} = {c}");
                    break;

                default:
                    Console.WriteLine("Please enter a correct operator");
                    break;
            }
        }
    }
}
