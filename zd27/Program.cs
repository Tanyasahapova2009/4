// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
int sum = 0;
            int n;
            n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                sum += n % 10;   
                
                n = n / 10;
            }
            
            Console.WriteLine("сумма цифр в числе " + sum);

