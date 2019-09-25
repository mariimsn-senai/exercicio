using System;

namespace seisdois
{
    class Program
    {
        static void Main(string[] args)
        {
                int num;
                int i;
                 
            Console.Write("digite primeiro numero:");  
            num = int.Parse(Console.ReadLine());  

     

        { 
           for(i = 0; i < num; i++){
                num [i] = i;

           }

             if (num % 2 == 0)
                Console.WriteLine("é par");
            else 
                Console.WriteLine("é impar");

        }
    }
  }
}
