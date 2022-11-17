// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("ВВедите число ");
int number = Convert.ToInt32(Console.ReadLine());

int Three(int num1)
{
    int result = 0;
    if (num1 < 100);
    return num1;
    if (num1 > 999);
    {
        while (num1 < 10000)
        {
            num1 = num1 / 10;
        }
        result = num1 % 10;
        return result;
    }
}
int enter = Three(number);
Console.WriteLine(Three(enter));