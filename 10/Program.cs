// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("ВВедите трех значное число ");
int number = Convert.ToInt32(Console.ReadLine());

int ToEat(int num)
{
    {
        num = num / 10 % 10;
    }
    return num;
}
if (number > 99 && number < 1000)
{
    int result = ToEat(number);
    Console.WriteLine(result);
}
else Console.WriteLine("Ошибка! введено не трех значное число");

