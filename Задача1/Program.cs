/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/ 
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m]; 
Random rnd = new Random();
for (int i = 0; i < n; i++)//*строки
{
    for (int j = 0; j < m; j++)//*столбцы
    {
        matrix[i,j] = ((rnd.NextDouble()* 2 - 1) * 100);//случайное вещественное число от 0 до 1 *для себя ссылка https://docs.microsoft.com/en-us/dotnet/api/system.random.nextdouble?view=netcore-3.1*
        Console.Write("{0,6:F2}",  matrix[i, j]);
    }                  //сокращение до 2-х знаков после запятой
    Console.WriteLine();
}

