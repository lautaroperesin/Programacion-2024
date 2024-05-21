using EjerciciosDePrueba.Clases.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Estereo
    {
        public string marca;
        public string color;

        private ModosEstereoEnum Modo;
        private bool Encendido;
        private int Volumen;
        private double Frecuencia_radio;
        private string NombreBluetooth;
        private string PistaCD;

        public Estereo(string marca, string color)
        {
            this.marca = marca;
            this.color = color;

            this.Encendido = false;
            this.Modo = ModosEstereoEnum.Radio;
            this.Frecuencia_radio = 99.9;
            this.Volumen = 10;
            //this.Bluetooth = "Bluettoth conectado";
            //this.CD = "CD insertado";
        }

        public void Encender()
        {
            this.Encendido =! this.Encendido;
            this.Modo = ModosEstereoEnum.Radio;
        }

        public void SubirVolumen()
        {
            if (Volumen < 30)
                Volumen++;
            else
                Console.WriteLine("Volumen máximo");
        }

        public void BajarVolumen()
        {
            if (Volumen > 0)
                Volumen--;
            else
                Console.WriteLine("Volumen minimo");
        }

        public void CambiarModo(ModosEstereoEnum modo)
        {
            if (Encendido)
                this.Modo = modo;
            else
                Console.WriteLine("El estereo debe estar prendido");
        }

        public void CambiarFrecuenciaRadio(double nuevaFrecuencia)
        {
            if (Encendido)
            {
                if (Modo == ModosEstereoEnum.Radio)
                {
                    Frecuencia_radio = nuevaFrecuencia;
                }
                else
                {
                    Console.WriteLine("No se pudo cambiar la frecuencia, el estereo debe estar en modo radio");
                }
            }
            else
            {
                Console.WriteLine("El estereo esta apagado");
            }
        }

        public void CambiarCancionBT(string nuevaCancion)
        {
            if (Encendido)
            {
                if (Modo == ModosEstereoEnum.Bluetooth)
                {
                    NombreBluetooth = nuevaCancion;
                }
                else
                {
                    Console.WriteLine("No se pudo cambiar la cancion, el estereo debe estar en modo Bluetooth");
                }
            }
            else
            {
                Console.WriteLine("El estereo esta apagado");
            }
        }

        public void CambiarPistaCD(string nuevaPista)
        {
            if (Encendido)
            {
                if (Modo == ModosEstereoEnum.CD)
                {
                    PistaCD = nuevaPista;
                }
                else
                {
                    Console.WriteLine("No se pudo cambiar la cancion, el estereo debe estar en modo CD");
                }
            }
            else
            {
                Console.WriteLine("El estereo esta apagado");
            }
        }

        public void Mostrar()
        {
            if (Encendido)
            {
                // Mostrar el modo y el volumen
                Console.WriteLine("*********************************");
                Console.WriteLine($"El estereo está en modo {Modo}");
                Console.WriteLine($"Volumen: {Volumen}");

                // Mostrar que se está escuchando
                if (Modo == ModosEstereoEnum.Radio)
                    Console.WriteLine($"Estas escuchando la radio {Frecuencia_radio}");

                if(Modo == ModosEstereoEnum.Bluetooth)
                    Console.WriteLine($"Estas escuchando {NombreBluetooth}");

                if(Modo == ModosEstereoEnum.CD)
                    Console.WriteLine($"Estas escuchando {PistaCD}");

                Console.WriteLine("*********************************");
                Console.ReadLine();
            }
        }
    }
}
