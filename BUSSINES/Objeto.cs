using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BUSSINES
{
    public abstract class Objeto
    { 
        static protected List <Objeto> ObjetosExistentes = new List<Objeto>();
        public Coordenada Posicion { get; set; }
        public Bitmap Forma { get; set; }

        public Objeto (int x, int y )
        {
            Posicion = new Coordenada(x, y);
            ObjetosExistentes.Add(this);
        }
        public int Ancho
        {
            get
            {
                return Forma.Width;

            }
        }
        public int Alto
        {
            get 
            {  
                return Forma.Height;
            }
        }
    }
}
