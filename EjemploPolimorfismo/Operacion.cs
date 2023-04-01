using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    public abstract class Operacion
    {
        protected int a, b;
        public Operacion(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public abstract int Calcular();
    }

    public class Multiplicacion : Operacion
    {
        public Multiplicacion(int a, int b) : base(a, b) { }
        public override int Calcular()
        {
            return a * b;
        }
    }

    public class Division : Operacion
    {
        public Division(int a, int b) : base(a, b) { }
        public override int Calcular()
        {
            return a / b;
        }
    }

    public class Suma : Operacion
    {
        public Suma(int a, int b) : base(a, b) { }
        public override int Calcular()
        {
            return a + b;
        }
    }

    public class Resta : Operacion
    {
        public Resta(int a, int b) : base(a, b) { }
        public override int Calcular()
        {
            return a - b;
        }
    }
}
