using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public interface Baixo : InstrumentoMusical, Ipercussao, Harmonia
    {
        
        bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do baixo");
            return true;
        }
        bool TocarAcordes()
        {
        System.Console.WriteLine("Tocando acorde do Baixo");
        return true;
        }
    }
}