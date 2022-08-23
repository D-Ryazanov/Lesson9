using System;

class Program
{
    public static void Main(string[] args)
    {

        void Task64()
        {
            //  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
            int M = 0;
            int N = 0;
            int repit = 2;
            while (repit == 2)
            {
                Console.WriteLine("Укажите начальное натуральное число (M)");
                M = Convert.ToInt32(Console.ReadLine());
                if (M > 0)
                {
                    repit--;
                }
                else
                {
                    Console.WriteLine("Указанно неверное число.");
                }
            }
            while (repit == 1)
            {
                Console.WriteLine("Укажите конечное натуральное число (N)");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    repit--;
                }
                else
                {
                    Console.WriteLine("Указанно неверное число.");
                }
                if (N < M)
                {
                    Console.WriteLine("Первое число больше второго, поэтому я поменяю их местами.");
                    int temp = M;
                    M = N;
                    N = temp;
                }
                if (M == N)
                {
                    Console.WriteLine("Указанные числа равны.");
                }
                else
                {
                    Console.WriteLine($"Натуральные числа в промежутке между {M} и {N}:");
                    while (M < N + 1)
                    {
                        if (M % 3 == 0)
                        {
                            Console.Write(M);
                            if (M == N || M + 1 == N || M + 2 == N)
                            {
                                Console.WriteLine(".");
                            }
                            else
                            {
                                Console.Write("; ");
                            }
                        }
                        M++;
                    }
                }

            }
        }


        void Task66()
        {
            // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            int summ = 0;
            int M = 0;
            int N = 0;
            int repit = 2;
            while (repit == 2)
            {
                Console.WriteLine("Укажите начальное натуральное число (M)");
                M = Convert.ToInt32(Console.ReadLine());
                if (M > 0)
                {
                    repit--;
                }
                else
                {
                    Console.WriteLine("Указанно неверное число.");
                }
            }
            while (repit == 1)
            {
                Console.WriteLine("Укажите конечное натуральное число (N)");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    repit--;
                }
                else
                {
                    Console.WriteLine("Указанно неверное число.");
                }
            }
            if (N < M)
            {
                Console.WriteLine("Первое число больше второго, поэтому я поменяю их местами.");
                int temp = M;
                M = N;
                N = temp;
            }
            if (M == N)
            {
                Console.WriteLine("Указанные числа равны.");
            }
            else
            {
                while (M < N + 1)
                {
                    summ += M;
                    M++;
                }
                Console.WriteLine ($"Сумма натуральных элементов в промежутке от {M} до {N} равна {summ}.");
            }
        }

        void Task68()
        {
            // Заполните спирально массив 4 на 4 числами от 1 до 16.
        Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            A(m, n);
            Console.WriteLine (A(m,n));
            
            static int A(int m, int n)
            {
                if (m == 0) return n + 1;
                if (m != 0 && n == 0) return A(m - 1, 1);
                if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
                return A(m,n);
            }
            Console.ReadKey();

        }


        Console.WriteLine("Укажите какое задание хотите проверить (64, 66, 68)");
        int task = Convert.ToInt32(Console.ReadLine());
        if (task == 64)
        {
            Task64();
        }
        else if (task == 66)
        {
            Task66();
        }
        else if (task == 68)
        {
            Task68();
        }
        else
        {
            Console.WriteLine("Такого задания нет.");
        }






    }


    static void FillArray(double[,] array, int min, int max)
    {
        Random random = new Random();
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                array[m, n] = random.Next(min, max);
            }
        }
    }

    static void FillArray(int[,] array, int min = -10, int max = 11)
    {
        Random random = new Random();
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                array[m, n] = random.Next(min, max);
            }
        }
    }
    static void WriteArray(double[,] array)
    {
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                Console.Write(array[m, n] + " ");
            }
            Console.WriteLine();
        }
    }
    static void WriteArray(int[,] array)
    {
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                Console.Write(array[m, n] + " ");
            }
            Console.WriteLine();
        }
    }

    static void WriteArray(int[] array)
    {

        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[n] + " ");
        }
        Console.WriteLine();
    }




}