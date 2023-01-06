// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int sum = GetSumFromMToN(M, N - 1);
Console.WriteLine(sum);

int GetSumFromMToN(int M, int N)
{	
    int sum = 0;
    if (M >= N)
    {
        return 0;  
    }                   
    else
    {
        sum = N + GetSumFromMToN(M, N - 1);
        return sum;
    }  
}