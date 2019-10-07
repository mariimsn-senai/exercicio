using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; 
            int num2 = 0;
            int num3;

            Console.WriteLine("Digite o 1° número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
    }
}

