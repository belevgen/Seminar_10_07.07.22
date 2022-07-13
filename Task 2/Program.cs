// Задача 2: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

double Prompt(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine());
}

double FunctionAckermann(double m, double n)
{
    if (m == 0) return n + 1;
    if ((m != 0) && (n == 0)) return FunctionAckermann(m - 1, 1);
    else return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
}

double m = Prompt(" Введите m: ");
double n = Prompt(" Введите n: ");

double ackermann = FunctionAckermann(m, n);

System.Console.WriteLine($"Расчёт функции Аккермана для m {m} и n {n} равняется {ackermann}");
