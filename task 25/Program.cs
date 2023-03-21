// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int f(int x, int y)
{
  int z = 1;
  if (x == 0 && y != 0)
    return 0;
    else if (x != 0 && y == 0)
    return 1;
    else if (x == 0 && y == 0)
    Console.Write("error");
  else  
  for (int i = 1; i <= y; i++)
    {
      z = z*x;
    }
  return z;
}

Console.Clear();
Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a, b));