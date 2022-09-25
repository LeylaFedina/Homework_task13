/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.WriteLine ("введите число от 1 до бесконечности");  
int Number = Convert.ToInt32(Console.ReadLine()); 
int Thirddigit =-1;
while (Number>99)
{
    Thirddigit=Number%10;
    Number=Number/10;
}
if (Thirddigit>=0)
    {
        Console.WriteLine($"третья цифра заданного числа {Thirddigit}");
    }
else
{
    Console.WriteLine($"у числа {Number} нет третьей цифры");
}