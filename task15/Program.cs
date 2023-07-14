// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, обозначающее день недели: ");
int number = int.Parse(Console.ReadLine());
if (number < 6)
{
    Console.WriteLine($"{number} -> нет");
}
if (number == 6)
{
    Console.WriteLine($"{number} -> да");
}
if (number == 7)
{
    Console.WriteLine($"{number} -> да");
}
else
{
   Console.WriteLine("Некорректный ввод"); 
}
