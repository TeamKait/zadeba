using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр20
{
    class Point3D
    {
        public double X;
        public double Y;
        public double Z;

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D operator -(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите координаты первой точки (или 'q' для выхода):");
                if (!TryReadPoint(out Point3D point1)) break;

                Console.WriteLine("Введите координаты второй точки:");
                if (!TryReadPoint(out Point3D point2)) break;

                Point3D result = point1 - point2;
                Console.WriteLine($"Результат вычитания: {result}\n");
            }
        }

        static bool TryReadPoint(out Point3D point)
        {
            point = null;
            Console.Write("X: ");
            string inputX = Console.ReadLine();
            if (inputX == "q") return false;

            Console.Write("Y: ");
            string inputY = Console.ReadLine();
            if (inputY == "q") return false;

            Console.Write("Z: ");
            string inputZ = Console.ReadLine();
            if (inputZ == "q") return false;

            if (double.TryParse(inputX, out double x) && double.TryParse(inputY, out double y) && double.TryParse(inputZ, out double z))
            {
                point = new Point3D(x, y, z);
                return true;
            }

            Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
            return TryReadPoint(out point);
        }
    }
}
