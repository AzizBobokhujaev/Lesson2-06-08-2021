using System;

namespace Lesson3ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----------HomeWork_2----------");
            int A, B;
            Console.Write("A = "); A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = "); B = Convert.ToInt32(Console.ReadLine());
            if (A != B)
            {
                if (A > B) { B = A; }
                if (A < B) { A = B; }
            }
            else if (A == B)
            {
                A = 0;
                B = 0;
            }
            System.Console.WriteLine($"Result: A = {A}");
            System.Console.WriteLine($"Result: B = {B}");

            System.Console.WriteLine("----------HomeWork_3----------");
            int operand1, operand2 ,result;
            Console.Write("num1 = "); operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2 = "); operand2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pleace enter a sign: "); string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        result= operand1 + operand2;
                        Console.WriteLine($"Result: {result}");
                    }
                    break;
                case "-":
                    {
                        result= operand1 - operand2;
                        Console.WriteLine($"Result: {result}");
                    }
                    break;
                case "*":
                    {
                        result= operand1* operand2;
                        Console.WriteLine($"Result: {result}");
                    }
                    break;
                case "/":
                    {
                        if (operand2 == 0)
                        {
                            System.Console.WriteLine("Err: Trying to divide by zero");
                        }
                        else
                        {
                            result= operand1 / operand2;
                            Console.WriteLine($"Result: {result}");
                        }
                    }
                    break;
                default:
                    System.Console.WriteLine("Err: Undifined sign");
                    break;
            }
            System.Console.WriteLine("----------HomeWork_4----------");
            int number;
            Console.Write("Enter a number between 0 and 100: "); number=Convert.ToInt32(Console.ReadLine());
            if (number<0 || number>100)
            {
                System.Console.WriteLine("You have not entered the appropriate number");
            }else if (number>=0 && number<=14)
            {
                System.Console.WriteLine("In-between [0-14]");
            }else if (number>=15 && number<=35)
            {
                System.Console.WriteLine("In-between [15-35]");
            }else if (number>=36 && number<=50)
            {
                System.Console.WriteLine("In-between [36-50]");
            }else if (number>=51 && number<=100)
            {
                System.Console.WriteLine("In-between [51-100]");
            }
            
        }
    }
}
