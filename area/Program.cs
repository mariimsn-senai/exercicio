using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double  area, bas, alt;
            string oper;


            Console.WriteLine("Escolha uma area");
            Console.WriteLine("Area do quadrado - a");
            Console.WriteLine("Area do triangulo - b");
            Console.WriteLine("Area do circulo - c");
            Console.WriteLine("Area do trapezio - d");
            Console.WriteLine("Area do retangulo - e");
            Console.WriteLine("Area do losango - f");
            oper = Console.ReadLine();

              switch (oper) 
            {
                    case "a":

                    
                    Console.WriteLine("Area do losango - f");                    
                    bas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area do losango - f");
                    alt = double.Parse(Console.ReadLine());
                    
                    area = bas * alt;
                    Console.WriteLine($"{bas}*{alt}" + area);
                    break;

            }
           
          
        }
    }
}
