using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        public float area;
        public float lado;
        public float perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;


        //Metodos

        public void Rectangulo(Punto vertice1, Punto vertice3)
        { }
    }

    public class Punto
    {
        private int _x;
        private int _y;


        //Metodos

        public int getX()
        { return 1; }
        public int getY()
        { return 2;}
    }
}
