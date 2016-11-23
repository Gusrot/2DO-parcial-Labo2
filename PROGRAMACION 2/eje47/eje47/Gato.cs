using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eje47
{
    public class Gato : Animal,Mascota
    {
        private string _nombre;

        public Gato() { }

        public Gato(int patas,string nombre)
            : base(patas)
        {
            this._nombre = nombre;
        }

        public override void Comer()
        {
            Console.WriteLine("Come comida para gato");
        }

        public void Jugar()
        {
            Console.WriteLine("Juega como Gato");
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
