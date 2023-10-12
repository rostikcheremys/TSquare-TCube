using System;

namespace Program
{
    internal class TCube : Square
    {
        public override string ToString()
        {
            return $"Куб зі стороною: {GetSideLength()}";
        }
        
        private double CalculateVolume()
        {
            return CalculateArea() * GetSideLength();
        }
        
        public new void DisplayData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine($"Площа поверхi: {CalculateArea()}");
            Console.WriteLine($"Периметр: {CalculatePerimeter()}");
            Console.WriteLine($"Об'єм куба: {CalculateVolume()}");
        }
    }
}