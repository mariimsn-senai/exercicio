using System;

namespace mac
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Jose","123.456.789.12","ze@hotmail.com");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);

        }
    }
}
