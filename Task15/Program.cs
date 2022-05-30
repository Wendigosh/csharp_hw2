// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7:");
int date = int.Parse(Console.ReadLine());
if (date < 8) 
{
    if (date == 6 || date == 7)
    { Console.WriteLine("Да"); 
    }
else
    
Console.WriteLine("Нет"); }
   else
    Console.WriteLine("Некорректные данные, повторите запрос");
