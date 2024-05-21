using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Persona
    {
        private string nombre;
        private string direccion;
        private int año_nacimiento;

        public Persona(string nombre, string direccion, int añoNacimiento)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.año_nacimiento = añoNacimiento;
        }

        public void Decir(string texto)
        {
            Console.WriteLine($"{this.nombre} dice: {texto}");
        }
    }
}
