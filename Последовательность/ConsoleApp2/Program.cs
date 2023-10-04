int a;

do
{
    Console.WriteLine("Введите целое число:");
    if (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
    {
        Console.WriteLine("Введите положительное целое число.");
    }
}

while (a <= 0);

for (int i = 1; i <= a; i++)
{
    Console.Write(i + " ");
}

for (int i = a - 1; i >= 1; i--)
{
    Console.Write(i + " ");
}

Console.WriteLine();