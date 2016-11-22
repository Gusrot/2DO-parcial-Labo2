using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLLamadas;
        protected string _razonSocial;

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }

        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }

        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }

        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLLamadas;
            }

        }
        
        public Centralita()
        {
            _listaDeLLamadas =new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = 0,retorno2=0;




            switch (tipo)
            {
                case TipoLlamada.Local:

                    foreach (var item in this._listaDeLLamadas)
                    {
                        if (item is Local)
                        {
                            /*local = (Local)item;
                            retorno += local.CostoLlamada;*/
                            retorno = ((Local)item).CostoLlamada;
                        }
                    }

                    break;

                case TipoLlamada.Provincial:

                    foreach (var item in this._listaDeLLamadas)
                    {
                        if (item is Provincial)
                        {
                            retorno = ((Provincial)item).CostoLlamada;
                        }
                    }

                    break;
                case TipoLlamada.Todas:

                    foreach (var item in this._listaDeLLamadas)
                    {
                        if (item is Provincial)
                        {
                            retorno = ((Provincial)item).CostoLlamada;
                        }
                        else
                        {
                            if (item is Local)
                            {
                                retorno2 = ((Local)item).CostoLlamada;
                            }
                        }
                    }

                    return retorno + retorno2;

            }
            

            return retorno;
        }

        public void Mostrar()
        {
            Console.WriteLine("La razon social: "+this._razonSocial);
            Console.WriteLine("\nGanancia total: " + this.GananciaTotal);
            Console.WriteLine("Ganancia Provincial: " + this.GananciaPorProvincial);
            Console.WriteLine("Ganancia Local: " + this.GananciaPorLocal);


            

            foreach (Llamada item in this._listaDeLLamadas)
            {
                Provincial prov;
                Local local;

                if (item.GetType() == typeof(Provincial))
                {
                    prov = (Provincial)item;
                    prov.Mostrar();
                }
                if (item.GetType() == typeof(Local))
                {
                    local = (Local)item;
                    local.Mostrar();
                }
            }
            
            

        }

        public void OrdenarLlamadas()
        {
            this._listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);            
        }
    }
}
