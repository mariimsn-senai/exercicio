using System;

namespace escolha
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;
            string oper;

            Console.WriteLine("Digite o 1° número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            oper = Console.ReadLine();

           

            switch (oper) 
            {
                    case "+":
                    resultado = num1 + num2;
                     Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                
                    case "-":
                    resultado = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
            
                    case "*":
                    resultado = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                    case "/":
                    resultado = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                    case "%":
                    resultado = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    break;

                    default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }
                
                 
                   
                
            
        }
    }
}
