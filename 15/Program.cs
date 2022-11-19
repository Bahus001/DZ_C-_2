// Задача 15: Напишите программу, 
// которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру обозначающую неделю ");
int number = Convert.ToInt32(Console.ReadLine());

bool Week(int num)
{
    return num > 0 && num < 6;
}

if (number > 0 && number < 8)
{
bool res = Week(number);
Console.WriteLine(res ? "Нет" : "Да");
}
else
Console.WriteLine("Ошибка! введите цифру от 1 до 7");
