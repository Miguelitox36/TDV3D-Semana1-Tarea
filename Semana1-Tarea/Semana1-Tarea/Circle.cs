using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Tarea
{
    class Circle
    {
        private double radio;

        public Circle(double radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        public double Radio => radio;
    }
}

