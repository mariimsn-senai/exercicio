using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1; 
            string num2;
            string num3;

            Console.WriteLine("Digite o 1° número:");
            num1 = Console.ReadLine();
            Console.WriteLine("Digite o 2° número");
            num2 = Console.ReadLine();
            Console.WriteLine("Digite o operador:");
            num3 = Console.ReadLine();

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
    }
}

