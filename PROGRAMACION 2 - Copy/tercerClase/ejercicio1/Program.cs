using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> listaDeAutos;
            listaDeAutos = new List<Auto>();
            Stack<Auto> pilaDeAutos;
            pilaDeAutos = new Stack<Auto>();
            Queue<Auto> colaDeAutos;            
            colaDeAutos = new Queue<Auto>();
        
            ArrayList listaDeArray;
            listaDeArray = new ArrayList();
            Stack pila;
            pila = new Stack();
            Queue cola;
            cola = new Queue();
            Hashtable tabla;
            tabla = new Hashtable();

            listaDeArray.Add("hola");
            listaDeArray.Add(18);

            //pilaDeAutos.Push(Auto );
            //pilaDeAutos.Pop();
            //pilaDeAutos.Count();



            /*listaDeArray.Add("hola");
            listaDeArray.Add(new Auto());
            listaDeAutos.Add(new Auto());
            listaDeAutos.Add("hola");*/



            /*EFabricante fabricante;
            fabricante = EFabricante.Honda;

            Console.WriteLine(fabricante);
            fabricante = (EFabricante)1;
            Console.WriteLine();
            Console.ReadKey();*/

            /*Rueda objeto;
            objeto = new Rueda();

            Auto autito;
            autito = new Auto();
            Auto autitoDos;
            autitoDos = new Auto();
            Auto autitoTres;
            autitoTres = new Auto();
            Auto autitoCuatro;
            autitoCuatro = new Auto();
            Auto autitoCinco;
            autitoCinco = new Auto();
            Auto autitoSeis;
            autitoSeis = new Auto();*/

            //Rueda otraRueda;
            //otraRueda = new Rueda(8);

            /*Tiempo t1 = 25;
            Tiempo t2 = 25;
            Tiempo t3 = 50;
            //Tiempo result;
            //Tiempo resultDos;
            //Tiempo resultTres;

            if ((t1 == t2) == true)
            {
                Console.Write("\nSon iguales");
            }
            else
            {
                Console.Write("\nSon distintos");
            }

            Console.Write("\n*************************");

            if ((t2 < 13)== true)
            {
                Console.Write("El primer numero es menor que el segundo");
            }
            else
            {
                Console.Write("\nEl primer numero NO es menor que el segundo");
            }

            Console.Write("\n*************************");

            if (t3 > t2)
            {
                Console.Write("\nEl primer numero es mayor que el segundo");
            }
            else
            {
                Console.Write("\nEl primer numero NO es mayor que el segundo");
            }*/

            //result.mostrar();
            //resultDos.mostrar();
            //resultTres.mostrar();
           
            /*Carrera carrerita;
            carrerita = new Carrera();

            for (int i = 0; i < 10; i++)
            {
                carrerita = carrerita + new Auto();
            }
    
            Console.Write(carrerita.mostrarCarreraTotal());
            Console.ReadKey();*/
        }
    }
}
