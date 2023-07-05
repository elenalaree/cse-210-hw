using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes= new List<Shape>();

        Square s1 = new Square("Pink", 7);
        shapes.Add(s1);

        Rectangle r2 = new Rectangle("Green", 8, 2);
        shapes.Add(r2);

        Circle s3   = new Circle("Blue", 3.14);
        shapes.Add(s3);


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}