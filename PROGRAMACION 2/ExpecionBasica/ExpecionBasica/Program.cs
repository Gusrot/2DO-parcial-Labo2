using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpecionBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                LanzarError();
                Operar();
            }
            catch (FormatException)
            {
                Console.WriteLine("Format");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Zero");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.WriteLine("jorge");
            }*/


            Carrera miCarrera = new Carrera("Autodromo");
            Auto a1 = new Auto("A", 23);
            Auto a2 = new Auto("asd", 12);
            Auto a3 = new Auto("qwe", 1);
            Auto a4 = new Auto("zxc", 4);

            a1.misRueda.Add(new Rueda("P"));
            a1.misRueda.Add(new Rueda("P"));
            a1.misRueda.Add(new Rueda("P"));
            a1.misRueda.Add(new Rueda("P"));

            a2.misRueda.Add(new Rueda("Ñ"));
            a2.misRueda.Add(new Rueda("Ñ"));
            a2.misRueda.Add(new Rueda("Ñ"));
            a2.misRueda.Add(new Rueda("Ñ"));

            a3.misRueda.Add(new Rueda("O"));
            a3.misRueda.Add(new Rueda("O"));
            a3.misRueda.Add(new Rueda("O"));
            a3.misRueda.Add(new Rueda("O"));

            a4.misRueda.Add(new Rueda("L"));
            a4.misRueda.Add(new Rueda("L"));
            a4.misRueda.Add(new Rueda("L"));
            a4.misRueda.Add(new Rueda("L"));

            miCarrera.listaAutos.Add(a1);
            miCarrera.listaAutos.Add(a2);
            miCarrera.listaAutos.Add(a3);
            miCarrera.listaAutos.Add(a4);

            try
            {
                miCarrera.CorrerCarrera();
            }
            catch (PinchaduraExcepcion px)
            {
                Console.WriteLine(px.Message);
            }
            catch (AutoExcepcion ax)
            {
                Console.WriteLine(ax.Message);
            }
            catch (Miexepcion mix)
            {
                Console.WriteLine(mix.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("que paso no arranco");
            } 

            Console.ReadLine();
        }

        /*public static void Operar()
        {
            string dato;
            int numero;

            try
            {
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;
            }
            catch (Exception ex)
            {
                //Operaciones para guardar la excepcion
                throw new Exception("Se quedo sin internet");
            }
        }

        public static void LanzarError()
        {
            throw new Exception("Se quedo sin memoria RAM");
        }*/
   
    }
}
