using System;

namespace GeometryLibrary
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            SetRadius(radius);
        }

        public void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом");
            }

            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"Радиус круга составляет {radius}, а площадь - {GetArea()}";
        }
    }
}
