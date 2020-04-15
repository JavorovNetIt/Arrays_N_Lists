using System;
using System.Linq;

namespace DemoMatrixes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] twoDimensionalArray = new int[3,4];

            ////Demo printing matrix on the console
            //int[,] matrix =
            //{
            //    { 1,56,3,4},
            //    { 2,3,5,6},
            //    { 4,56,7,8}
            //};

            ////int element = matrix[0, 1];

            ////Console.WriteLine(element);

            //for (int x = 0; x < matrix.GetLength(0); x++)
            //{
            //    for (int y = 0; y < matrix.GetLength(1); y++)
            //    {
            //        Console.Write($" {matrix[x, y]} ");
            //    }
            //    Console.WriteLine();
            //}
            ////END - Demo printing matrix on the console
            ///

            ////Demo reading matrix from the console

            ////Console.WriteLine("Моля въведете брой редове за матрицата");
            ////int rows = int.Parse(Console.ReadLine());

            ////Console.WriteLine("Моля въведете броя колони за матрицата");
            ////int cols = int.Parse(Console.ReadLine());

            ////int[,] matrix = new int[rows, cols];

            ////Console.WriteLine("Моля въведете елементите на матрицата");

            ////for (int row = 0; row < rows; row++)
            ////{
            ////    for (int col = 0; col < cols; col++)
            ////    {
            ////        Console.WriteLine($"Моля въведете ст-ст за елемента [{row},{col}]");
            ////        matrix[row, col] = int.Parse(Console.ReadLine());
            ////    }
            ////}

            ////Console.WriteLine("Готово");

            ////for (int x = 0; x < matrix.GetLength(0); x++)
            ////{
            ////    for (int y = 0; y < matrix.GetLength(1); y++)
            ////    {
            ////        Console.Write($" {matrix[x, y]} ");
            ////    }
            ////    Console.WriteLine();
            ////}
            ////END Demo reading matrix from the console


            ////Demo suming elements of matrix
            //int[,] matrix =
            //{
            //    { 0,2,4,0,9,5},
            //    { 7,1,3,3,2,1},
            //    { 1,3,9,8,5,6},
            //    { 4,6,7,9,1,0}
            //};

            //int bestSum = 0;
            //int bestRow = 0;
            //int bestCol = 0;

            //for (int x = 0; x < matrix.GetLength(0) - 1; x++)
            //{
            //    for (int y = 0; y < matrix.GetLength(1) - 1; y++)
            //    {
            //        int sum = matrix[x, y] + matrix[x, y + 1] + matrix[x + 1, y] + matrix[x + 1, y + 1];

            //        if (sum > bestSum)
            //        {
            //            bestSum = sum;
            //            bestRow = x;
            //            bestCol = y;
            //        }

            //    }
            //}

            //Console.WriteLine($"{matrix[bestRow,bestCol]} {matrix[bestRow, bestCol + 1]}");
            //Console.WriteLine($"{matrix[bestRow + 1,bestCol]} {matrix[bestRow + 1, bestCol + 1]}");

            //Console.WriteLine(bestSum);

            ////END demo sum elements of matrix

            //int[][] jaggedArray =
            //{
            //    new int[] { 5,7,2},
            //    new int[] { 10,20,30,50},
            //    new int[] { 3,25}
            //};

            //foreach (var array in jaggedArray)
            //{
            //    foreach (var element in array)
            //    {
            //        Console.Write($"{element} ");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] jagged = new int[5][];

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    //Получаваме числа от конзолата. За да работи надолу кода, трябва да са разделени с празно място
            //    //Пример - 2 3 4 5 6 56 78 98
            //    string inputNumbers = Console.ReadLine();

            //    string[] numbersArray = inputNumbers.Split(' ');

            //    jagged[i] = new int[numbersArray.Length];

            //    for (int y = 0; y < jagged[i].Length; y++)
            //    {
            //        jagged[i][y] = int.Parse(numbersArray[y]);
            //    }
            //}

            //foreach (var array in jagged)
            //{
            //    foreach (var element in array)
            //    {
            //        Console.Write($"{element} ");
            //    }
            //    Console.WriteLine();
            //}

            // 2 3 4 5 6 7 8 9
            //int[] numbers = Console.ReadLine().Split(' ').Select(element => int.Parse(element)).ToArray();

            //int[] sizes = new int[3];

            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;

            //    sizes[remainder]++;
            //}

            //int[][] jagged =
            //{
            //    new int[sizes[0]],
            //    new int[sizes[1]],
            //    new int[sizes[2]]
            //};

            //int[] offsets = new int[3];

            //foreach (var number in numbers)
            //{
            //    int reminder = number % 3;

            //    int index = offsets[reminder];

            //    jagged[reminder][index] = number;

            //    offsets[reminder]++;
            //}


            //foreach (var array in jagged)
            //{
            //    foreach (var element in array)
            //    {
            //        Console.Write($"{element} ");
            //    }
            //    Console.WriteLine();
            //}

            int height = int.Parse(Console.ReadLine());

            int[][] triangle = new int[height][];

            int currWidth = 1;

            for (int row = 0; row < height; row++)
            {
                triangle[row] = new int[currWidth];

                int[] currentRow = triangle[row];

                currentRow[0] = 1;
                currentRow[currentRow.Length -1] = 1;

                currWidth++;

                if (currentRow.Length>2)
                {
                    for (int i = 1; i < currentRow.Length-1; i++)
                    {
                        int[] previousRow = triangle[row - 1];
                        int previousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = previousRowSum;
                    }
                }

            }

            for (int row = 0; row < height; row++)
            {
                Console.Write("".PadLeft((height - row) * 2));

                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ",triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
