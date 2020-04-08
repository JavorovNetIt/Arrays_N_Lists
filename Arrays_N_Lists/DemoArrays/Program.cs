using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[6];

            //for (int i = 1; i <= 6; i++)
            //{
            //    Console.WriteLine(numbers[i-1]);
            //}

            //int[] numbers = { 3, 5, 6, 7, 1, 20 };
            //int[] numbers = new int[6];

            //Console.Write(string.Join(',', numbers));

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //}

            //Console.WriteLine();

            //Console.Write(string.Join(',', numbers));

            //string[] daysOfWeek = { "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday", "Sunday" };

            //Console.WriteLine(string.Join("; ",daysOfWeek));

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int lenght = numbers.Length;

            //int[] reversed = new int[lenght];

            //for (int i = 0; i < lenght; i++)
            //{
            //    reversed[lenght - 1 - i] = numbers[i];
            //}

            //Console.WriteLine(string.Join(", ",reversed));

            //Console.WriteLine("Give me lenght of array");
            //int lenght = int.Parse(Console.ReadLine());

            //int[] array = new int[lenght];
            //Console.WriteLine($"Fill the array with {lenght} numbers");

            //for (int i = 0; i < lenght; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("End of filling");
            //Console.WriteLine($"This is your array {string.Join(", ",array)}");

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(string.Join(", ", numbers));

            //numbers[0] = 10;

            //Console.WriteLine(string.Join(", ", numbers));

            //string[] daysOfWeek = { "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday", "Sunday" };

            //foreach (var dayOfWeek in daysOfWeek)
            //{
            //    Console.WriteLine(dayOfWeek);
            //}

            //Console.WriteLine("Please enter a positive number");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];

            //Console.WriteLine("Please enter the values for the array");

            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //bool symmetric = true;

            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (array[i] != array[n - 1 - i])
            //    {
            //        symmetric = false;
            //        break;
            //    }
            //}

            //Console.WriteLine($"Is the array symetric? {symmetric}");

            //int[] numbers = new int[6];

            //List<int> numbersList = new List<int>() { 1 , 2, 3, 4,5};

            ////numbersList.Add(2);

            ////numbersList.Clear();

            //List<int> numbersToAdd = new List<int>() { 6, 7, 8 };

            //numbersList.AddRange(numbersToAdd);

            //Console.WriteLine(string.Join(", ",numbersList));

            Console.WriteLine("Hello in shop");

            List<string> products = new List<string>() { "домат", "краставица", "банан", "киви", "круша" };

            //Console.WriteLine("Колко неща ще си купите?");
            Console.WriteLine($"Нашите продукти са: {string.Join(", ", products)}");
            List<string> shoppingCart = new List<string>();

            string product = Console.ReadLine();

            while (product != "стоп")
            {
                if (!products.Contains(product))
                {
                    Console.WriteLine("Няма такъв продукт");
                    product = Console.ReadLine();
                    continue;
                }
                shoppingCart.Add(product);

                product = Console.ReadLine();
            }

            if (shoppingCart.Any(p => p == "банан"))
            {
                Console.WriteLine("Имаш нещо здравословно в кошницата");
            }

            Console.WriteLine(string.Join(", ", shoppingCart));

        }

        public static void ChangeList(List<int> list)
        {
            list.Add(3);
        }

        public static void ChangeInt (int a)
        {
            a = 5;
        }

        public static void ChangString(string a)
        {
            a = "Changed";
        }
    }
}
