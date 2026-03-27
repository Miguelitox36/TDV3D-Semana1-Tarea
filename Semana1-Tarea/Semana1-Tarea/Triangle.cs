using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Tarea
{
    class Triangle
    {
        private double baseTriangulo;
        private double altura;

        public Triangle(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }

        public double Base => baseTriangulo;
        public double Altura => altura;
    }
}
