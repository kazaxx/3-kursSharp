int a;

Console.WriteLine("Введите число:");

a = Convert.ToInt32(Console.ReadLine());

if (a % 5 == 2 | a % 7 == 1)
{
    Console.WriteLine("Подходит");
}

else
{
    Console.WriteLine("Не подходит");
}