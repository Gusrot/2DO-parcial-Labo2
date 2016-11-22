using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespuesDeExcepciones
{
    public class DepositoDePintura
    {
        public List<Producto> misProducto;
        public int cantidadMaxima;

        #region Constructor

        public DepositoDePintura(int cantidadMax)
        {
            this.misProducto = new List<Producto>();
            this.cantidadMaxima = cantidadMax;
        }

        #endregion

        #region Metodos

        public bool Agregar(Producto prod)
        {
            return this + prod;
        }

        public bool NoHayLugar()
        {
            return this.misProducto.Count == this.cantidadMaxima;
        }

        public bool ExisteElElemento(Producto prod)
        {
            foreach (Producto item in this.misProducto)
            {
                if (item == prod)
                    return true;
            }
            return false;
        }

        #endregion

        #region Sobrecarca de Operadores

        public static bool operator +(DepositoDePintura deposito, Producto prod)
        {
            if (!deposito.NoHayLugar() && !deposito.ExisteElElemento(prod))
            {
                deposito.misProducto.Add(prod);
                return true;
            }

            return false;
        }

        #endregion

        
    }
}
