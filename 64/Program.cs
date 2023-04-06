// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string OutRutNumber(int Number)
{
  if(Number == 1)
  return 1.ToString();
  Console.Write(Number + " ");
  return OutRutNumber(Number - 1);  
}

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(OutRutNumber(number));

