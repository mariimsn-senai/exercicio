using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Tambores : InstrumentoMusical, Ipercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter Ritmo Tambores");
            return true;
        }
    }
    
}