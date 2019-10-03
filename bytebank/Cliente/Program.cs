using System;
namespace ByteBank.Cliente

{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ByteBank - cadastro de Clientes ");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Cpf: ");
            string Cpf = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Cliente cliente1 = new Cliente(Nome, Cpf, Email);

            bool TrocouSenha = false;

            do
            {
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                TrocouSenha = cliente1.TrocaSenha(senha);
                if (TrocouSenha)
                {
                    Console.WriteLine("senha alterada com sucesso");
                }
                else
                {
                    Console.WriteLine("Senha inválida");
                }
            } while (!TrocouSenha);

            System.Console.WriteLine("Conta Corrente");
            Console.WriteLine("Digite o nome do titular: ");
            string Titular = Console.ReadLine();
            Console.WriteLine("Digite a sua agencia: ");
            string Agencia = Console.ReadLine();
            Console.WriteLine("Digite o numero: ");
            string Numero = Console.ReadLine();

            contacorrente cliente1 = new contacorrente(Titular, Agencia, Numero);

            do{
                
            }
        }
    }
}


