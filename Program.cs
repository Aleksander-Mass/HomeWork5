// Знакомство с языками программирования (семинары)
// Урок 5. Функции продолжение
/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
/*

Console.Write("Input positive integer number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive integer number B: ");
int b = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double e = a;
    if (a >= 2 && b >= 2)
    {
        while (i < b )
        {
            e = e * a;
            i++;
        }
        
    }
    else
    {
        Console.WriteLine("Enter the correct number");
        return;
    }
Console.WriteLine(a + ", " + b + " -> " + e);
*/

// Знакомство с языками программирования (семинары)
// Урок 5. Функции продолжение
/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*
Console.Write("Input positive integer number: ");
String StringNumber = Console.ReadLine(); 

void SumNumber()
{
    int sum = 0;
        // Считывает число в строку StringNumber
    Char[]CharNumber = StringNumber.ToCharArray(); 
        // Переводим строку StringNumber в Массив символов CharNumber[]
    for (int i = 0; i < StringNumber.Length; i++)
        {
            sum += Convert.ToInt32(StringNumber[i]-'0');  
            // Convert.ToInt32 переводит символ в число (точней сказать в юникод числа, 
            // поэтому мы отнимаем -'0' для того чтобы из юникода получить число)
        }
    //Console.WriteLine("4islo   " + StringNumber);
    //Console.WriteLine("summa 4isel ravna " + sum);
    Console.WriteLine(StringNumber + " -> " + sum);
}
SumNumber();
*/
/*
// Знакомство с языками программирования (семинары)
// Урок 5. Функции продолжение
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
/*
int N;
while (true)
{
    Console.Write("Введите размер массива: ");
    N = Convert.ToInt32(Console.ReadLine());
    
    if (N < 9 && N > 7)
        break;
}
 
int[] A = new int[N];
 
Random random = new Random();
for (int i = 0; i < N; i++)
{
    A[i] = random.Next(0, 99);
}
Console.Write(A[0]);
for (int i = 1; i < N; i++)
{
    Console.Write(", " + A[i]);
}

Console.Write(" -> [" + A[0]);
for (int i = 1; i < N; i++)
{
    Console.Write(", " + A[i]);
}
Console.Write("]");
Console.WriteLine();
*/