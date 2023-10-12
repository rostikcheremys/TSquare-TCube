using System;

namespace Program
{
    internal class Square
    {
        private double _sideLength;
        
        public Square()
        {
            _sideLength = 0;
        }

        private Square(double length)
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

        public bool CompareTo(Square otherSquare)
        {
            return _sideLength == otherSquare._sideLength;
        }

        public static Square operator +(Square squareOfFirst, Square squareOfSecond)
        {
            double newLenght = squareOfFirst._sideLength + squareOfSecond._sideLength;
            return new Square(newLenght);
        }
        
        public static Square operator -(Square squareOfFirst, Square squareOfSecond)
        {
            double newLenght = Math.Abs(squareOfFirst._sideLength - squareOfSecond._sideLength);
            return new Square(newLenght);
        }
        
        public static Square operator *(Square length, Square multiplier)
        {
            double multiply = length._sideLength * multiplier._sideLength;
            return new Square(multiply);
        }
    }
}