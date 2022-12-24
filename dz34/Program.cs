//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите ТРЕХЗНАЧНОЕ положительное число: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
int count = 0;

for (int j = 0; j < numbers.Length; j++)
if (numbers[j] % 2 == 0)
count++;

Console.WriteLine($"ВСЕГО {numbers.Length} ЧИСЕЛ(а), {count} - ИЗ НИХ ЧЕТНЫХ ");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ",");
    }
    Console.WriteLine();
}