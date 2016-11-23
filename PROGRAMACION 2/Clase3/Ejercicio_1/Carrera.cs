using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        public Auto mayor;
        public Auto menor;
        private Auto ganador;
        public int maximo;
        public int minimo;
        //private static int kilometroRandom;
        private static Random kilometroRandom;
        private static Random tiempoRandom;
        
       
       


        

        public Carrera()
        {
            kilometroRandom = new Random();
            tiempoRandom = new Random();
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
            this.ganador = new Auto();
            

        }

       /* public void PorTiempo(int minutos)
        {
            
            for (int i = 0; i < minutos; i++)
            {
                this.auto1.AgregarKilometros(kilometroRandom.Next(10, 100));
                this.auto2.AgregarKilometros(kilometroRandom.Next(10, 100));
                this.auto3.AgregarKilometros(kilometroRandom.Next(10, 100));
                this.auto4.AgregarKilometros(kilometroRandom.Next(10, 100));
                this.auto5.AgregarKilometros(kilometroRandom.Next(10, 100));
                this.auto6.AgregarKilometros(kilometroRandom.Next(10, 100));

              
            }         
            /*maximo = auto1.MinyMax();
           
            if (maximo < auto2.MinyMax())
            {
                maximo = auto2.MinyMax();
                
            }
               
            if (maximo < auto3.MinyMax())
            {   
                maximo = auto3.MinyMax();
                 
            }               
            if (maximo < auto4.MinyMax())
            {
                maximo = auto4.MinyMax();
                
            }           
            if (maximo < auto5.MinyMax())
            { 
                maximo = auto5.MinyMax();
                 
            }               
            if (maximo < auto6.MinyMax())
            {
                maximo = auto6.MinyMax();
                
            }           
           
                   
          
        }*/
        public void CorrerCarrera(Tiempo tiempo)
        {
          
           /* minimo = auto1.minTiempo();
            this.ganador = this.auto1;
            if (minimo > auto1.minTiempo())
            {
                minimo = auto2.minTiempo();
                this.ganador = this.auto2;
            }

            if (minimo > auto2.minTiempo())
            {
                minimo = auto3.minTiempo();
                this.ganador = this.auto3;
            }
            if (minimo > auto4.minTiempo())
            {
                minimo = auto4.minTiempo();
                this.ganador = this.auto4;
            }
            if (minimo > auto5.minTiempo())
            {
                minimo = auto5.minTiempo();
                this.ganador = this.auto5;

            }
            if (minimo > auto6.minTiempo())
            {
                minimo = auto6.minTiempo();
                this.ganador = this.auto6;

            }  */   // No funciona.      
            
           
        }

        public void CorrerCarrera(Kilometro kilometros)
        {
            for (int i = 0; i < kilometros; i++)
            {
                this.auto1.Agregar((Kilometro)kilometroRandom.Next(10, 100));
                this.auto2.Agregar((Kilometro)kilometroRandom.Next(10, 100));
                this.auto3.Agregar((Kilometro)kilometroRandom.Next(10, 100));
                this.auto4.Agregar((Kilometro)kilometroRandom.Next(10, 100));
                this.auto5.Agregar((Kilometro)kilometroRandom.Next(10, 100));
                this.auto6.Agregar((Kilometro)kilometroRandom.Next(10, 100));

            } 
            
        }

        
       
       
        public void MostrarCarrera()
        {
            
            //PorTiempo(10);
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();            
            //Console.WriteLine("El maximo de kilometros recorridos: " + maximo);

                     

        }
        
    }
}
