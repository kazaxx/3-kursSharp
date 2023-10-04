﻿public sealed class Circle
{
    private double radius;

    public double Calculate(Func<double, double> op)
    {
        return op(radius);
    }
}