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
int[,] arrayOfStringsDescending = ArrayOfStringsDescending(createArrayOfRandomRealNumbers);
Console.WriteLine();
PrintArray(arrayOfStringsDescending);
int[,] ArrayOfStringsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPos = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPos])
                    maxPos = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxPos];
            array[i, maxPos] = temp;
        }
    }
    return array;
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
