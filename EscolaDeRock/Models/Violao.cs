using System;
using EscolaDeRock;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public class violao : InstrumentoMusical,Harmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Trocar acordes de Violão:");
            return true;
        }
        
    }
}