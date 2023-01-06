// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое положительное число");
int N =  int.Parse(Console.ReadLine());
string Numbers = GetAllNumbersFromNTo1(N);
Console.WriteLine(Numbers);

string GetAllNumbersFromNTo1(int Number, int limit = 1)
{	
    if (Number >= limit) return $"{Number} " + GetAllNumbersFromNTo1 (Number - 1);
    else return String.Empty;				
}