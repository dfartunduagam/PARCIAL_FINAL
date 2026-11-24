using System;
using System.Collections.Generic;
using System.Text;


namespace BUSSINES
{
    public class Carro:ObjetoMovil
    {
        public Carro(int X, int Y) : base(X, Y)
        {
            Forma = DATA.Asciimage.Load("carro");
        }
    }
}
