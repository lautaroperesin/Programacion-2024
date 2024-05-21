



using EjerciciosDePrueba.Clases;
using EjerciciosDePrueba.Clases.Enums;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //CalcularDiasDeVida();
        //ImprimirMinimoDe4();
        //ImprimirTipoDeTriangulo();
        //DeterminarFechaValida();
        //CalcularHorasDeTrabajoFaltantes();
        //CalcularValorPago();
        //PruebaDeObjetoSplit();
        //PruebaDeObjetoPersona();
        //PruebaDeObjetoPavaElectrica();
        PruebaDeObjetoEstereo();
    }

    private static void PruebaDeObjetoEstereo()
    {
        Estereo miEstereo = new Estereo("Pioneer", "Negro");
        miEstereo.Encender();
        miEstereo.CambiarModo(ModosEstereoEnum.Bluetooth);
        miEstereo.CambiarCancionBT("A las Nueve - No Te Va Gustar");
        miEstereo.SubirVolumen();
        miEstereo.SubirVolumen();
        miEstereo.SubirVolumen();
        miEstereo.Mostrar();
        miEstereo.CambiarModo(ModosEstereoEnum.Radio);
        miEstereo.CambiarFrecuenciaRadio(97.9);
        miEstereo.SubirVolumen();
        miEstereo.SubirVolumen();
        miEstereo.BajarVolumen();
        miEstereo.Mostrar();
        miEstereo.CambiarModo(ModosEstereoEnum.CD);
        miEstereo.CambiarPistaCD("Arruinarse - Tan Bionica - Pista 5");
        miEstereo.SubirVolumen();
        miEstereo.SubirVolumen();
        miEstereo.SubirVolumen();
        miEstereo.Mostrar();
    }

    private static void PruebaDeObjetoPavaElectrica()
    {
        PavaElectrica miPava = new PavaElectrica("Liliana", "Plateado", "Acero inoxidable");
        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Maximo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo: {miPava.Modo}");
        Console.WriteLine($"La temperatura del agua es {miPava.Temperatura_del_agua}°C");
        Thread.Sleep(2000);
        miPava.CambiarModo(ModoEnum.Minimo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo: {miPava.Modo}");

    }

    private static void PruebaDeObjetoPersona()
    {
        Persona albert = new Persona("Albert Einstein", "9 de Julio 1111", 1879);
        Persona robert = new Persona("Robert Oppenheimer", "San Roque 2020", 1904);
        robert.Decir("Albert, sabes como se despiden los quimicos?");
        albert.Decir("No, ni idea");
        robert.Decir("Acido un placer");
    }

    private static void PruebaDeObjetoSplit()
    {
        // Instanciamos el objeto split
        Split miSplit = new Split("Blanco", 3000, "Marshall");
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PresionarBotonEncendido();
        miSplit.CambiarModo("Deshumidificacion");
        miSplit.SubirTemperatura();
        Console.WriteLine($"El split está en modo: {miSplit.Modo}");
    }

    private static void CalcularValorPago()
    {
        // Declaramos las variables
        double valorCuota;
        int nroDia;

        // Leemos las variables
        Console.Write("Ingrese el valor de la cuota: ");
        valorCuota = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el numero del dia de pago: ");
        nroDia = int.Parse(Console.ReadLine());

        switch (nroDia)
        {
            case < 3:
                valorCuota = valorCuota - (valorCuota * 0.03);
                break;
            case >= 6 and <= 10:
                valorCuota = valorCuota + (valorCuota * 0.01);
                break;
            case >= 11 and <= 20:
                valorCuota = valorCuota + (valorCuota * 0.12);
                break;
            case >= 21 and <= 31:
                valorCuota = valorCuota + (valorCuota * 0.15);
                break;
        }

        Console.WriteLine($"El valor de la cuota para el dia de pago es: {valorCuota}");
    }

    /// <summary>
    /// Algoritmo que muestre la cantidad de horas que faltan para el fin de la jornada laboral, tomando en cuenta que los jueves se trabajan dos horas más y que la jornada tiene 5 horas.Se le pide al usuario que ingrese las horas trabajadas hasta el momento.
    /// </summary>
    private static void CalcularHorasDeTrabajoFaltantes()
    {
        int horasTrabajadas, horasFaltantes;
        string dia;

        Console.Write("Ingrese las horas trabajadas hasta el momento: ");
        horasTrabajadas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el dia de la semana: ");
        dia = Console.ReadLine();

        horasFaltantes = 5 - horasTrabajadas;

        dia = dia.ToLower();
        if (dia == "jueves")
        {
            horasFaltantes = horasFaltantes + 2;
            Console.WriteLine($"Faltan {horasFaltantes} horas para terminar la jornada");
        }
        else
        {
            Console.WriteLine($"Faltan {horasFaltantes} horas para terminar la jornada");   
        }
    }

    /// <summary>
    /// Leer tres valores que correspondena un dia, un mes y un año y determinar si se trata de una fecha valida o no
    /// </summary>
    private static void DeterminarFechaValida()
    {
        // Declaramos las variables
        int dia, mes, año;

        // Pedimos los datos al usuario
        Console.Write("Ingrese un dia: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un año: ");
        año = int.Parse(Console.ReadLine());


        if (año >= 1)
        {
        // Calculamos si el año es bisiesto o no
            if ((año % 4 == 0) || (año % 100 == 0) && (año % 400 == 0))
            {
                AñoBisiesto(mes, dia);
            }
            else
            {
                AñoNoBisiesto(mes, dia);
            }
        }
        else
        {
            Console.WriteLine("La fecha no es valida");
        }

        // Metodo para los años bisiestos
        static void AñoBisiesto(int mes, int dia)
        {
            bool fechaValida = true;

            if (mes >= 1 && mes <= 12)
            {
                if(mes == 2)
                {
                    if (dia > 29) 
                    {
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31 || dia <= 0) 
                    {
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }
                else
                {
                    if (dia > 30 || dia <= 0) 
                    {
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("La fecha no es valida");
                fechaValida = false;
            }

            if (fechaValida) Console.WriteLine("La fecha que ingresaste es valida");
        }

        // Metodo para los añps no biciestos
        static void AñoNoBisiesto(int mes, int dia)
        {
            bool fechaValida = true;

            if (mes >= 1 && mes <= 12)
            {
                if(mes == 2)
                {
                    if (dia > 28) 
                    {
                        Console.WriteLine("La fecha no es valida"); 
                        fechaValida = false;
                    }
                }

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31 || dia <= 0) 
                    {
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }
                else
                {
                    if (dia > 30 || dia <= 0)
                    { 
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("La fecha no es valida");
                fechaValida = false;
            }

            if(fechaValida) Console.WriteLine("La fecha que ingresaste es valida");
        }
    }

    /// <summary>
    /// Creamos un metodo que pida el nombre y apellido del usuario y posteriormente lo salude con "Bienvenido {Apellido}, {Nombre}"
    /// </summary>
    private static void PedirNombreYSaludar()
    {
        // Declaramos las variables
        string nombre, apellido;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido: ");
        apellido = Console.ReadLine();


        //Console.WriteLine("Bienvenido "+apellido+", "+nombre);
        Console.WriteLine($"Bienvenido {apellido}, {nombre}");
    }

    /// <summary>
    /// Creamos un metodo que nos pida los años, meses y dias de vida, y muestre al final la cantidad total de dias de vida
    /// </summary>
    private static void CalcularDiasDeVida()
    {
        // Declaramos las variables
        int años, meses, dias, diasDeVida;

        Console.Write("Ingrese sus años de vida: ");
        años = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida: ");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus dias de vida: ");
        dias = int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;
        Console.WriteLine($"Los dias de vida totales son: {diasDeVida}");
    }

    /// <summary>
    /// Realizar un algoritmo que imprima el mínimo entre cuatro valores que se piden al usuario.
    /// </summary>
    private static void ImprimirMinimoDe4()
    {
        // Declaramos las variables
        int num1, num2, num3, num4;

        // Pedimos que se ingresen los valores
        Console.Write("Ingrese el primer valor: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer valor: ");
        num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto valor: ");
        num4 = int.Parse(Console.ReadLine());

        // Resolvemos
        if (num1 < num2 && num1 < num3 && num1 < num4) Console.WriteLine($"El valor minimo de los cuatro es {num1}");

        if (num2 < num1 && num2 < num3 && num2 < num4) Console.WriteLine($"El valor minimo de los cuatro es {num2}");

        if (num3 < num1 && num3 < num2 && num3 < num4) Console.WriteLine($"El valor minimo de los cuatro es {num3}");

        if (num4 < num1 && num4 < num2 && num4 < num2) Console.WriteLine($"El valor minimo de los cuatro es {num4}");
    }

    /// <summary>
    /// Realizar un programa que pida los valores de los tres lados de un triangulo e imprima si el mismo es equilatero, isosceles o escaleno
    /// </summary>
    private static void ImprimirTipoDeTriangulo()
    {
        int lado1, lado2, lado3;

        Console.Write("Ingrese el valor del primer lado: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor del segundo lado: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor del tercer lado: ");
        lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triangulo es equilatero");
        }
        else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
        {
            Console.WriteLine("El triangulo es isosceles");
        }
        else
        {
            Console.WriteLine("El triangulo es escaleno");
        }
    }
}