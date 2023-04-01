using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{

    public abstract class areaFigura
    {
        public abstract double CalcularArea();
    }

    public class Circulo_ : areaFigura
    {
        private double radio;

        public Circulo_(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }

    public class Rectangulo_ : areaFigura
    {
        private double lado1;
        private double lado2;

        public Rectangulo_(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override double CalcularArea()
        {
            return lado1 * lado2;
        }
    }

}
