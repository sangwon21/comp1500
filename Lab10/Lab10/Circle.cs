using System;
public class Circle
{
    public Circle(uint radius)
    {
        Radius = radius;
        Diameter = 2 * radius;
    }
    public uint Radius
    {
        get; private set;
    }
    public uint Diameter
    {
        get; private set;
    }

    public double GetCircumference()
    {
        double circumference = Math.PI * Diameter;
        circumference = (uint)(circumference * 1000 + 0.5) / 1000.0;
        return circumference;
    }

    public double GetArea()
    {
        double area = (Radius * Radius) * Math.PI;
        area = (uint)(area * 1000 + 0.5) / 1000.0;
        return area;
    }
}