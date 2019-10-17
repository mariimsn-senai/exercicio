using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{

        public class Teclado : InstrumentoMusical, Melodia, Harmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Piano");
            return true;
    
        }
        public bool TocarSolo()
        {
        System.Console.WriteLine("tocando o solo do teeclado");
        return true;
        }
    }
}