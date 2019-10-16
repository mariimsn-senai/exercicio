using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.IntrumentoMusical
{
    public class InstrumentoMusical
    {
        string[] notas = {"Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};

        public string TocarMusica (){
            int nota = new Radom ().Next (nota.Length - 1);
            return notas[notas];
        }
    }
}