Console.WriteLine("Введите размеры трёхмерного массива");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);
bool isParsedZ = int.TryParse(Console.ReadLine(), out int z);
if (!isParsedX || !isParsedY || !isParsedZ)
{
    Console.WriteLine("Ошибка!");
    return;
}
int[,,] createArray3D = CreateArray3D(x,y,z);
PrintArray3D(createArray3D);
int[,,] CreateArray3D(int x , int y, int z)
{
    int [,,] array = new int [x,y,z];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(10, 99);
                while (Contains(array, array[i, j, k]))
                {
                    array[i, j, k] = random.Next(10, 99);
                }
            }
        }
    }
    return array;
}
bool Contains(int[,,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                    count++;
            }
        }
    }
    return count>1;
}
void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} = ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
