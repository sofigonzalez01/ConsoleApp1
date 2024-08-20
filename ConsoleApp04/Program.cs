using Entidades;
using System;

namespace Entidades
{
    public struct Cono
    {
        // Atributos privados
        private double radio;
        private double altura;

        // Propiedad para el radio
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value > 0)
                {
                    radio = value;
                }
                else
                {
                    throw new ArgumentException("El radio debe ser un número positivo.");
                }
            }
        }

        // Propiedad para la altura
        public double Altura
        {
            get { return altura; }
            set
            {
                if (value > 0)
                {
                    altura = value;
                }
                else
                {
                    throw new ArgumentException("La altura debe ser un número positivo.");
                }
            }
        }

        // Método para calcular el volumen del cono
        public double CalcularVolumen()
        {
            return (1.0 / 3.0) * Math.PI * radio * radio * altura;
        }

        // Método para calcular el área total del cono
        public double CalcularArea()
        {
            double generatriz = Math.Sqrt(radio * radio + altura * altura);
            double areaBase = Math.PI * radio * radio;
            double areaLateral = Math.PI * radio * generatriz;
            return areaBase + areaLateral;
        }

        // Método para calcular la diagonal (generatriz) del cono
        public double CalcularDiagonal()
        {
            return Math.Sqrt(radio * radio + altura * altura);
        }

        // Método para informar los valores del cono
        public void InformarValores()
        {
            Console.WriteLine($"Radio: {radio:F2}");
            Console.WriteLine($"Altura: {altura:F2}");
            Console.WriteLine($"Volumen: {CalcularVolumen():F2}");
            Console.WriteLine($"Área Total: {CalcularArea():F2}");
            Console.WriteLine($"Diagonal (Generatriz): {CalcularDiagonal():F2}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Definir el tamaño del array
        const int maxConos = 5;
        Cono[] conos = new Cono[maxConos];
        int indiceCono = 0;

        while (true)
        {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Ingresar datos del cono");
            Console.WriteLine("2. Mostrar todos los conos");
            Console.WriteLine("3. Verificar si el array está lleno");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    if (indiceCono < maxConos)
                    {
                        // Ingreso de datos del cono
                        try
                        {
                            Cono nuevoCono = new Cono();

                            Console.Write("Ingrese el radio del cono (en unidades): ");
                            nuevoCono.Radio = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Ingrese la altura del cono (en unidades): ");
                            nuevoCono.Altura = Convert.ToDouble(Console.ReadLine());

                            conos[indiceCono] = nuevoCono;
                            indiceCono++;

                            Console.WriteLine("Cono ingresado correctamente.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El array de conos está lleno.");
                    }
                    break;

                case "2":
                    MostrarConos(conos, indiceCono);
                    break;

                case "3":
                    VerificarEstadoArray(indiceCono, maxConos);
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }

    // Método para mostrar todos los conos
    static void MostrarConos(Cono[] conos, int cantidadConos)
    {
        if (cantidadConos == 0)
        {
            Console.WriteLine("No hay conos ingresados.");
            return;
        }

        for (int i = 0; i < cantidadConos; i++)
        {
            Console.WriteLine($"\nCono #{i + 1}:");
            conos[i].InformarValores();
        }
    }

    // Método para verificar si el array está lleno o vacío
    static void VerificarEstadoArray(int cantidadConos, int maxConos)
    {
        if (cantidadConos >= maxConos)
        {
            Console.WriteLine("El array de conos está lleno.");
        }
        else if (cantidadConos == 0)
        {
            Console.WriteLine("El array de conos está vacío.");
        }
        else
        {
            Console.WriteLine($"El array de conos tiene {cantidadConos} de {maxConos} conos ingresados.");
        }
    }
}

