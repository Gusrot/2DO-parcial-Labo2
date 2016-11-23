using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    public class Auto
    {
        private string _nombrePiloto;
        private EFabricante _Fabricante;

        public EFabricante Fabricante;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TD;
        public static Random numRandom;

        public static int ContadorDeObjetos;
        private Kilometro KilometroRecarrido;
        private Tiempo TiempoDemorado;

        public string datosEnString
        {
            get
            {
                return this.retornarSTRlistadoAutos();
            }
        }

        public Auto(string NombrePiloto, EFabricante Fabricante)
        {
            this._nombrePiloto = NombrePiloto;
            this._Fabricante = (EFabricante)Fabricante;
        }

        

        public Auto()
        {
            
            int num;
            num = numRandom.Next(1, 3);

            switch (num)
            {
                case 1:
                    this.Fabricante = (EFabricante)1;
                    break;
                case 2:
                    this.Fabricante = (EFabricante)2;
                    break;
                case 3:
                    this.Fabricante = (EFabricante)3;
                    break;
            }

            this.DI = new Rueda();
            this.DD = new Rueda();
            this.TI = new Rueda();
            this.TD = new Rueda();
            Auto.ContadorDeObjetos++;
            this.TiempoDemorado = 0;
            this.KilometroRecarrido = 0;
        }
        static Auto()
        {
            Auto.ContadorDeObjetos = 0;
            numRandom = new Random();
        }

        /*public int MinyMax()
        {
            return this.KilometroRecarrido;
        }*/
        public static bool CompararAuto(Auto auto1, Auto auto2)
        {
            if (auto1.Fabricante == auto2.Fabricante)
                return true;
            else
                return false;
        }

        public void VolverCero()
        {
            KilometroRecarrido = 0;
            TiempoDemorado = 0;
        }


        public void MostrarAutoPorKm()
        {
            Console.WriteLine("El fabricante es: " + this.Fabricante);
            Console.WriteLine("Recorrio: " + this.KilometroRecarrido.MostrarKm());
        }
        public int ObtenerKilometros()
        {
            return this.KilometroRecarrido.MostrarKm();
        }
        public int ObtenerTiempo()
        {
            return this.TiempoDemorado.MostrarTiempo();
        }
        public void MostrarAutoPorTiempo()
        {
            Console.WriteLine("El fabricante es: " + this.Fabricante);
            Console.WriteLine("Recorrio en :" + this.TiempoDemorado.MostrarTiempo());
        }
        public string retornarSTR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El fabricante es: " + this.Fabricante);
            sb.AppendLine("Recorrio : " + this.KilometroRecarrido.MostrarKm() +" kilometros en " + this.TiempoDemorado.MostrarTiempo()+" tiempo.");

            return sb.ToString();
        }

        private string retornarSTRlistadoAutos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("F: " + this._Fabricante);
            sb.AppendLine("- P: " + this._nombrePiloto);

            return sb.ToString();
        }
        
        /*public void AgregarKilometro(int kilometros)
        {
            KilometroRecarrido += kilometros;
        }

        public void AgregarTiempo(int tiempo)
        {
            TiempoDemorado += tiempo;
        }*/

        public void Agregar(Tiempo tiempo)
        {
            this.TiempoDemorado = this.TiempoDemorado + tiempo;
        }
        public void Agregar(Kilometro km)
        {
            this.KilometroRecarrido = this.KilometroRecarrido + km;
        }

    }
}
