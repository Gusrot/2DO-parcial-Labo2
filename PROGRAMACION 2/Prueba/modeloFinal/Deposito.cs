using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public class Deposito
    {
        public List<Producto> listaDeProductos;

        public Deposito()
        {
            this.listaDeProductos = new List<Producto>();
        }
        

        public static List<Producto> operator +(Deposito depositoUno, Deposito DepositoDos)
        {
            List<Producto> nuevaLista;
            nuevaLista = new List<Producto>();
            bool flag = false;

            foreach (Producto itemUno in depositoUno.listaDeProductos)
            {
                nuevaLista.Add(itemUno);
            }

            foreach (Producto itemDos in DepositoDos.listaDeProductos)
            {
                for (int i = 0; i < nuevaLista.Count; i++)
                {
                    if (itemDos == nuevaLista[i])
                    {
                        nuevaLista[i].stock = nuevaLista[i].stock + itemDos.stock;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    nuevaLista.Add(itemDos);
                }
            }

            return nuevaLista;
        }
    }
}
