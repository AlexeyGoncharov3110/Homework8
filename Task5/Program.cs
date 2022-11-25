Console.WriteLine("Введите размеры массива");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
int[,] arraySpiral = ArraySpiral(n, m);
PrintArray(arraySpiral);
int[,] ArraySpiral(int n, int m)
{
    int[,] array = new int[n, m];
    int nBegin = 0;
    int nEnd = 0;
    int mBegin = 0;
    int mEnd = 0;
    int i = 0;
    int j = 0;
    int k = 1;
    while (k <= n * m)
    {
        array[i, j] = k;
        if (i == nBegin && j < m - mEnd - 1)
            ++j;
        else if (j == m - mEnd - 1 && i < n - nEnd - 1)
            ++i;
        else if (i == n - nEnd - 1 & j > mBegin)
            --j;
        else
            --i;
        if ((i == nBegin + 1) && (j == mBegin) && mBegin != m - mEnd - 1)
        {
            ++nBegin;
            ++nEnd;
            ++mBegin;
            ++mEnd;
        }
        ++k;
    }

    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
