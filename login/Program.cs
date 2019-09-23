using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string admLogin = "admin";
            string admPasswd = "admin";

            Console.Write("entre com o usuário:");
            string login = Console.ReadLine();
            Console.Write("entre com a senha:");
            string passwd = Console.ReadLine();

            if ((login == admLogin) && passwd == admPasswd){
                Console.WriteLine("Bem vondo admin:");
        }else{
            Console.WriteLine("Olá usuario");
            }
        }
    }
}
