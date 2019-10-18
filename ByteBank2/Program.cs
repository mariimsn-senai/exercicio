using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(1, 1, "Alexandre");

            DepositarConta(contaCorrente1);
            SacarConta(contaCorrente1);

            ContaBancaria contaEsperimental1 = new ContaEsperimental(1, 2, "Cesar");
            DepositarConta(contaEsperimental1);
            SacarConta(contaEsperimental1);

            TransferirEmConta(contaEsperimental1,contaCorrente1);
        }
            #region Depósito

            public static void DepositarConta(ContaBancaria contaBancaria)
            {

            string usuario = contaBancaria.Titular;
            Console.Clear();
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {contaBancaria.Agencia} Conta: {contaBancaria.Titular}");
            System.Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaBancaria.Deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            #endregion
            }

            public static void SacarConta(ContaBancaria contaBancaria)
            {

            #region Saque.
            Console.Clear();
            string usuario = contaBancaria.Titular;
            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {contaBancaria.Agencia} Conta: {contaBancaria.Titular}");
            System.Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Saque: ");
            double valor = double.Parse(Console.ReadLine());
            contaBancaria.Saque(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            }
                
            #endregion

            public static void TransferirEmConta(ContaBancaria conta1, ContaBancaria conta2)
            {

            #region Transferência.
            Console.Clear();
            string usuario = conta1.Titular;
            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {conta1.Agencia} Conta: {conta1.Titular}");
            System.Console.WriteLine($"Saldo: {conta1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor da Transferência: ");
            double valor = double.Parse(Console.ReadLine());
            if(conta1.Transferencia(conta2,valor)){
                System.Console.WriteLine("Transferência Efetuada.");
                
            } else{
                System.Console.WriteLine("Não foi possivel Realizar a essa ação.");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {conta1.Saldo}");
            System.Console.WriteLine();
                
            #endregion
            }
        
    }
}
