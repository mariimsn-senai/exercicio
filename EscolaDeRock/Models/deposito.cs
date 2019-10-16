using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public class deposito
    {
        public static dictionary<int,IntrumentoMusical> Instrumentos =new Dictionary<int, Instrumentos>()
        {
            {1,new Baixo()},
            {2,new Bateria()},
            {3,new ContraBaixo()},
            {4,new guitarra()},
            {5,new Teclado()},
            {6,new Tambores()},
            {7,new violao()},
        };
    }
}