using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Sisesta esimene number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sisesta teine number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe ('+', '-', '*' või '/'");
            char userOperation = Convert.ToChar(Console.ReadLine());

            switch (userOperation)
            {
                case '+':
                    AddTwoNumbers(num1, num2);
                    break;
                case '/':
                    DivideTwoNumbers(num1, num2);
                    break;
                case '*':
                    MultiplyTwoNumbers(num1, num2);
                    break;
                    




                   

            
            }
            


            {


            }




        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result} ");

        }

        private static void DivideTwoNumbers(int x, int y)
        {
            int result = x / y;
            Console.WriteLine($" {x} / {y} = {result}. ");

        }

        private static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($" {x} * {y} = {result}.");

        }

    }
}
