// Напишите программу, которая будет создавать массив из 8 символов и заполнять значениями от пользователя
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// вводит массив из 8 элементов заполненый 0 и 1 в случайном порядке

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2);
}

Console.Clear();
int[] array = new int[8];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");