using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eje47
{
    public class Araña : Animal,Mascota
    {
        private string _nombre;

        public Araña() { }

        public Araña(int patas,string nombre)
            : base(patas)
        {
            this._nombre = nombre;
        }

        public override void Comer()
        {
            Console.WriteLine("Come comida para arañas");
        }
        

        public void Jugar()
        {
            Console.WriteLine("Juega como Araña");
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
