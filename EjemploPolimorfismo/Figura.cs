using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    public class Figura
    {
        public virtual void Dibujar()
        {
            Console.WriteLine("Dibujando figura generica...");
        }
    }

    public class Circulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un circulo...");
        }
    }

    public class Rectangulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un rectangulo...");
        }
    }
}
