// Задача 66: Задайте значения M и n. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до n.

// M = 1; n = 15 -> 120
// M = 4; n = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

static int SumNums(int M, int N)
{
    if (M == N)
        return M;
    else
        return M + SumNums(M + 1, N);
}

int M = ReadInt("Введите положительное число M: ");
int N = ReadInt("Введите положительно число N: ");
int sum = SumNums(M, N);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} = {sum}");