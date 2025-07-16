using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Shapes Project.\n");

        // All of this is test code from Steps 1-6:
        // is this a instance of Square?
        Square s1 = new Square("green", 5);
        Console.WriteLine("This is a square:");
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());
        Console.WriteLine();

        Rectangle r1 = new Rectangle("turquoise", 20, 15);
        Console.WriteLine("This is a rectangle:");
        Console.WriteLine(r1.GetColor());
        Console.WriteLine(r1.GetArea());
        Console.WriteLine();

        Circle c1 = new Circle("yellow", 15);
        Console.WriteLine("This is a circle:");
        Console.WriteLine(c1.GetColor());
        Console.WriteLine(c1.GetArea());
        Console.WriteLine();


        Console.WriteLine("\nAdding shapes to a list...\n");
        // This is Step 7: Build a List
        List<Shape> shapes = new List<Shape>();

        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine();

            // This was how the example did it:
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"\nThe {color} shape has an area of {area}.\n");
        }

        // This needs to have a different variable so it is displayed at a different time and doesn't make a duplicate in the same list:
        List<Shape> shapes2 = new List<Shape>();
        foreach (Shape s2 in shapes2)
        {
            // This was how the example did it:
            string color = s2.GetColor();
            double area = s2.GetArea();

            Console.WriteLine($"\nThe {color} shape has an area of {area}.\n");
        }
    }
}