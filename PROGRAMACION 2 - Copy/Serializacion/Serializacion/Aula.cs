using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    public class Aula
    {
        public int numero;
        private List<Persona> listAlumnos;
        //Funciona con el get solo, no ac falte el set
        public List<Persona> ListaPersonas 
        { 
            get 
            { 
                return this.listAlumnos; 
            } 

            set 
            { 
                this.listAlumnos = value; 
            } 
        }
        public Persona profesor;
        //No serializa porque es privado
        private string _nombreDeAula;
        //Serializa con el get y el set
        public string NombreAula 
        { 
            set 
            { 
                this._nombreDeAula = value; 
            }
 
            get 
            { 
                return this._nombreDeAula; 
            } 
        }
        //Siempre tiene que tener un constructor sin param para que serialize
        public Aula()
        {
 
        }

        public Aula(int numero,Persona profe,List<Persona> listPer,string nombreAula)
        {
            this.listAlumnos = listPer;
            this.numero = numero;
            this.profesor = profe;
            this._nombreDeAula = nombreAula;
        }


    }
}
