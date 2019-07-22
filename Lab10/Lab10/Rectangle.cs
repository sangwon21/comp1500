public class Rectangle
{
    public Rectangle(uint width, uint height)
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
        return (double)(Width + Height) * 2;
    }

    public double GetArea()
    {
        return (Width * (double)Height);
    }
}
