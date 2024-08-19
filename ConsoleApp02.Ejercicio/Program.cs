

        const double PI = Math.PI;
        int numConos = 5;
        double[] volúmenes = new double[numConos];
        double volumenMaximo = 0;
        int índiceVolumenMaximo = -1;
        double sumaVolúmenes = 0;

        for (int i = 0; i < numConos; i++)
        {
            double radio, altura, volumen;

            // Ingreso y validación de datos
            while (true)
            {
                Console.Write($"Ingrese el radio del cono #{i + 1} : ");
                if (double.TryParse(Console.ReadLine(), out radio) && radio > 0)
                {
                    break;
                }
                Console.WriteLine("Valor incorrecto del radio debe ser mayor que cero");
            }

            // Ingreso y validación de datos 
            while (true)
            {
                Console.Write($"Ingrese la altura del cono #{i + 1} : ");
                if (double.TryParse(Console.ReadLine(), out altura) && altura > 0)
                {
                    break;
                }
                Console.WriteLine("Valor incorrecto, debe ser mayor a cero");
            }

            // Calculo del volumen del cono
            volumen = (1.0 / 3.0) * PI * radio * radio * altura;
            volúmenes[i] = volumen;
            sumaVolúmenes += volumen;

            // Determinar si este cono tiene el mayor volumen
            if (volumen > volumenMaximo)
            {
                volumenMaximo = volumen;
                índiceVolumenMaximo = i + 1; // Guardamos el número de iteración (1-indexado)
            }
        }

        // Calcular el promedio de los volúmenes
        double promedioVolúmenes = sumaVolúmenes / numConos;

        // Mostrar resultados
        Console.WriteLine($"\nEl cono con el mayor volumen es el cono #{índiceVolumenMaximo} con un volumen de {volumenMaximo:F2} ");
        Console.WriteLine($"El promedio de los volúmenes de los conos ingresados es: {promedioVolúmenes:F2} ");
    

