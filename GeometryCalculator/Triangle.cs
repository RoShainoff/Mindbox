using System;

namespace GeometryLibrary
{
    public class Triangle : Figure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle()
        {
            SetSides(3, 4, 5);
        }

        public Triangle(double side1, double side2, double side3)
        {
            SetSides(side1, side2, side3);
        }

        public void SetSides(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными числами");
            }

            if (!IsTriangleValid(side1, side2, side3))
            {
                throw new ArgumentException("Недопустимые стороны треугольника. Треугольник не может существовать с заданными длинами сторон");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double GetArea()
        {
            // Используем формулу Герона для вычисления площади треугольника
            // Можно реализовать как и a*b/2, но мы не знаем, под какой стороной пользователь воспримет a,b,c
            double semiPerimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiPerimeter *
                                    (semiPerimeter - side1) *
                                    (semiPerimeter - side2) *
                                    (semiPerimeter - side3));
            return area;
        }

        public bool IsRightTriangle()
        {
            // Проверяем, является ли треугольник прямоугольным, используя теорему Пифагора
            double a = Math.Pow(side1, 2);
            double b = Math.Pow(side2, 2);
            double c = Math.Pow(side3, 2);

            return a == b + c || b == a + c || c == a + b;
        }

        public override string ToString()
        {
            string isRightTriangle = IsRightTriangle() ? "является" : "не является";
            return $"Треугольник со сторонами {side1}, {side2}, {side3} и площадью {GetArea} {isRightTriangle} прямоугольным";
        }

        private bool IsTriangleValid(double side1, double side2, double side3)
        {
            // Теорема о неравенстве треугольника: Сумма длин любых двух сторон треугольника должна быть больше или равна длине третьей стороны.
            return (side1 + side2 >= side3) && (side1 + side3 >= side2) && (side2 + side3 >= side1);
        }
    }
}
