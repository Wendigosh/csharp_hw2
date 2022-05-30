// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num = new Random().Next();
Console.WriteLine(num);
if (num >99)
{
string text = num.ToString();
Console.WriteLine("Третья цифра заданного числа = " + text [2]);}
else 
Console.WriteLine("Третьей цифры нет");