using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespuesDeExcepciones
{
    public class Deposito<T> : IEnumerable<T>
    {
        public List<T> misProducto;
        public int cantidadMaxima;

        #region Constructor

        public Deposito(int cantidadMax)
        {
            this.misProducto = new List<T>();
            this.cantidadMaxima = cantidadMax;
        }

        #endregion

        #region Metodos

        public bool Agregar(T prod)
        {
            return this + prod;
        }

        public bool NoHayLugar()
        {
            return this.misProducto.Count == this.cantidadMaxima;
        }

        public bool ExisteElElemento(T prod)
        {
            foreach (T item in this.misProducto)
            {
                if (item.Equals(prod))
                    return true;
            }
            return false;
        }

        

        #endregion

        #region Sobrecarca de Operadores

        public static bool operator +(Deposito<T> deposito, T prod)
        {
            if (!deposito.NoHayLugar() && !deposito.ExisteElElemento(prod))
            {
                deposito.misProducto.Add(prod);
                return true;
            }

            return false;
        }

        #endregion

        #region IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < misProducto.Count; i++)
            {
                yield return misProducto[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        
    }
}
