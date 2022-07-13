// Задача 1: Есть монотонная последовательность, каждое число встречается ровно
// то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите
// ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"


int Prompt(string message)
{
    Console.Write(message);
    return  int.Parse(Console.ReadLine());
}

void SubsequenceNumbers(int amount, int numbers = 1, int sum = 0, int temp = 0)
{
    if (amount == sum) 
    {
    System.Console.WriteLine();
    return;
    }
    
    if (numbers == temp)
    {
        temp = 0;
        numbers++;
    }

    System.Console.Write($"{numbers} ");
    SubsequenceNumbers(amount, numbers, sum=sum+1, temp = temp + 1);
}

int numbers=  Prompt("Ведите число: ");

SubsequenceNumbers(numbers);
