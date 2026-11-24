using BUSSINES.Obejtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUSSINES
{
    public class Juego
    {
        public Carro Carro {get; protected set;}
        public Mina Mina1 {get; protected set;}
        public Mina Mina2 {get; protected set;}
        public Mina Mina3 {get; protected set;}
        public List<Objeto> Objetos {get; protected set;}
        public List<ObjetoMovil> ObjetosMoviles { get; protected set; }
        public List<Objeto> ObjetosEstaticos {  get; protected set; }

        public Juego()
        {
            Carro = new Carro (0,0);
            Mina1 = new Mina (95,70);
            Mina2 = new Mina (310,137);
            Mina3 = new Mina (88,282);

            ObjetosMoviles = [Carro];
            ObjetosEstaticos = [Mina1, Mina2, Mina3];

            Objetos = new List<Objeto>();
            Objetos.AddRange (ObjetosMoviles);
            Objetos.AddRange (ObjetosEstaticos);
        }
        public void MoverObjeto(ObjetoMovil Objeto, Direccion direccion)
        {
            switch (direccion) 
            {
                case Direccion.Arriba: if (Objeto.Posicion.Y <= 0) return; Objeto.MoverArriba(); break;
                case Direccion.Abajo: if ((Objeto.Posicion.Y + Objeto.Alto) >= 489) return; Objeto.MoverAbajo(); break;
                case Direccion.Derecha: if ((Objeto.Posicion.X + Objeto.Ancho )<= 489) return; Objeto.MoverDerecha(); break;
                case Direccion.Izquierda: if (Objeto.Posicion.X <= 0) return; Objeto.MoverIzquierda(); break;


            }
        }
    }
}
