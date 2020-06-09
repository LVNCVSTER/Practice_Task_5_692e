using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int number;
            Console.WriteLine("Введите размер матрицы не меньше 3х3");
            while(!Int32.TryParse(Console.ReadLine(), out number) && number < 3)
            {
                Console.WriteLine("Введите размер матрицы не меньше 3х3");
            }
            do
            {

                int q = number;
                int[,] A = new int[q,q];
            Random rand = new Random();

                for (int i = 0; i < q; i++)
                {
                    for (int j = 0; j < q; j++)
                    {
                    A[i, j] = rand.Next(100);
                        Console.Write(A[i, j] + "\t");
                        if (max < A[i,j] && j <= i && j >= q - i - 1)
                            max = A[i,j];
                    }
                    Console.WriteLine();
                
                }
            
            }
            while (max == 1);
            Console.WriteLine();
            Console.WriteLine(max);
        }
    }
}
