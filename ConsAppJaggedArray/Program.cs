using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic[][] matrix = new dynamic[3][];
            matrix[0] = new dynamic[] { 1, 2, 3, 4 };
            matrix[1] = new dynamic[] { 10, 20 };
            matrix[2] = new dynamic[] { 2, 4, 6 };

            dynamic element = matrix[0][1];
            

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Modified Jagged Array Elements:");
            matrix[1][2] = 15 ;
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
            }
            object[][] objmatrix = new object[2][];
            objmatrix[0] = new dynamic[] { 55, "surya", 1.56 };
            objmatrix[1] = new dynamic[] { true, 's', DateTime.Now };
            for (int i = 0; i < objmatrix.Length; i++)
            {
               for (int j = 0; j < objmatrix[i].Length; j++)
               {
                  Console.WriteLine($"type: {objmatrix[i][j].GetType()},value: {objmatrix[i][j]}");
               }
            }

            Console.ReadKey();
        }
    }
}
