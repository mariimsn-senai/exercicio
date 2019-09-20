using System;

namespace par
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
        
            Console.WriteLine("Digite o número:");
            num1 = int.Parse(Console.ReadLine());
           

            if (num1 % 2 == 0)
                Console.WriteLine("é par");
            else 
                Console.WriteLine("é impar");
        }
    }
}
