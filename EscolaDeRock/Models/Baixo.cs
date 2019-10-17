using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentoMusical,Ipercussao,Harmonia
    {
        
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do baixo");
            return true;
        }
        public bool TocarAcordes()
        {
        System.Console.WriteLine("Tocando acorde do Baixo");
        return true;
        }
    }
}