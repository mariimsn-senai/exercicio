using System; 
using EscolaDeRock.Models;
using System.Collections.Generic;

namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentoEnum : int
    {
        Baixo,
            Bateria,
            ContraBaixo,
            guitarra,
            Teclado,
            Tambores,
            violao
    };
    enum CategoriaEnum : int
    {
        Harmonia,
        percurssão,
        Melogia,
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] intesMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] intesMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                        "    -0           ",
                        "    -1       "
            };

            int opcoesFormacaoSelecionada = 0;
            string menuBar = "============================================";
            bool querSair = true;
            do{
                bool formacaoEscolhida = false;
                do{
                    #region Area do menu
                    Console.Clear();
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    System.Console.WriteLine("          Seja bem vindo!!                ");
                    System.Console.WriteLine("          Escolha  uma formação           ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    for(int i=0; i< opcoesFormacao.Count; i++)
                    {
                        string titulo = intesMenuPrincipal[i];
                        if(opcoesFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));
                            Console.ResetColor();

                        }else{
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                    }
                    var key = Console.ReadKey(true).Key;

                    switch(key)
                    {
                        case ConsoleKey.UpArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada; 
                        break;

                        case ConsoleKey.DownArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.Enter:
                        formacaoEscolhida = true;
                        break;

                    }
                    #endregion
                } while(!formacaoEscolhida);
            }while(!querSair);
        }
    }
}
