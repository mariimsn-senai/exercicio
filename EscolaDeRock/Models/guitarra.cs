using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public interface guitarra : IntrumentoMusical, Melodia, Harmonia
    {
    
    
        bool TrocarAcorde(){
            System.Console.WriteLine("Tocando acorde da Guitarra");
            return true;
        }
        bool TocarAcordes()
        {
            System.Console.WriteLine("tocando acordes do Baixo");
            return true;
        }
    
    }
}

