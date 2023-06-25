using System;

namespace GeometryLibrary
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle()
        {
            SetRadius(5);
        }

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

            this._radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override string ToString()
        {
            return $"Радиус круга составляет {_radius}, а площадь - {GetArea()}";
        }
    }
}
