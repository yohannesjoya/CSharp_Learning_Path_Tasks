using System;

namespace ShapeHierarchy
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public virtual double CalculateArea()
        {
            return 0;
        }
    }

}
