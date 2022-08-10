
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
Console.Write("A:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
Console.Write("B:  ");
int b = Convert.ToInt32(Console.ReadLine());

int i = 0;
int result = 1; 
if(a > 0 && b > 0 )
{
  while(b > i)
  {
  result = a * result;
  i=i+1;
  // Console.WriteLine($"{result}");
  }
Console.WriteLine($"{result}");
}   
 
else Console.WriteLine("Введены некорректные данные");





