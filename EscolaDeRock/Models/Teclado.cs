using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{

        public class Teclado : IntrumentoMusical, Melodia, Harmonia
    {
        public bool TocarAcorde()
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