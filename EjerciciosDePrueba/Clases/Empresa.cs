using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Empresa<T> where T : Empleado
    {
        // Declaramos e inicializamos la lista de personas llamada empleados (campo)
        List<T> empleados = new List<T>();
        string nombre;

        public Empresa(string nombre)
        {
            this.nombre = nombre;
        }

        public void AgregarEmpleado(T empleado)
        {
            empleados.Add(empleado);
        }

        public bool QuitarEmpleado(T empleado)
        {
            if (empleados.Contains(empleado))
            {
                empleados.Remove(empleado);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ListarEmpleados()
        {
            string retorno = $"Lista de empleados de {this.nombre}" + Environment.NewLine;
            foreach (var trabajador in empleados)
            {
                retorno += trabajador.ImprimirDatos() + Environment.NewLine;
            }
            return retorno;
        }
    }
}
