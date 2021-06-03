using System;

namespace ConsoleApp9
{

    class Program
    {
        static void Matrix(int row, double[,] A, double[,] a, double[] B, double[] b) //Метод, создающий массивы с коэффицентами основной матрицы и с элементами столбца свободных членов. Также метод заполняет массивы
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                Console.WriteLine();
                Console.WriteLine("Введите коэфициенты и свободные члены: ");
                Console.WriteLine();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        Console.Write($"A[{i + 1}][{j + 1}]= ");
                        A[i, j] = Convert.ToDouble(Console.ReadLine());
                        a[i, j] = A[i, j];
                    }
                    Console.Write($"B[{i + 1}]= ");
                    B[i] = Convert.ToDouble(Console.ReadLine());
                    b[i] = B[i];
                    Console.WriteLine();
                    Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                }
            }
            catch
            {
                Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                Console.WriteLine();
                Console.WriteLine("Введены неверные символ(ы)!\nПовторите ввод, пожалуйста");
                Console.WriteLine();
                Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                Matrix(row, A, a, b, b);
            }
            Console.WriteLine();
        }
        static void vivodMatrix(int row, double[,] A, double[,] a, double[] B, double[] b) //Метод, который выводит в консоль систему линейных уравнений
        {
            Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (a[i, j] >= 0 && j != 0)
                        Console.Write("{0, -1} {1, -4}", "+", $"{a[i, j]}x");
                    else if (a[i, j] < 0)
                        Console.Write("{0, -1} {1, -4}", "-", $"{a[i, j] * (-1)}x");
                    else if (a[i, j] >= 0 && j == 0)
                        Console.Write("{0, -1} {1, -4}", " ", $"{a[i, j]}x");
                }
                Console.Write("{0, -1} {1, 3}", "=", $"{b[i]}");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
        }
        static void izmMatrix(int row, double[,] A, double[,] a, double[] B, double[] b, double[] x, double s, double d) //Метод, позволяющий пользователю изменить либо один коэффицент в основной матрице системы, либо один из элентов столбца свободных членов
        {
            Console.WriteLine("Хотите ли вы изменить один из элементов матрицы?\n 1 - Да, 2 - Нет");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
            switch (n)
            {
                case 1:
                    Console.WriteLine("Что изменить?\n 1 - Коэффицент, 2 - Элемент в столбце свободных членов");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                    switch (n2)
                    {
                        case 1:
                            Console.WriteLine("Введите число, которое хотите изменить: ");
                            double chislo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                            Console.WriteLine("Введите новое число: ");
                            double chisloZam = Convert.ToDouble(Console.ReadLine());
                            for (int i = 0; i < row; i++)
                            {
                                for (int j = 0; j < row; j++)
                                {
                                    if (a[i, j] == chislo && A[i, j] == chislo)
                                    {
                                        a[i, j] = chisloZam;
                                        A[i, j] = chisloZam;
                                    }
                                }
                            }
                            preobrMatrix(row, A, B, x, s, d);
                            break;
                        case 2:
                            Console.WriteLine("Введите число, которое хотите изменить: ");
                            double chislo2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите новое число: ");
                            double chisloZam2 = Convert.ToDouble(Console.ReadLine());
                            for (int i = 0; i < row; i++)
                            {
                                if (b[i] == chislo2 && B[i] == chislo2)
                                {
                                    b[i] = chisloZam2;
                                    B[i] = chisloZam2;
                                }
                            }
                            preobrMatrix(row, A, B, x, s, d);
                            break;
                    }
                    break;
                case 2:
                    preobrMatrix(row, A, B, x, s, d);
                    break;
            }
        }
        static void preobrMatrix(int row, double[,] A, double[] B, double[] x, double s, double d) //Метод, который с помощью элементарных преобразований вычисляет корни системы
        {
            for (int k = 0; k < row; k++)
            {
                for (int j = k + 1; j < row; j++)
                {
                    d = A[j, k] / A[k, k];
                    for (int i = k; i < row; i++)
                    {
                        A[j, i] = A[j, i] - d * A[k, i];
                    }
                    B[j] = B[j] - d * B[k];
                }
            }
            for (int k = row - 1; k >= 0; k--)
            {
                d = 0;
                for (int j = k; j < row; j++)
                {
                    s = A[k, j] * x[j];
                    d += s;
                }
                x[k] = (B[k] - d) / A[k, k];
            }
        }
        static void vivodkorney(int row, double[] x) //Метод, отвечающий за вывод корней в консоль
        {
            Console.WriteLine("Корни СЛУ: ");
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine($"x[{i}]= {x[i]}");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
        nachalo:
            int row;
            double d = 0;
            double s = 0;
            Console.Write("Введите размерность матрицы (обязательно, чтобы значение было число12312312312312м!!!): ");
            row = Convert.ToInt32(Console.ReadLine());
            double[,] A = new double[row, row];
            double[,] a = new double[row, row];
            double[] B = new double[row];
            double[] b = new double[row];
            double[] x = new double[row];
            Matrix(row, A, a, B, b);
            vivodMatrix(row, A, a, B, b);
            izmMatrix(row, A, a, B, b, x, s, d);
            vivodMatrix(row, A, a, B, b);
            vivodkorney(row, x);
            Console.WriteLine("Желаете ли вы продолжить работу ?\n 1-Да, 2-Нет");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    goto nachalo;
                case 2:
                    break;
            }
        }
    }
}


