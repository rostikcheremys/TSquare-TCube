using System;

namespace Program
{
    internal class TSquare
    {
        private protected double _sideLength;
        
        public TSquare()
        {
            _sideLength = 0.5;
        }

        private TSquare(double sideLength)
        {
            if (sideLength <= 0)
            {
                throw new ArgumentException("Довжина сторiн повинна бути бiльше нуля!");
            }
            _sideLength = sideLength;
        }
        
        public TSquare(TSquare otherSquare)
        {
            _sideLength = otherSquare._sideLength;
        }
        
        public override string ToString()
        {
            return $"Квадрат зі стороною: {_sideLength}";
        }
        
        public void InputData()
        {
            double length = Convert.ToDouble(Console.ReadLine());
            
            if (length <= 0)
            {
                throw new ArgumentException("Довжина сторiн повинна бути бiльше нуля!");
            }
            _sideLength = length;
        }
        
        public virtual void DisplayData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine($"Площа: {CalculateArea()}");
            Console.WriteLine($"Периметр: {CalculatePerimeter()}");
        }
        
        protected virtual double CalculateArea()
        {
            return Math.Pow(_sideLength, 2);
        }

        protected virtual double CalculatePerimeter()
        {
            return 4 * _sideLength;
        }
        
        public bool CompareTo(TSquare otherSquare)
        {
            return _sideLength == otherSquare._sideLength;
        }
        
        public static TSquare operator +(TSquare square1, TSquare square2)
        {
            double newLength = square1._sideLength + square2._sideLength;
            return new TSquare(newLength);
        }

        public static TSquare operator -(TSquare square1, TSquare square2)
        {
            double newLength = Math.Abs(square1._sideLength - square2._sideLength);
            return new TSquare(newLength);
        }

        public static TSquare operator *(TSquare square, double multiplier)
        {
            double newLength = square._sideLength * multiplier;
            return new TSquare(newLength);
        }
    }
}
