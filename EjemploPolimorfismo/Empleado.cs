using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    // Clase Padre
    public class Empleado
    {
        private string nombre;
        private int edad;
        private double salario;

        public Empleado(string nombre, int edad, double salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }

        public virtual double CalcularSalario()
        {
            return salario;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, Salario: {salario}";
        }
    }

    // Clase Hija 1
    public class Programador : Empleado
    {
        private string lenguaje;

        public Programador(string nombre, int edad, double salario, string lenguaje) : base(nombre, edad, salario)
        {
            this.lenguaje = lenguaje;
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario() + 500;
        }

        public override string ToString()
        {
            return base.ToString() + $", Lenguaje: {lenguaje}";
        }
    }

    // Clase Hija 2
    public class Gerente : Empleado
    {
        private int numSubordinados;

        public Gerente(string nombre, int edad, double salario, int numSubordinados) : base(nombre, edad, salario)
        {
            this.numSubordinados = numSubordinados;
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario() + (numSubordinados * 1000);
        }

        public override string ToString()
        {
            return base.ToString() + $", Número de subordinados: {numSubordinados}";
        }
    }
}
