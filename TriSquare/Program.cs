using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriSquare
{
    class Program
    {
        static double InputDoubleNumber (string message)
        {
            double number;
            bool ok;
            Console.WriteLine(message);
            do
            {
                ok = double.TryParse(Console.ReadLine(), out number);
                if (ok == false)
                    Console.WriteLine("WRONG DATA ENTERED");
            } while (ok == false);
            return number;
        }

        static void InputCoordinate(out double x, out double y)
        {
            x = InputDoubleNumber("Enter X coordinate");
            y = InputDoubleNumber("Enter Y coordinate");
        }
        static bool IsExistTriangle(double a, double b, double c)
        {
            bool ok;
            if (a + b > c && a + c > b && b + c > a)
                ok = true;
            else
                ok = false;
            return ok;
        }

        static double TriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        static double Length (double x1, double y1, double x2, double y2)
        {
             
            return Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1 - y2,2));
        }




        static void Main1(string[] args)
        {
            double x1; double y1; double x2; double y2;
            double x3, y3;
            InputCoordinate(out x1, out y1);
            InputCoordinate(out x2, out y2);
            InputCoordinate(out x3, out y3);

            double l1, l2, l3;
            l1 = Length(x1, y1, x2, y2);
            l2 = Length(x1, y1, x3, y3);
            l3 = Length(x2, y2, x3, y3);
            bool ok = IsExistTriangle(l1, l2, l3);
            if (ok)
            {
                double S = TriangleSquare(l1, l2, l3);
                Console.Write($"S={S}");
            }
            else
            {
                Console.WriteLine($"NO SUCH TRIANGLE");
            }
                       
        }
    }
}
