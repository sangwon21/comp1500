using System;
using System.Diagnostics;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(5, 5);

            Debug.Assert(rectangle1.Width == 5);
            Debug.Assert(rectangle1.Height == 5);

            Debug.Assert(rectangle1.GetPerimeter() == 20.000);
            Debug.Assert(rectangle1.GetArea() == 25.000);

            Rectangle rectangle2 = new Rectangle(10, 4);

            Debug.Assert(rectangle2.Width == 10);
            Debug.Assert(rectangle2.Height == 4);

            Debug.Assert(rectangle2.GetPerimeter() == 28.000);
            Debug.Assert(rectangle2.GetArea() == 40.000);

            RightTriangle triangle1 = new RightTriangle(4, 7);

            Debug.Assert(triangle1.Width == 4);
            Debug.Assert(triangle1.Height == 7);

            Debug.Assert(triangle1.GetPerimeter() == 19.062);
            Debug.Assert(triangle1.GetArea() == 14.000);

            RightTriangle triangle2 = new RightTriangle(7, 2);

            Debug.Assert(triangle2.Width == 7);
            Debug.Assert(triangle2.Height == 2);

            Debug.Assert(triangle2.GetPerimeter() == 16.280);
            Debug.Assert(triangle2.GetArea() == 7.000);

            Console.WriteLine("The End");
        }
    }
}
