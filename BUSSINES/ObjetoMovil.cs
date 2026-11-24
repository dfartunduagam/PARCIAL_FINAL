using System;
using System.Collections.Generic;
using System.Text;

namespace BUSSINES
{
    public abstract class ObjetoMovil: Objeto
    {
        public ObjetoMovil(int X, int Y): base(X, Y) { }
        public void MoverDerecha() => Posicion.X++;
        public void MoverIzquierda() => Posicion.X--;
        public void MoverArriba() => Posicion.Y--;
        public void MoverAbajo() => Posicion.Y++;
    }
}
