// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines, columns];
Console.Write("Начальное значение: ");
int val = Convert.ToInt32(Console.ReadLine());

int i = 0, k = 0, j;

while (i < lines * columns)
{
    k++;
    for (j = k -1; j < columns - k + 1; j++)
    {
        numbers[k - 1, j] = val++;
        i++;
    }
    for (j = k -1; j < columns - k + 1; j++)
    {
        numbers[k - 1, j] = val++;
        i++;
    }
    for (j = columns - k - 1; j >= k - 1; j--)
    {
        numbers[lines - k, j] = val++;
        i++;
    }
    for (j = lines - k - 1; j >= k; j--)
    {
        numbers[j, k - 1] = val++;
        i++;
    }
}
