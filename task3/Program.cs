// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
uint M = uint.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
uint N = uint.Parse(Console.ReadLine());
uint ackermanFunction = AckermanFunction(M, N);
Console.WriteLine(ackermanFunction);

uint AckermanFunction(uint M, uint N)
{
  if (M == 0)
    return N + 1;
  else
    if ((M != 0) && (N == 0))
      return AckermanFunction(M - 1, 1);
    else
      return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
}