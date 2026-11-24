using System;
using System.Collections.Generic;
using System.Text;

namespace BUSSINES
{
    internal class Juego
    {
        public Carro Carro {get; protected set;}
        public List<Objeto> Objetos {get; protected set;}
        public List<ObjetoMovil> ObjetosMoviles { get; protected set; }
        public List<Objeto> ObjetosEstaticos {  get; protected set; }

        public Juego()
        {
            Carro = new Carro (0,0);

            ObjetosMoviles = [Carro];
            ObjetosEstaticos = [Mina];
        }
    }
}
