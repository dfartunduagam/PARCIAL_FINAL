using System;
using System.Collections.Generic;
using System.Text;

namespace BUSSINES
{
    internal class ObjetoMovil: Object
    {
        public ObjetoMovil(int X, int Y): base(X, Y) { }
        public void MoverDerecha() => Posicion.X++;
        public void MoverIzquierda() => Posicion.X--;
        public void MoverArriba() => Posicion.Y--;
        public void MoverAbajo() => Posicion.Y++;
    }
}
