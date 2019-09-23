using System;

namespace areaprof
{
    class Program
    {
        static void Main(string[] args)
        {
           string opcao = "";
           Console.WriteLine("Calcula Area");
           Console.WriteLine("1 - triangulo");
           Console.WriteLine("2 - quadrado");
           Console.WriteLine("3 - losango");
           Console.WriteLine("4 - trapezio");
           Console.WriteLine("5 - retangulo");
           Console.WriteLine("6 - circulo");
           Console.Write("Escolha uma opção: ");
           opcao = Console.ReadLine();
           switch(opcao){
               case "1":
               Console.WriteLine("Área do Triangulo");
               Console.Write("Entre com a Base: ");
               double baseTri = double.Parse(Console.ReadLine());
               Console.Write("Entre com a altura: ");
               double alTri = double.Parse(Console.ReadLine());
               double areaTri = (baseTri * alTri) / 2;
               Console.WriteLine("A área do triangulo é: " + areaTri);
               break;
               case "2":
               Console.WriteLine("Área do Quadrado");
               Console.Write("Qual o lado do Quadrado? ");
               double ladoQuad = double.Parse(Console.ReadLine());
               double areaQuad = ladoQuad * ladoQuad;
               Console.WriteLine("A área do quadrado é: " + areaQuad);
               break;
              
           }

        }
    }
}
