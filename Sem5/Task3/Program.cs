﻿//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < array.Length; a++)
{
    if (array[a] > max)
        {
            max = array[a];
        }
    if (array[a] < min)
        {
            min = array[a];
        }
}

Console.WriteLine($"всего {array.Length} чисел. Максимальный элемент = {max}, минимальный элемент = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}