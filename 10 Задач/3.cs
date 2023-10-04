int a;

Console.WriteLine("Введите число:");

a = Convert.ToInt32(Console.ReadLine());

if (a % 4 == 0 || a >= 10)
{
    Console.WriteLine("Подходит");
}

else
{
    Console.WriteLine("Не подходит");
}