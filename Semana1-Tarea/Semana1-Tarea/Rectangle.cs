using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Tarea
{
    class Rectangle
    {
        private double baseRect;
        private double altura;

        public Rectangle(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        public double CalcularArea()
        {
            return baseRect * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }

        public double Base => baseRect;
        public double Altura => altura;
    }
}

