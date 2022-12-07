// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("ВВедите основание степени а=");

 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("введите показатель степени в=");
 int b = Convert.ToInt32(Console.ReadLine());
float c = MathF.Pow(a, b);

Console.WriteLine($"число a возведенное в степень в {c}");
