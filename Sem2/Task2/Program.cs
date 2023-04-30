// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 999)
    {
     num = num/10;
    }
    System.Console.WriteLine($"{num %10}");
}
