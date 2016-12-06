using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;


namespace modeloFinal
{
    public delegate void Delegado(Object obj, EventArgs args);

    [Serializable]
    public class Galpon<T> : IGuardarXML<T>
    {
        public List<T> lista;
        private int _cantidad;
        public event Delegado EsImpar;

        public Galpon()
        {
            this.lista = new List<T>();
        }
            
        public int Cantidad
        {
            
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("El valor ingresado fue 0");
                }
                else
                {
                    if (value.EsImpar())
                    {
                        this.EsImpar(value, new EventArgs());
                    }
                    else
                    {
                        this._cantidad = value;
                    }
                }
            }
        }



        public bool serializarXML(Galpon<T> arg)
        {
            XmlSerializer serializador;
            XmlTextWriter escritor;

            try
            {
                serializador = new XmlSerializer(typeof(Galpon<T>));
                escritor = new XmlTextWriter("galpon.xml", Encoding.UTF8);
                serializador.Serialize(escritor, arg);
                escritor.Close();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Error papu");
            }
        }
    }
}
