// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11 
// 82 -> 10
// 9012 -> 12

int f(int n)
{
  int sum = 0;
  while (n > 0)
  {
    sum = sum + n%10;
    n = n/10;
  }  
  return sum;
}
Console.Clear();
Console.Write("inter a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));