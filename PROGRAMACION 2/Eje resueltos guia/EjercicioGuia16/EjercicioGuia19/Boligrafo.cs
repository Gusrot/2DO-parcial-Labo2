using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia19
{
    namespace ejercicio19_boligrafo
    {
        class Boligrafo
        {
            private ConsoleColor _color;
            private int tinta;

            public Boligrafo(ConsoleColor color, int tintaDos)
            {
                this._color = color;

                if (tintaDos < 101)
                    this.tinta = tintaDos;
                else
                    Console.WriteLine("Supero la cantidad de tinta maxima");
            }

            public bool pintar(int gasto)
            {
                if (gasto > this.tinta)
                {
                    return false;
                }
                else
                {
                    this.tinta = this.tinta - gasto;
                    return true;
                }
            }

            public void recargar()
            {
                if (this.tinta == 0)
                {
                    this.tinta = 100;
                    Console.Write("\nTinta recargada");
                }
                else
                {
                    Console.Write("\nTodavia su boligrafo posee tinta");
                }
            }

            public int getTinta()
            {
                return this.tinta;
            }

            public ConsoleColor getColor()
            {
                return this._color;
            }
        }
    }
}
