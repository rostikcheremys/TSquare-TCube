using System;

namespace Program
{
    internal class TSquare
    {
        private double _sideLength;
        
        public TSquare()
        {
            _sideLength = 0;
        }

        private TSquare(double length)
        {
            CheckLengthAndSet(length);
        }
        
        private void CheckLengthAndSet(double length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Довжина сторiн повинна бути бiльше нуля!");
            }
    
            SetSideLength(length);
        }
        
        protected double GetSideLength()
        {
            return _sideLength;
        }

        private void SetSideLength(double length)
        {
            _sideLength = length;
        }

        public override string ToString()
        {
            return $"Квадрат зi стороною: {GetSideLength()}";
        }

        public void InputData()
        {
            double length = Convert.ToInt32(Console.ReadLine());
            
            CheckLengthAndSet(length);
        }

        public void DisplayData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine($"Площа: {CalculateArea()}");
            Console.WriteLine($"Периметр: {CalculatePerimeter()}");
        }

        protected double CalculateArea()
        {
            return _sideLength * _sideLength;
        }

        protected double CalculatePerimeter()
        {
            return 4 * _sideLength;
        }

        public bool CompareTo(TSquare otherSquare)
        {
            return _sideLength == otherSquare._sideLength;
        }

        public static TSquare operator +(TSquare squareOfFirst, TSquare squareOfSecond)
        {
            double newLenght = squareOfFirst._sideLength + squareOfSecond._sideLength;
            return new TSquare(newLenght);
        }
        
        public static TSquare operator -(TSquare squareOfFirst, TSquare squareOfSecond)
        {
            double newLenght = Math.Abs(squareOfFirst._sideLength - squareOfSecond._sideLength);
            return new TSquare(newLenght);
        }
        
        public static TSquare operator *(TSquare length, TSquare multiplier)
        {
            double multiply = length._sideLength * multiplier._sideLength;
            return new TSquare(multiply);
        }
    }
}