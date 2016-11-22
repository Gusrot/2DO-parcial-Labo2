using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JORGE
{
    public class Computadora
    {
        private bool _estaEncendida;
        private AlanBRADo.EMarca _marca;
        private float _peso;
        private JOSELUIS.EProcesador _procesador;


        public Computadora(bool estaEncendida,AlanBRADo.EMarca marca,float peso,JOSELUIS.EProcesador procesador)
        {
            this.setEstaEncendida(estaEncendida);
            this._marca = marca;
            this._peso = peso;
            this._procesador = procesador;
            this.InformarEstado();
        }
        //Metodo CONSTRUCTOR

        private void InformarEstado()
        {
            Console.Write("\n**********COMPUTADORA**********");
            Console.Write("\nProcesador: " + this._marca);
            Console.Write("\nMarca: " + this._procesador);
            Console.Write("\nPeso: " + this._peso);
            Console.Write("\nEstado (true = encendida // false = apagada): " + this._estaEncendida);
        }

        private bool Apagar()
        {
            this._estaEncendida = false;
            
            return this._estaEncendida;
        }

        private bool Encender()
        {
            this._estaEncendida = true;

            return this._estaEncendida;
        }

        //GET
        public bool getEstaEncendida()
        {
            return _estaEncendida;
        }
        public AlanBRADo.EMarca getMarca()
        {
            return _marca;
        }
        public float getPeso()
        { 
            return _peso; 
        }
        public JOSELUIS.EProcesador getProcesador()
        {
            return _procesador;
        }
        //SET
        public void setEstaEncendida(bool encender)
        {
            _estaEncendida=encender;
        }
        public void setMarca(AlanBRADo.EMarca marca)
        {
            _marca = marca;
        }
        public void setPeso(float peso)
        {
            _peso = peso;
        }
        public void setProcesador(JOSELUIS.EProcesador procesador)
        {
            _procesador = procesador;
        }
        

    }
}
