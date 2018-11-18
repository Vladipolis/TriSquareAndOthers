using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriSquare
{
    class Arrays
    {
        static int InputIntNumber(string message)
        {
            int number;
            bool ok;
            Console.WriteLine(message);
            do
            {
                ok = int.TryParse(Console.ReadLine(), out number);
                if (ok == false)
                    Console.WriteLine("WRONG DATA ENTERED");
            } while (ok == false);
            return number;
        }


        static int [,] MakeMatrix (int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = rnd.Next(-90,90);
            return matrix;
        }

        static void PrinArr(int[,] Matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

           PrinArr(MakeMatrix(InputIntNumber("HOW MANY ROWS"), InputIntNumber("HOW MANY Columns")));
        }
    }
}
