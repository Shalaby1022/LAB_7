﻿using System;

namespace MyMathTask

{
    internal class MathTask
    {
        public class MyMath
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static int Subtract(int a, int b)
            {
                return a - b;
            }

            public static int Multiply(int a, int b)
            {
                return a * b;
            }

            public static double Divide(int a, int b)
            {
                if (b != 0)
                {
                    return (double)a / b;
                }
                else
                {
                    throw new DivideByZeroException("Error: Division by zero!");
                }
            }

            public static int Remainder(int a, int b)
            {
                return a % b;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Remainder (%)");
            Console.Write("Enter your choice (1-5): ");

            int choice = int.Parse((Console.ReadLine()));

            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            MyMath calculator = new MyMath();
            double result;


            switch (choice)
            {
                case 1:
                    result = MyMath.Add(number1, number2);
                    Console.WriteLine($"Result: {result}");
                    break;
                case 2:
                    result = MyMath.Subtract(number1, number2);
                    Console.WriteLine($"Result: {result}");
                    break;
                case 3:
                    result = MyMath.Multiply(number1, number2);
                    Console.WriteLine($"Result: {result}");
                    break;
                case 4:
                    try
                    {
                        result = MyMath.Divide(number1, number2);
                        Console.WriteLine($"Result: {result}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    result = MyMath.Remainder(number1, number2);
                    Console.WriteLine($"Result: {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}