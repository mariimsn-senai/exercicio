using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            int media;
            int resul = 2019;
           

                   
                  

                     do{ 
                          Console.WriteLine("Qual ano você nasceu?");
                          ano = int.Parse(Console.ReadLine());
                          if((ano > 2021) || (ano < 0)){ 
                            Console.WriteLine("data invalida");
                     }
                
                        }while ((ano > 2021) || (ano < 0));
                         
                   media = resul - ano;

                   if (media < 3){
                    Console.WriteLine("recém-nascido");
                }else if ((media >= 3) && (media <=11 )) {
                    Console.WriteLine("criança");
                }else if ((media >= 12) && (media <=19 )) {
                    Console.WriteLine("adolescente");
                }else if ((media >= 20) && (media <=65 )) {
                    Console.WriteLine("adulto");
                }else if (media > 65) {
                    Console.WriteLine("idoso");
                }
        

            
            
        }
    }
}
