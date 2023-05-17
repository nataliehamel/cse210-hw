using System;

class Program
{
    static void Main(string[] args)
    {
        List<shape> shapes = new List<shape>();

        square s1 = new square("Red", 3);
        shapes.Add(s1);

        rectangle s2 = new rectangle("Blue", 4, 5);
        shapes.Add(s2);

        circle s3 = new circle("Green", 6);
        shapes.Add(s3);

        foreach (shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}