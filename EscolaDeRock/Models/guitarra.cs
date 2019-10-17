using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public class guitarra : InstrumentoMusical, Melodia, Harmonia
    {
    
    
        public bool TocarSolo(){
            System.Console.WriteLine("Tocando acorde da Guitarra");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("tocando acordes do Baixo");
            return true;
        }
    
    }
}

