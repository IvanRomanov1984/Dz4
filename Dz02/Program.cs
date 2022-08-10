
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число  ");
int i = Convert.ToInt32(Console.ReadLine());
int temp = 0;

while (i != 0)
{
    temp=temp + i %10;
    i= i / 10;
}

Console.WriteLine($"{temp}");

