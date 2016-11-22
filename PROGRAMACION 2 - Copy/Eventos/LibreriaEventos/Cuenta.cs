using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//c:\Users\alumno\documents\visual studio 2012\Projects
namespace LibreriaEventos
{
    public delegate void CuentaDelegado(float dinero);
    public class Cuenta
    {
        public float saldo;

        public void SacarDinero(float dinero)
        {
            if (dinero > this.saldo)
            {
                //si tuvieramos en app de consola, seria Console.write
                //si es form, MessageBox.Show
                //si es pagina web, seria alert
                saldoNegativo(dinero);
            }
        }

        public event CuentaDelegado saldoNegativo;
    }
}
