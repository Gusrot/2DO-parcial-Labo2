using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaAbstracta
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciaTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }

        public Centralita()
        {
            this._listaDeLlamadas=new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = 0, retorno2 = 0;

            switch (tipo)
            {
                case TipoLlamada.Local:

                    foreach (var item in this._listaDeLlamadas)
                    {
                        if (item is Local)
                            retorno = ((Local)item).CostoLlamada;
                    }

                    break;

                case TipoLlamada.Provincial:

                    foreach (var item in this._listaDeLlamadas)
                    {
                        if (item is Provincial)
                            retorno = ((Provincial)item).CostoLlamada;
                    }

                    break;
                case TipoLlamada.Todas:

                    foreach (var item in this._listaDeLlamadas)
                    {
                        if (item is Provincial)
                            retorno = ((Provincial)item).CostoLlamada;
                        else
                            if (item is Local)
                                retorno2 = ((Local)item).CostoLlamada;
                    }

                    return retorno + retorno2;

            }


            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this._listaDeLlamadas)
            {
                if (item is Local)
                {
                    sb.AppendLine(item.ToString());
                    sb.AppendLine("******************");
                }

                    
                else
                    if (item is Provincial)
                    {
                        sb.AppendLine(item.ToString());
                        sb.AppendLine("******************");
                    }
            }

            sb.AppendLine("La razon social: " + this._razonSocial);
            sb.AppendLine("\nGanancia total: " + this.GananciaTotal);
            sb.AppendLine("Ganancia Provincial: " + this.GananciaPorProvincial);
            sb.AppendLine("Ganancia Local: " + this.GananciaPorLocal);

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static Centralita operator +(Centralita central,Llamada nuevaLlamada)
        {
            if (central == nuevaLlamada)
            {
                Console.WriteLine("Ya se encuentra la llamda en la lista");
                return central;
            }

            central.AgregarLlamada(nuevaLlamada);
            return central;

        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            foreach (var item in central._listaDeLlamadas)
            {
                if (item == nuevaLlamada)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }
    }
}
