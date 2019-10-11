using System;
namespace ByteBank.Cliente

{
    class Program
    {
        #region Cadastro
            
            
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
            System.Console.WriteLine();
        #endregion

        #region Cadastro do cliente

            Console.Clear();
            System.Console.WriteLine("Conta Corrente");
            Console.WriteLine("Digite a sua agencia: ");
            int Agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a conta: ");
            int conta = int.Parse(Console.ReadLine());


            contacorrente contacorrente = new contacorrente(Agencia,conta,cliente1);
            double saldo;
            do{
                Console.Write("Entre com o saldo ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo >= 0) {
                    contacorrente.saldo = saldo;
                } else {
                    Console.WriteLine("Valor do saldo deve ser positivo");
                }
            }while(saldo < 0);
            System.Console.WriteLine("Saldo Atualizado! ");
            Console.WriteLine();
        #endregion
        

        Cliente cliente2 = new Cliente("Cesar","5454454545","1@a.com");
        contacorrente contacorrente2 = new contacorrente(cliente2._Nome,123,123);
        
        #region Deposito
            string usuario = contaCorrente1.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Titular}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.Deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();

            
            
        #endregion
          
            
                }
            }
        
            




            

        }
    




