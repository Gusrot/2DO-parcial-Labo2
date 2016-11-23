using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Clases
{
    [XmlInclude(typeof(Local))]
    public class Tienda:Local,IArchivos<Tienda>
    {
        private int _legajo;

        protected override int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public int legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        public Tienda(string direccion, int ancho, int legajo)
            : base(direccion, ancho)
        {
            this._legajo = legajo;
        }

        public Tienda()
        { }

        public string ExponerDatos(Local l)
        {
            return l.ToString();
        }

        public bool guardar(string archivo, Tienda datos)
        {
            XmlTextWriter writer;
            XmlSerializer ser;

            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Tienda));

                ser.Serialize(writer, datos);

                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new NoGuardaException(e);
            }
        }

        public bool leer(string archivo, out Tienda datos)
        {
            XmlTextReader reader;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(archivo);
                ser = new XmlSerializer(typeof(Tienda));

                datos = (Tienda)ser.Deserialize(reader);

                reader.Close();

                return true;
            }
            catch (Exception e)
            {
                datos = default(Tienda);
                throw new NoLeeException(e);
            }
        }
    }
}
