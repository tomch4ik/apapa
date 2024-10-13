using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apapa
{
    internal class Work1
    {
        static void Main()
        {         
            int[] A = new int[5]; 
            double[,] B = new double[3, 4]; 
            Console.WriteLine("Input 5 numbers:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Number = ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Massive A:");
            foreach (int num in A)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Random rand = new Random();
            Console.WriteLine("Massive B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = Math.Round(rand.NextDouble() * 100, 2); 
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            } 

            double maxNumber = A[0];
            double minNumber = A[0];
            double sumofnumbers = 0;
            double productnumbers = 1;
            int sumEvenA = 0;
            double sumOddColumnsB = 0;
            foreach (int num in A)
            {
                if (num > maxNumber) maxNumber = num;
                if (num < minNumber) minNumber = num;
                sumofnumbers += num;
                productnumbers *= num;
                if (num % 2 == 0) sumEvenA += num; 
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    double num = B[i, j];
                    if (num > maxNumber) maxNumber = num;
                    if (num < minNumber) minNumber = num;
                    sumofnumbers += num;
                    productnumbers *= num;

                    if (j % 2 != 0) 
                    {
                        sumOddColumnsB += num;
                    }
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
            Console.WriteLine($"Sum of all numbers: {sumofnumbers}");
            Console.WriteLine($"Total product of all numbers: {productnumbers}");
            Console.WriteLine($"Sum of even numbers in A: {sumEvenA}");
            Console.WriteLine($"Sum of elements in odd columns in B: {sumOddColumnsB}");
        }
    }
}
