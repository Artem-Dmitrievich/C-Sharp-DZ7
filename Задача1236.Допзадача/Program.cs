/*
Транспонирование - 4
Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.
Входные данные
Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы. 
В каждой из последующих N строк записаны M целых чисел – элементы матрицы. 
Все числа во входных данных не превышают 100 по абсолютной величине.
Выходные данные
В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.
*/
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, m];
int [,] transmatrix = new int [m, n];
Console.WriteLine();
Console.WriteLine("Вводная матрица: ");
for (int i = 0; i < n; i++)//строки
{
    for (int j = 0; j < m; j++)//столбцы
    {
        matrix[i,j] = new Random().Next(0,100);
        transmatrix[j, i] = matrix [i, j];
        Console.Write(matrix[i, j] + "\t");// \t - табуляция
    }
    Console.WriteLine();
}
Console.WriteLine();
//Транcпонирование матрицы(смена мест строк и столбцов)
Console.WriteLine("Транспонированная матрица: ");
for (int j = 0; j < n; j++)
{
    for (int i = 0;i < m; i++)
    {
        Console.Write(transmatrix[j, i] + "\t");
    }
    Console.WriteLine();
}
