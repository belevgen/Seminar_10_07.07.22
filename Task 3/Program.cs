// Задача 4: Задача 1: Заполните спирально квадратный массив по возрастанию, с заданным размером

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintMultiArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");

            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");

            if (j == array.GetLength(1) - 1) Console.Write(array[i, j] + "]");
        }
        Console.WriteLine("");
    }
}

int[,] FillingArray(int[,] array, int sum = 0, int temp1 = 0)
{
    int row = array.GetLength(0);
    int arraySize = row * row;

    if (arraySize == sum) return array;

    for (int i = temp1; i < row - temp1; i++)
    {
        sum++;
        array[temp1, i] = sum;
    }

    for (int i = temp1 + 1; i < row - temp1; i++)
    {
        sum++;
        array[i, (row - 1) - temp1] = sum;
    }

    for (int i = (row - 1) - temp1 - 1; i >= temp1; i--)
    {
        sum++;
        array[(row - 1) - temp1, i] = sum;
    }

    for (int i = (row - 1) - temp1 - 1; i >= temp1 + 1; i--)
    {
        sum++;
        array[i, temp1] = sum;

    }

    return FillingArray(array, sum, temp1 = temp1 + 1);
}

Console.Clear();

int number = Prompt("Введите сторону массива : ");

int[,] array = new int[number, number];

System.Console.WriteLine();


int[,] newArray = FillingArray(array);

PrintMultiArray(newArray);
