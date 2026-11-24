using System;
using System.Collections.Generic;
using System.Text;

namespace BUSSINES.Obejtos
{
    internal class Mina:Objeto
    {
        public Mina(int X, int Y) : base(X, Y)
        {
            Forma = DATA.Asciimage.Load("mina");
        }
    }
}
