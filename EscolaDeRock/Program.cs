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
            string[] intesMenuPrincipal = Enum.GetName(typeof(FormacaoEnum));
            string[] intesMenuCategoria = Enum.GetName(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                " -0   ",
                " -1   "
            };

            int opcoesFormacaoSelecionada = 0;
            string menuBar = "===============";

            do{
                bool formacaoEscolha = false;
                do{
                    #region Area do menu
                    System.Console.WriteLine(menuBar);
                    System.BackgroundColor = ConsoleColor.DarkCyan;
                    System.BackgroundColor = ConsoleColor.DarkBlack;
                    System.Console.WriteLine("     seja bem vindo   ");
                    System.Console.WriteLine("     Escolha  uma formação     ");
                    Console.RasetColor();
                    System.Console.WriteLine(menuBar);

                    for(int i=0; i< opcoesFormacao.Count; i++)
                    {
                        string titulo= itensMenuPrincipal[i];
                        if(opcoesFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = Console.DarkRed;
                            System.Console.WriteLine(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));

                        }else{
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                    }
                    var key = Console.ReadKey(true).key;

                    switch(key)
                    {
                        case ConsoleKey.UpArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada; 
                        break;

                        case ConsoleKey.DownArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.Enter:
                        formacaoEscolha = true;
                        break;

                    }
                    #endregion
                } while(false);
            }while(!querSair);
        }
    }
}
