using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
      {  
            int alt, i, j, quantidade, b, count = 1;  
            Console.Write("digite a altura:");  
            alt = int.Parse(Console.ReadLine());  
            Console.Write("digite a quantidade:");  
            quantidade = int.Parse(Console.ReadLine()); 
         
       for (b = 1; b < quantidade; b++) {  
            for (j = 1; j <= alt; j++)  
             { 
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");  
                Console.WriteLine(); 
            }  
         
        } 




        
        
        }

      }
    }
}
