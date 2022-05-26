using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_666
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите размерность матрицы");
                int a = int.Parse(Console.ReadLine());

                int[,] mas = new int[a, a];
                Random n = new Random();
                bool check = false;
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        mas[i, j] = n.Next(150);
                        if (mas[i, j] > 100)
                        {
                            check = true;
                        }
                    }
                }

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (check)
                        {
                            mas[i, 0] = 0;
                            mas[0, j] = 0;
                            mas[i, mas.GetLength(1) - 1] = 0;
                            mas[mas.GetLength(0) - 1, j] = 0;
                        }
                        Console.Write(mas[i, j] + " ");
                    }
                    Console.ReadLine();
                }
                Console.ReadKey();
            }
        }
    }
}


