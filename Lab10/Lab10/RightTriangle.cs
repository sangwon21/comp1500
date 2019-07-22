using System;
public class RightTriangle
{
    public RightTriangle(uint width, uint height)
    {
        Width = width;
        Height = height;
    }

    public uint Width
    {
        get; private set;
    }
    public uint Height
    {
        get; private set;
    }

    public double GetPerimeter()
    {
        double thirdSide = Math.Sqrt(Height * Height + Width * Width);
        double perimeter = Width + Height + thirdSide;
        perimeter = (uint)(perimeter * 1000 + 0.5) / 1000.0;
        return perimeter;
    }

    public double GetArea()
    {
        double area = (Width * (double)Height) / 2;
        area = (uint)(area * 1000 + 0.5) / 1000.0;
        return area;
    }
}