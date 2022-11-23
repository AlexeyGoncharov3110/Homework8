Console.WriteLine("Введите размеры массива");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
int[,] createArrayOfRandomRealNumbers = СreateArrayOfRandomRealNumbers(m, n);
PrintArray(createArrayOfRandomRealNumbers);
int theRowWithSmallestAmount = TheRowWithSmallestAmount(createArrayOfRandomRealNumbers);
Console.WriteLine();
Console.WriteLine($"номер строки с наименьшей суммой {theRowWithSmallestAmount}");
int TheRowWithSmallestAmount(int[,] array)
{
    int[] minSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        minSum[i] = sum;
    }
    int minIndex = 0;
    for (int k = 0; k < minSum.Length; k++)
    {
        if (minSum[k] < minSum[minIndex])
            minIndex = k;
    }
    return minIndex;
}

int[,] СreateArrayOfRandomRealNumbers(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
