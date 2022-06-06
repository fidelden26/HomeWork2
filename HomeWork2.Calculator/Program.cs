using System;

namespace HomeWork2.Calculator
{
    internal class Program
    {
        static double Degree(double number3, double degree)
        {
            double result = 1.0;
            for (int i = 1; i <= degree; i++)
            {
                result = result * number3;
            }
            return result;

        }
        static ulong Factorial(ulong number4)
        {
            ulong result = 1;
            for (ulong i = 1; i <= number4; i++)
            {
                result = result * i;
            }
            return result;
        }
        static void MathematicalExpressions(string action, double number1, double number2)
        {
            switch (action)
            {
                case "+":
                    Console.WriteLine($"{number1}+{number2}={number1 + number2}");
                    break;

                case "-":
                    Console.WriteLine($"{number1}-{number2}={number1 - number2}");
                    break;

                case "/":

                    if (number2 == 0)
                    {
                        Console.WriteLine("it cannot be divided by 0");
                    }
                    else
                    {
                        Console.WriteLine($"{number1}/{number2}={number1 / number2}");
                    }

                    break;

                case "*":
                    Console.WriteLine($"{number1}*{number2}={number1 * number2}");
                    break;

                default:
                    Console.WriteLine("You entered the wrong character");
                    break;
            }

        }

        static void Main(string[] args)
        {                          //калькулятор
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Enter the desired action + - / * ^ n!");
                var action = Console.ReadLine();
                if (action == "+" || action == "-" || action == "/" || action == "*" || action == "^" || action == "n!")
                {
                    if (action == "^")
                    {
                        Console.WriteLine("Enter a number");
                        var any3 = double.TryParse(Console.ReadLine(), out var number3);
                        if (any3)
                        {
                            if (number3 <= 100)
                            {
                                Console.WriteLine("Enter a degree");
                                var any4 = double.TryParse(Console.ReadLine(), out var degree);
                                if (any4)
                                {
                                    if (degree <= 100)
                                    {
                                        Degree(number3, degree);
                                        Console.WriteLine($"{number3}^{degree}={Degree(number3, degree)}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The degree should not exceed 100");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You entered the wrong value!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The value of the number must not exceed 100");
                            }

                        }
                        else
                        {
                            Console.WriteLine("You entered the wrong value!");
                        }
                    }
                    if (action == "n!")
                    {
                        Console.WriteLine("Enter a number");
                        var any5 = ulong.TryParse(Console.ReadLine(), out var number4);
                        if (any5)
                        {
                            if (number4 <= 65)
                            {
                                Factorial(number4);
                                Console.WriteLine($"n!{number4}={Factorial(number4)}");
                            }
                            else
                            {
                                Console.WriteLine("The value should not exceed 65");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You entered the wrong value!");
                        }
                    }
                    if (action == "+" || action == "-" || action == "/" || action == "*")
                    {
                        Console.WriteLine("Enter a number1");
                        var any = double.TryParse(Console.ReadLine(), out var number1);
                        if (any)
                        {
                            Console.WriteLine("Enter a number2");
                            var any2 = double.TryParse(Console.ReadLine(), out var number2);
                            if (any2)
                            {
                                MathematicalExpressions(action, number1, number2);
                            }
                            else
                            {
                                Console.WriteLine("You entered the wrong value!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You entered the wrong value!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You entered the wrong character");
                }
                Console.WriteLine("Would you like to continue? Y/N");
                var yesNo = Console.ReadLine();
                if (yesNo == "Y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}