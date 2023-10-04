int radius;

Console.WriteLine("Ведите радиус: ");
radius = Convert.ToInt32(Console.ReadLine());

double C = 2 * Math.PI * radius;
Console.WriteLine("Длина окружности = " + C);

public sealed class Circle
{
    private double radius;
    public double Calculate(Func<double, double> op)
    {
        return op(radius);
    }
}
