
{
    //La constante
    const double PI = Math.PI;


    Console.Write("Ingrese el radio del cono: ");
    double radio = Convert.ToDouble(Console.ReadLine());
    //Pedir ingreso de datos

    Console.Write("Ingrese la altura del cono: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    // Calculo de  la generatriz
    double generatriz = Math.Sqrt(radio * radio + altura * altura);

    // Calculo del área de la base
    double areaBase = PI * radio * radio;

    // Calculo del área lateral
    double areaLateral = PI * radio * generatriz;

    // Calculo del área total del cono
    double areaTotal = areaBase + areaLateral;

    // Calculo del volumen del cono
    double volumen = (1.0 / 3.0) * PI * radio * radio * altura;

    // Mostrar los resultados
    Console.WriteLine("Datos del cono:");
    Console.WriteLine($"Radio : {radio:F2} ");
    Console.WriteLine($"Altura : {altura:F2} ");
    Console.WriteLine($"Área de la base : {areaBase:F2} ");
    Console.WriteLine($"Área lateral : {areaLateral:F2} ");
    Console.WriteLine($"Área total : {areaTotal:F2} ");
    Console.WriteLine($"Volumen : {volumen:F2} ");
}


