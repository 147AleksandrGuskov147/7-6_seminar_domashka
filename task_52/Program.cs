// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] matrix = new int[m,n];
Console.Write("Ваш случайный массив:  ");
Console.WriteLine();
FillArrayWithRandom(matrix, m, n);

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(0, 11);
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

for(int j = 0; j < n; j++)
{
    double sum = 0;
    for(int i = 0; i < m; i++)
    {
        sum+= matrix[i,j];
    }
    Console.WriteLine($"Среднее арифметическое столбца {j+1} = {Math.Round(sum/m, 2)} ");
}
Console.WriteLine();