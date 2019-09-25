using System;

namespace seis
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;

            Console.Write("digite primeiro numero:");  
            num = int.Parse(Console.ReadLine());  
            Console.Write("digite segundo numero:");  
            num1 = int.Parse(Console.ReadLine());  
            Console.Write("digite terceiro numero:");  
            num2 = int.Parse(Console.ReadLine());  
            Console.Write("digite quarto numero:");  
            num3 = int.Parse(Console.ReadLine());  
            Console.Write("digite quinto numero:");  
            num4 = int.Parse(Console.ReadLine());  
            Console.Write("digite sexto numero:");  
            num5 = int.Parse(Console.ReadLine());  

        
            int[] vetor2 = {num, num1, num2, num3, num4, num5};

                       if (num % 2 == 0)
                Console.WriteLine("é par");
            else 
                Console.WriteLine("é impar");

                  if (num1 % 2 == 0)
                Console.WriteLine("é par");
            else 
                Console.WriteLine("é impar");

                  if (num2 % 2 == 0)
                Console.WriteLine("é par");
            else 
                Console.WriteLine("é impar");

                  if (num3 % 2 == 0)
                Console.WriteLine("é par");
            else 
                Console.WriteLine("é impar");

                  if (num4 % 2 == 0)
                Console.WriteLine("é par");
            else 
                Console.WriteLine("é impar");

                  if (num5 % 2 == 0)
                Console.WriteLine("é par");
            else 
                Console.WriteLine("é impar");

        }
    }
}
