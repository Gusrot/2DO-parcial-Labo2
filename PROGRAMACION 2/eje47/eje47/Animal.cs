using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace eje47
{
    [XmlInclude(typeof(Gato))]
    [XmlInclude(typeof(Pez))]
    [XmlInclude(typeof(Araña))]
    public abstract class Animal
    {
        protected int _patas;

        public int Patas { get { return this._patas; } set { this._patas = value; } }

        public Animal()
        {
        
        }        

        public Animal(int patas):this()
        {
            this._patas = patas;
        }

        public virtual void Caminar()
        {
            Console.WriteLine("Este animal camina sobre {0} patas",this._patas);
        }

        public abstract void Comer();
    }
}
