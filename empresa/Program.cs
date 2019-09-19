using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
         
            double salario;
            double aumento = 0;
            double percentual = 30.0 / 100.0;
            string oper;

        Console.WriteLine("Digite o seu salario");
        salario = double.Parse(Console.ReadLine());

        

            if (salario < 500){ 
              salario = salario + (salario * percentual);
              Console.WriteLine("Seu novo salario é:" + salario );
             }

                 
            else{ 
            Console.WriteLine("Não aumentou");
            } 
        }
    }
}
