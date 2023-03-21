// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number/10000==number%10 && (number/1000)%10==(number/10)%10)
// {
//     Console.WriteLine("Это число - палиндром!");
// }
// else
// {
//     Console.WriteLine("Это число - не палиндром!");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату Х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double S = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);

// Console.WriteLine (S);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}