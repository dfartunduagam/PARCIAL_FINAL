using System;
using System.Collections.Generic;
using System.Text;

namespace BUSSINES
{
    public abstract class Objeto
    { 
        static protected List <Objeto> ObjetosExistentes = new List<Objeto>();
        public Coordenada Posicion { get; set; }
        public string[] Forma { get; set; }

        public Objeto (int x, int y )
        {
            Posicion = new Coordenada(x, y);
            Forma = new string[0];
            ObjetosExistentes.Add(this);
        }
    }
}
