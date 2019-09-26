using System;

namespace seisdois
{
    class Program
    {
        static void Main(string[] args)
    {
        int cont;
        int par = 0;
        int impar = 0;
        int[] vetor = new int[6];
        for ( cont = 0; cont < 6; cont++){ 
        Console.Write($"digite o {cont+1} número");
        vetor[cont] = int.Parse(Console.ReadLine());
        }
        foreach(int nem in vetor){
            if (nem % 2 == 0){
                    par++;
            }else {
                impar++;
            }
         

        }
        Console.WriteLine($"Você tem {par} numeros pares e {impar} numeros impar"); 
    }
  }
}
