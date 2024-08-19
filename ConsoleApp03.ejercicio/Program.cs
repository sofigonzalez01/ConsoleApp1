




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
                    throw new ArgumentException("El radio debe ser un número mayor que cero");
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
                    throw new ArgumentException("La altura debe ser un número mayor que cero");
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


