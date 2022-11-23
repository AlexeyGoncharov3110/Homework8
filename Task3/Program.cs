Console.WriteLine("Введите размеры первого массива");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
Console.WriteLine("Введите размеры второго массива");
bool isParsedK = int.TryParse(Console.ReadLine(), out int k);
bool isParsedL = int.TryParse(Console.ReadLine(), out int l);
if (!isParsedK || !isParsedL)
{
    Console.WriteLine("Ошибка!");
    return;
}
if (n != k)
{
    Console.WriteLine("Матрицы не могут быть перемноженны , введите корректные данные ");
    return;
}
int[,] createArrayOfRandomRealNumbers = СreateArrayOfRandomRealNumbers(m, n);
int[,] createArrayOfRandomRealNumbers2 = СreateArrayOfRandomRealNumbers(k, l);
int[,] theProductOfTwoMatrices = TheProductOfTwoMatrices(
    createArrayOfRandomRealNumbers,
    createArrayOfRandomRealNumbers2
);
PrintArray(createArrayOfRandomRealNumbers);
Console.WriteLine();
PrintArray(createArrayOfRandomRealNumbers2);
Console.WriteLine();
PrintArray(theProductOfTwoMatrices);
int[,] TheProductOfTwoMatrices(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                array[i, j] = array[i, j] + (array1[i, k] * array2[k, j]);
            }
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
            array[i, j] = random.Next(-10, 10);
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
