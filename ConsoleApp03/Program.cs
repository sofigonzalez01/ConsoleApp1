// Entidades/Cono.cs
using System;

namespace Entidades
{
    public struct Cono
    {
        // Atributos
        private double radio;
        private double altura;

        // Propiedades públicas para acceder a los atributos
        public double Radio
        {
            get => radio;
            set
            {
                if (value >= 0)
                    radio = value;
                else
                    throw new ArgumentException("El radio debe ser mayor o igual a 0.");
            }
        }

        public double Altura
        {
            get => altura;
            set
            {
                if (value >= 0)
                    altura = value;
                else
                    throw new ArgumentException("La altura debe ser mayor o igual a 0.");
            }
        }

        // Método para calcular el volumen
        public double CalcularVolumen()
        {
            return (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            double generatriz = CalcularGeneratriz();
            return Math.PI * radio * (radio + generatriz);
        }

        // Método para calcular la generatriz del cono
        private double CalcularGeneratriz()
        {
            return Math.Sqrt(Math.Pow(radio, 2) + Math.Pow(altura, 2));
        }

        // Método para calcular la diagonal (generatriz en el contexto del cono)
        public double CalcularDiagonal()
        {
            return CalcularGeneratriz();
        }

        // Método para mostrar los valores del cono
        public void InformarValores()
        {
            Console.WriteLine($"Radio: {radio}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Volumen: {CalcularVolumen()}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Diagonal (Generatriz): {CalcularDiagonal()}");
        }
    }
}

