namespace ShapeHierarchy
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }
}