//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

/*
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num /10;
    }
    return sum;
}
int sumNumber = SumNum(num);
Console.WriteLine($"{num} -> {sumNumber}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*
int [] RandomArray (int size, int minValue, int maxValue)
{
    int [] newArrey = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().Next(minValue, maxValue + 1 );
        
    }
    return newArrey;
}

void PrintArray(int[] array)
{
    Console.Write("Массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальную единицу массива ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальную единицу массива ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArrey = RandomArray(a,min,max);
PrintArray(myArrey);
*/

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите А  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B ");
int b = Convert.ToInt32(Console.ReadLine());

void Stepen (int a, int b)
{
    int sum = 1;
    for (int i = 1; i <= b; i++)
    {        
        sum = sum * a;
    }
    Console.WriteLine($"{a},{b} -> {sum}");
}
Stepen(a,b);
