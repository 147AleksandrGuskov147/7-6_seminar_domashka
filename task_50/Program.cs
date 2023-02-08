// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

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

Console.Write("Введите количество строк массива m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix, m, n);

Console.Write("Введите значение строки (i):  ");
int III = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца (j):  ");
int JJJ = Convert.ToInt32(Console.ReadLine());

if (m < III || n < JJJ)
Console.WriteLine("Такого числа в массиве нет"); 
else
Console.WriteLine($"Значение массива для заданных координат = {matrix[III,JJJ]}  ");


// for(int i = 0; i < m; i++)
// {
//     for(int j = 0; j < n; j++)
//     {
//         // if(i<=III && III<=m && j<=JJJ && JJJ<=n)
//         if(i == III && j == JJJ)
//         {
//         Console.WriteLine($"Значение массива для заданных координат = {matrix[III,JJJ]}  ");
//         }
//         else if (m < III && n < JJJ)
//         {
//         Console.WriteLine("Такого числа в массиве нет"); 
//         break;  
//         }
//     }
// }