// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Recours(int n)
{
    if (n == 0)
        return 0;
    else
        Console.Write($"\t{n}");
    return Recours(n-1);
}


Console.Clear();				            //  очистка консоли
Console.WriteLine("Введите число n: ");	    //  запрос числа
int n = Convert.ToInt32(Console.ReadLine());
Recours(n);    