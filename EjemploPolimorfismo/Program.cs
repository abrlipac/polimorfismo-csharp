
using EjemploPolimorfismo;

class Program
{
    static void Main(string[] args)
    {
        //EJEMPLO 1
        //Figura objFigura1 = new Circulo();
        //objFigura1.Dibujar();

        //Figura objFigura2 = new Rectangulo();
        //objFigura2.Dibujar();



        //EJEMPLO 2
        //areaFigura miFigura1 = new Circulo_(5.0);
        //areaFigura miFigura2 = new Rectangulo_(3.0, 4.0);

        //Console.WriteLine("El área del círculo es: " + miFigura1.CalcularArea());
        //Console.WriteLine("El área del rectángulo es: " + miFigura2.CalcularArea());



        //EJEMPLO 3
        Empleado[] empleados = new Empleado[2];
        empleados[0] = new Programador("Juan", 30, 3000, "C#");
        empleados[1] = new Gerente("María", 40, 4000, 10);
        var calculadoraBono = new CalculadoraBono();

        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine(empleado);
            Console.WriteLine($"Salario calculado: {empleado.CalcularSalario()}");
            Console.WriteLine($"Salario con bono: {calculadoraBono.CalcularBonoEmpleado(empleado)}");
            Console.WriteLine("------------------------");
        }

        // Ejemplo de la clase Operacion
        //int a = 24, b = 8;
        //Operacion multiplicacion = new Multiplicacion(a, b);
        //Operacion division = new Division(a, b);
        //Operacion suma = new Suma(a, b);
        //Operacion resta = new Resta(a, b);

        //Console.WriteLine($"El resultado de la multiplicacion es {multiplicacion.Calcular()}");
        //Console.WriteLine($"El resultado de la division es {division.Calcular()}");
        //Console.WriteLine($"El resultado de la suma es {suma.Calcular()}");
        //Console.WriteLine($"El resultado de la resta es {resta.Calcular()}");
    }
}
