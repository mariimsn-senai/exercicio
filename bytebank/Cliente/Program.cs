using System;
namespace ByteBank.Cliente

{
    class Program
    {
        #region Cadastro
        #region Cadastro do cliente
            
            
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
            Console.WriteLine();
        #endregion

        Cliente cliente2 = new Cliente(Nome, Cpf, Email);

            
            
          
            
                }
            }
        
            




            

        }
    




