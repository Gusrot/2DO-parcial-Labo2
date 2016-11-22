using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    public class Carrera
    {
        public List<Auto> listaAutos;
        // Depetricated por colleccion;
        /*public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;*/

        private string _Fecha;
        private string _Nombre;
        private string _Lugar;

        public int maximo = 0;
        public int minimo = 0;

        public Auto mayorKm;
        public Auto menorkm;
        public Auto menorTim;
        public Auto mayorTim;

        //private Auto ganador;

        private static Random kilometroRandom;

        public Carrera(string nombre, string fecha, string lugar)
        {
            this.listaAutos = new List<Auto>();
            this._Nombre = nombre;
            this._Fecha = fecha;
            this._Lugar = lugar;

        }


        public Carrera()
        {            

            this.listaAutos = new List<Auto>();
            this.mayorKm = new Auto();
            this.menorkm = new Auto();

            // Depetricated por colleccion;
            /*this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();*/
        }
        static Carrera()
        {
            kilometroRandom = new Random();
        }
        private bool agregarAuto(Auto unAuto)
        {
            this.listaAutos.Add(unAuto);
            return true;
        }
        public static Carrera operator +(Carrera carrera, Auto auto)
        {
            carrera.agregarAuto(auto);
            return carrera;
        }


        #region DepetricatedPorKmyTiempo
        /*public void PorTiempo(int minutos)
        {
            int contador;//,maximo=0,minimo=0;


            for (contador = 0; contador < minutos; contador++)
            {
                this.auto1.AgregarKilometro(kilometroRandom.Next(10, 100));
                this.auto2.AgregarKilometro(kilometroRandom.Next(10, 100));
                this.auto3.AgregarKilometro(kilometroRandom.Next(10, 100));
                this.auto4.AgregarKilometro(kilometroRandom.Next(10, 100));
                this.auto5.AgregarKilometro(kilometroRandom.Next(10, 100));
                this.auto6.AgregarKilometro(kilometroRandom.Next(10, 100));

            }
            /*this.maximo = auto1.MinyMax();
            this.ganador = this.auto1;
            if (this.maximo < auto2.MinyMax())
            {
                this.maximo = auto2.MinyMax();
                this.ganador = this.auto2;
            }
            if (this.maximo < auto3.MinyMax())
            {
                this.maximo = auto3.MinyMax();
                this.ganador = this.auto2;
            }
            if (this.maximo < auto4.MinyMax())
            {
                this.maximo = auto4.MinyMax();
                this.ganador = this.auto4;
            }
            if (this.maximo < auto5.MinyMax())
            {
                this.maximo = auto5.MinyMax();
                this.ganador = this.auto5;
            }
            if (this.maximo < auto6.MinyMax())
            {
                this.maximo = auto6.MinyMax();
                this.ganador = this.auto6;
            }

            this.minimo = auto1.MinyMax();
            if (this.minimo > auto2.MinyMax())
                this.minimo = auto2.MinyMax();
            if (this.minimo > auto3.MinyMax())
                this.minimo = auto3.MinyMax();
            if (this.minimo > auto4.MinyMax())
                this.minimo = auto4.MinyMax();
            if (this.minimo > auto5.MinyMax())
                this.minimo = auto5.MinyMax();
            if (this.minimo > auto6.MinyMax())
                this.minimo = auto6.MinyMax();

        }*/
        #endregion
        #region corrercarreras
        //DEPETRICATED por metodo sin sobrecarga;
        /*public void CorrerCarrera(Tiempo tiempo)
        {
            
            
            for (int i = 0; i < tiempo; i++)
            {
                foreach (Auto auto in this.listaAutos)
                {
                    auto.Agregar((Tiempo)(kilometroRandom.Next(10, 100)));
                }
                //Depetricated por colecciones
                /*this.auto1.Agregar((Tiempo)(kilometroRandom.Next(10, 100)));
                this.auto2.Agregar((Tiempo)(kilometroRandom.Next(10, 100)));
                this.auto3.Agregar((Tiempo)(kilometroRandom.Next(10, 100)));
                this.auto4.Agregar((Tiempo)(kilometroRandom.Next(10, 100)));
                this.auto5.Agregar((Tiempo)(kilometroRandom.Next(10, 100)));
                this.auto6.Agregar((Tiempo)(kilometroRandom.Next(10, 100)));
            }

            for (int i = 0; i < this.listaAutos.Count; i++)
            {
                if (i == 0)
                {
                    mayor = this.listaAutos[i];
                    menor = this.listaAutos[i];
                    continue;
 
                }
                if((int)this.listaAutos[i].ObtenerTiempo() < (int)menor.ObtenerTiempo())
                {
                    menor = this.listaAutos[i];
                }
                if ((int)this.listaAutos[i].ObtenerTiempo() > (int)menor.ObtenerTiempo())
                {
                    mayor = this.listaAutos[i];
                }
                
            }



            
            
        }*/

        public void CorrerCarrera(Tiempo tiempo)
        {
            foreach (Auto auto in listaAutos)
            {
                auto.VolverCero();

            }
            for (int i = 0; i < tiempo; i++)
            {
                foreach (Auto auto in this.listaAutos)
                {
                    auto.Agregar((Tiempo)(kilometroRandom.Next(10, 100)));
                }
            }

            for (int i = 0; i < this.listaAutos.Count; i++)
            {
                if (i == 0)
                {
                    mayorTim = this.listaAutos[i];
                    menorTim = this.listaAutos[i];
                    continue;

                }
                if ((int)this.listaAutos[i].ObtenerTiempo() < (int)menorTim.ObtenerTiempo())
                {
                    menorTim = this.listaAutos[i];
                }
                if ((int)this.listaAutos[i].ObtenerTiempo() > (int)menorTim.ObtenerTiempo())
                {
                    mayorTim = this.listaAutos[i];
                }

            }

        }

        public string CorrerCarrera(Kilometro kilometro)
        {
            string ganador;
            foreach (Auto auto in listaAutos)
            {
                auto.VolverCero();
            }

           
           for (int i = 0; i < kilometro; i++)
            {
                foreach (Auto auto in this.listaAutos)
                {
                    auto.Agregar((Kilometro)(kilometroRandom.Next(10, 100)));
                    
                }

            }
           
           for (int i = 0; i < this.listaAutos.Count; i++)
           {
               if (i == 0)
               {
                   mayorKm = this.listaAutos[i];
                   menorkm = this.listaAutos[i];
                   continue;

               }
               if ((int)this.listaAutos[i].ObtenerKilometros() < (int)menorkm.ObtenerKilometros())
               {
                   menorkm = this.listaAutos[i];
               }
               if ((int)this.listaAutos[i].ObtenerKilometros() > (int)menorkm.ObtenerKilometros())
               {
                   mayorKm = this.listaAutos[i];
               }

           }

           ganador = mayorKm.ToString();

           return ganador;
            
           
           
        }
        #endregion
        #region mostrar

        public void MostrarCarrera()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Auto auto in this.listaAutos)
            {
                Console.Write(auto.retornarSTR());   
            }

           //Console.Write("Mas km: \n" + mayorKm.retornarSTR() + "Menos tiempo: \n" + menorTim.retornarSTR());
            
        }
        
       /* public void MostrarCarreraPorKm()
        {
            foreach (Auto auto in this.listaAutos)
            {
                auto.MostrarAutoPorKm();
            }
            menor.MostrarAutoPorKm();
            mayor.MostrarAutoPorKm();

            // Depetricated por colleccion;
            //CorrerCarrera((Tiempo)10);
            //CorrerCarrera((Kilometro)10);
            //PorTiempo(10);
            /*this.auto1.MostrarAutoPorKm();
            this.auto2.MostrarAutoPorKm();
            this.auto3.MostrarAutoPorKm();
            this.auto4.MostrarAutoPorKm();
            this.auto5.MostrarAutoPorKm();
            this.auto6.MostrarAutoPorKm();



        }*/
        /*public void MostrarCarreraPorTiempo()
        {
            foreach (Auto auto in this.listaAutos)
            {
                auto.MostrarAutoPorTiempo();
            }
            menor.MostrarAutoPorTiempo();
            mayor.MostrarAutoPorTiempo();
            // Depetricated por colleccion;
            //CorrerCarrera((Tiempo)10);
            //CorrerCarrera((Kilometro)10);
            //PorTiempo(10);
            /*this.auto1.MostrarAutoPorTiempo();
            this.auto2.MostrarAutoPorTiempo();
            this.auto3.MostrarAutoPorTiempo();
            this.auto4.MostrarAutoPorTiempo();
            this.auto5.MostrarAutoPorTiempo();
            this.auto6.MostrarAutoPorTiempo();


        }*/
        #endregion
    }
}
