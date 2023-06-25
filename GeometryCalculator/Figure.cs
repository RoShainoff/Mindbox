using System;

namespace GeometryLibrary
{
    public abstract class Figure
    {
        public abstract double GetArea();

        public override string ToString()
        {
            return $"Площадь фигуры {GetType().Name} - {GetArea()}";
        }
    }
}
