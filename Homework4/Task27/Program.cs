// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int getSum(int numberA)
{
  int sum = 0;
  while (numberA > 0)
  {
    int number = numberA % 10;
    sum = sum + number;
    numberA = numberA / 10;
  }
  return sum;
}
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine(getSum(numberA));
