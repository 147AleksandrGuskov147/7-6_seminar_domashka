// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 

void FillArrayWithRandom(double [,] matrix, int M, int N)
{
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(-10,10), 1); 
            Console.Write(matrix[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива M:  ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива N:  ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] matrix = new double [M,N];
Console.WriteLine();
Console.WriteLine("Ваш случайный массив вещественных чисел: ");
Console.WriteLine();
FillArrayWithRandom(matrix, M, N);
