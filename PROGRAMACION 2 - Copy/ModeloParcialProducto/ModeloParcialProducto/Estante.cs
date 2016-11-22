using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialProducto
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        public float ValorEstanteTotal { get { return this.GetValorEstante(); } }

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        private float GetValorEstante()
        {
            float precio=0;

            precio += this.GetValorEstante(ETipoProducto.Todos);

            return precio;
        }
        public float GetValorEstante(ETipoProducto tipo)
        {
            float auxPrecio=0;

            switch (tipo)
            {
                case ETipoProducto.Galletita:
                    foreach(Producto item in this._productos)
                    {
                        if (item is Galletita)
                        {
                            Galletita auxGalletita;
                            auxGalletita = (Galletita)item;
                            auxPrecio += item.Precio;
                        }
                            
                    }
                    break;
                case ETipoProducto.Gaseosa:
                    foreach (Producto item in this._productos)
                    {
                        if (item is Gaseosa)
                        {
                            Gaseosa auxGalletita;
                            auxGalletita = (Gaseosa)item;
                            auxPrecio += item.Precio;
                        }

                    }
                    break;
                case ETipoProducto.Jugo:
                    foreach (Producto item in this._productos)
                    {
                        if (item is Jugo)
                        {
                            Jugo auxGalletita;
                            auxGalletita = (Jugo)item;
                            auxPrecio += item.Precio;
                        }

                    }
                    break;
                case ETipoProducto.Todos:
                    foreach (Producto item in this._productos)
                    {
                        if (item is Gaseosa)
                        {
                            Gaseosa auxGalletita;
                            auxGalletita = (Gaseosa)item;
                            auxPrecio += item.Precio;
                        }

                    }
                    foreach (Producto item in this._productos)
                    {
                        if (item is Galletita)
                        {
                            Galletita auxGalletita;
                            auxGalletita = (Galletita)item;
                            auxPrecio += item.Precio;
                        }

                    }
                    foreach (Producto item in this._productos)
                    {
                        if (item is Jugo)
                        {
                            Jugo auxGalletita;
                            auxGalletita = (Jugo)item;
                            auxPrecio += item.Precio;
                        }

                    }
                    break;
                default:
                    break;
            }
            return auxPrecio;
        }

        public static string MostrarEstante(Estante est)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in est._productos)
            {
                if (item is Jugo)
                {
                    Jugo aux;
                    aux = (Jugo)item;
                    sb.AppendLine(aux.MostrarJugo());
                }
                if (item is Gaseosa)
                {
                    Gaseosa aux;
                    aux = (Gaseosa)item;
                    sb.AppendLine(aux.MostrarGaseosa());
                }
                if (item is Galletita)
                {
                    Galletita aux;
                    aux = (Galletita)item;
                    sb.AppendLine(aux.MostrarGalletita());
                }
            }

            return sb.ToString();
        }


        public static bool operator ==(Estante est, Producto prod)
        {
            foreach (Producto item in est._productos)
            {
                if (est._productos.Contains(item))
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estante est, Producto prod)
        {
            return !(est==prod);
        }

        public static bool operator +(Estante est, Producto prod)
        {
            if (est._productos.Count < est._capacidad)
            {
                if (est != prod)
                {
                    est._productos.Add(prod);
                    return true;
                }
                else return false;
            }
            else return false;


        }

        public static Estante operator -(Estante est, Producto prod)
        {
            if (est == prod)
                est._productos.Remove(prod);
            return est;
        }

        public static Estante operator -(Estante est, ETipoProducto tipo)
        {
            Estante aux;
            aux = est;


            switch (tipo)
            {
                case ETipoProducto.Galletita:
                        for (int i = 0; i < est._productos.Count; i++)
                        {
                            if (est._productos[i] is Galletita)
                                aux._productos.Remove(est._productos[i]);
                        }
                    
                    break;
                case ETipoProducto.Gaseosa:
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        if (est._productos[i] is Gaseosa)
                            aux._productos.Remove(est._productos[i]);
                    }
                    break;
                case ETipoProducto.Jugo:
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        if (est._productos[i] is Jugo)
                            aux._productos.Remove(est._productos[i]);
                    }
                    break;
                case ETipoProducto.Todos:
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        if (est._productos[i] is Galletita)
                            aux._productos.Remove(est._productos[i]);
                    }
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        if (est._productos[i] is Gaseosa)
                            aux._productos.Remove(est._productos[i]);
                    }
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        if (est._productos[i] is Jugo)
                            aux._productos.Remove(est._productos[i]);
                    }
                    break;
                default:
                    break;
            }
            return aux;
        }
    }
}
