using System;

namespace Program
{
    internal class TCube : TSquare
    {
        protected override double CalculateArea()
        {
            return 6 * Math.Pow(_sideLength, 2);
        }

        protected override double CalculatePerimeter()
        {
            return 12 * _sideLength;
        }

        private double CalculateVolume()
        {
            return Math.Pow(_sideLength, 3);
        }

        public override string ToString()
        {
            return $"Куб зі стороною: {_sideLength}";
        }

        public override void DisplayData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine($"Площа: {CalculateArea()}");
            Console.WriteLine($"Периметр: {CalculatePerimeter()}");
            Console.WriteLine($"Об’єм: {CalculateVolume()}");
        }
    }
}