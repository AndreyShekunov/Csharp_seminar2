// Задача 9. Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine($"Сгенерировалось случайное число {number}");

int digital2 = number % 10;
int digital1 = number / 10;

if(digital1 > digital2)
{
    Console.WriteLine($"Наибольшая цифра числа {digital1}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа {digital2}");
}