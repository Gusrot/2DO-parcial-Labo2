using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eje47
{
    public class Pez : Animal,Mascota
    {
        private string _nombre;

        public Pez() { }

        public Pez(int patas,string nombre)
            : base(patas)
        {
            this._nombre = nombre;
        }

        public override void Comer()
        {
            Console.WriteLine("Come comida para Pez");
        }

        public void Jugar()
        {
            Console.WriteLine("Juega como Pez");
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
    }
}
