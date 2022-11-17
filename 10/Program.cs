// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("ВВедите трех значное число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number<1000 && number>99)
{
    
}
Console.WriteLine("Вы ввели не трех значное число ");

int ToEat (int num)
{       
  int res = num / 10 % 10;   
  return res;
}
int result = ToEat(number);

Console.WriteLine(result);