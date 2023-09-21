using System;

namespace Program
{
    internal class TCube : TSquare
    {
        public override string ToString()
        {
            return $"Куб зі стороною: {GetSideLength()}";
        }
        
        private double CalculateVolume()
        {
            return CalculateArea() * GetSideLength();
        }
        
        public new void InputData()
        {
            double length = Convert.ToDouble(Console.ReadLine());

            if (length <= 0)
            {
                Console.WriteLine("Довжина сторони повинна бути бiльше нуля!");
            }
            else
            {
                SetSideLength(length);
            }
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