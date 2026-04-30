using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            Console.WriteLine("FIGURAS GEOMÉTRICAS\n");

            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RectangleMenu();
                        break;
                    case "2":
                        CircleMenu();
                        break;
                    case "3":
                        TriangleMenu();
                        break;
                    case "4":
                        continuar = false;
                        Console.WriteLine("\n¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }

                if (continuar && opcion != "4")
                {
                    Console.Write("\n¿Desea continuar? (S/N): ");
                    string resp = Console.ReadLine().ToUpper();

                    if (resp == "N")
                        continuar = false;
                }
            }

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\nMENÚ");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void RectangleMenu()
        {
            Console.WriteLine("\nRECTÁNGULO");

            double b = LeerNumeroPositivo("Base: ");
            double h = LeerNumeroPositivo("Altura: ");

            Rectangle r = new Rectangle(b, h);

            Console.WriteLine("\n1. Área");
            Console.WriteLine("2. Perímetro");
            Console.WriteLine("3. Ambos");
            Console.Write("Seleccione: ");

            string op = Console.ReadLine();

            if (op == "1" || op == "3")
                Console.WriteLine($"Área: {r.CalcularArea():F2}");

            if (op == "2" || op == "3")
                Console.WriteLine($"Perímetro: {r.CalcularPerimetro():F2}");
        }

        static void CircleMenu()
        {
            Console.WriteLine("\nCÍRCULO");

            double radio = LeerNumeroPositivo("Radio: ");
            Circle c = new Circle(radio);

            Console.WriteLine("\n1. Área");
            Console.WriteLine("2. Perímetro");
            Console.WriteLine("3. Ambos");
            Console.Write("Seleccione: ");

            string op = Console.ReadLine();

            if (op == "1" || op == "3")
                Console.WriteLine($"Área: {c.CalcularArea():F2}");

            if (op == "2" || op == "3")
                Console.WriteLine($"Perímetro: {c.CalcularPerimetro():F2}");
        }

        static void TriangleMenu()
        {
            Console.WriteLine("\nTRIÁNGULO");

            double b = LeerNumeroPositivo("Base: ");
            double h = LeerNumeroPositivo("Altura: ");

            Triangle t = new Triangle(b, h);

            Console.WriteLine($"Área: {t.CalcularArea():F2}");
        }
        
        static double LeerNumeroPositivo(string mensaje)
        {
            double num;

            do
            {
                Console.Write(mensaje);

                while (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.Write("Ingrese un número válido: ");
                }

                if (num <= 0)
                    Console.WriteLine("Debe ser mayor que 0.");

            } while (num <= 0);

            return num;

        }
    }
}
