int a, b;

Console.WriteLine("Введите число:");

a = Convert.ToInt32(Console.ReadLine());

b = a / 1000 % 10;

Console.WriteLine("В этом числе " + b + " тысяч");