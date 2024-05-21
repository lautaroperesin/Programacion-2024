using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Split
    {
        // Declaramos los campos y propiedades
        // Campo: las variables privadas de la clase. Se escriben en min
        private string color;
        private int frigorias;
        private string marca;
        private bool encendido;

        // Propiedades: las variables publicas de la clase. Se escriben en may
        public int Temperatura;
        public string Modo;

        // Constructor: metodo que se ejecuta cuando la clase se crea, se instancia en memoria, es decir cuando se construye el objeto
        public Split(string color, int frigorias, string marca)
        {
            this.color = color;
            this.frigorias = frigorias;
            this.marca = marca;

            this.Temperatura = 24;
            this.Modo = "Frio";
            this.encendido = false;
        }

        public void SubirTemperatura()
        {
            if (this.encendido) this.Temperatura++;
            else Console.WriteLine("Error: El split está apagado");
        }

        public void BajarTemperatura()
        {
            if (this.encendido) this.Temperatura--;
            else Console.WriteLine("Error: El split está apagado");
        }

        public void PresionarBotonEncendido()
        {
            this.encendido =! this.encendido;
        }

        public void CambiarModo(string modo)
        {
            if (this.encendido) this.Modo = modo;
            else Console.WriteLine("Error: el split debe estar prendido");
        }
    }
}
