Console.Write("Введите число в бинарном представлении: ");
string userInput = Console.ReadLine();

if (IsBinaryNumber(userInput))
{
    int binaryNumber = Convert.ToInt32(userInput, 2);

    int result = binaryNumber ^ (1 << 1);

    Console.WriteLine($"Число после инверсии второго бита: {result} (в бинарном представлении: {Convert.ToString(result, 2)})");
}
else
{
    Console.WriteLine("Введена некорректная бинарная строка.");
}

static bool IsBinaryNumber(string input)
{
    foreach (char c in input)
    {
        if (c != '0' && c != '1')
        {
            return false;
        }
    }
    return true;
}
