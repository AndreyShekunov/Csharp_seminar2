// Задача 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);

int digital1 = number / 100;
int digital3 = number % 10;

int res = digital1 * 10 + digital3;

Console.WriteLine(res);