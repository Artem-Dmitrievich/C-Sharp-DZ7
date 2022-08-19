/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix = new int [n, m];
Console.WriteLine("Вводной массив: ");
for (int i = 0; i < n; i++)//строка
{
    for (int j = 0; j < m; j++)//столбцы
    {
        matrix[i,j] = new Random().Next(0, 100);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: " );
for (int i = 0; i < n; i++)
{
    double srednee = 0;
    for (int j = 0; j < m; j++)
    {
        srednee += matrix[j,i];
    }
    srednee = Math.Round(srednee / m, 1);//округление
    Console.Write(srednee + "\t");
}