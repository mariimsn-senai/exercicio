using System;
using EscolaDeRock;
namespace EscolaDeRock.Models
{
    public class violao : IntrumentoMusical,Harmonia
    {
        public bool TrocaAcordes()
        {
            System.Console.WriteLine("Trocar acordes de Violão:");
            return true;
        }
        
    }
}