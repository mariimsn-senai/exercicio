using System;

namespace pardois {
    class Program {
        static void Main(string[] args) 
        {
            int num = 0;
            do{
                Console.WriteLine("Digite o número:");
                num = int.Parse(Console.ReadLine());

                if ((num % 2) != 0){
                    Console.WriteLine("é impar");
                } else {
                    Console.WriteLine("é par");
                }

            }while (num !=22);
        }
    }
}
