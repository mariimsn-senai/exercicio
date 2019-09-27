using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste teste1 = new Teste("Alexandre","123.123.123.32");
            Teste teste2 = new Teste("Marina","123.456.523.22","Odonto");
            Console.WriteLine("Nome::" + teste1.Nome);
            Console.WriteLine("Cpf:" + teste1.Cpf);
            Console.WriteLine("Curso:" + teste1.Curso);

             Console.WriteLine("Nome::" + teste2.Nome);
            Console.WriteLine("Cpf" + teste2.Cpf);
            Console.WriteLine("Curso:" + teste2.Curso);

        }
    }
}
