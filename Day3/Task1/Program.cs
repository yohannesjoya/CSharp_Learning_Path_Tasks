namespace ShapeHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle { Name = "Circle", Radius = 5 };
            var rectangle = new Rectangle { Name = "Rectangle", Width = 10, Height = 20 };
            var triangle = new Triangle { Name = "Triangle", Base = 10, Height = 5 };

            PrintShapeArea(circle);
            PrintShapeArea(rectangle);
            PrintShapeArea(triangle);
        }

        static void PrintShapeArea(Shape shape)
        {
            Console.WriteLine("{0} area: {1}", shape.Name, shape.CalculateArea());
        }
    }

}