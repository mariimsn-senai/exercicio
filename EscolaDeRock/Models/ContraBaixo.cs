using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public class ContraBaixo:InstrumentoMusical, Ipercussao, Harmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do contrabaixo.");
            return true;
        }

        public bool TocarAcorde()
        {
            System.Console.WriteLine("tocando acordes do contrabaixo");
        }
    }
}