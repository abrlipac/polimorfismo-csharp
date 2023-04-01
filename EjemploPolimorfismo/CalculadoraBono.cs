using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    public class CalculadoraBono
    {
        public double CalcularBonoEmpleado(Empleado empleado)
        {
            if(empleado is Programador)
                return CalcularBonoEmpleado((Programador) empleado);
            else if(empleado is Gerente)
                return CalcularBonoEmpleado((Gerente) empleado);
            else return empleado.CalcularSalario();
        }

        public double CalcularBonoEmpleado(Programador programador)
        {
            return programador.CalcularSalario() + 500;
        }

        public double CalcularBonoEmpleado(Gerente gerente)
        {
            return gerente.CalcularSalario() + 1000;
        }
    }
}
