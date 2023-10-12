using System;

namespace Program
{
    internal static class Program
    {
        public static void Main()
        {
            Console.Write("Введiть довжину сторони квадрата: ");
            Square square = new Square();
            
            square.InputData();
            square.DisplayData();
            
            Console.Write("\nВведiть довжину сторони куба: ");
            TCube cube = new TCube();
            
            cube.InputData();
            cube.DisplayData();
            
            Console.Write("\nДодавання довжин сторон квадрата:\nВведiть першу довжину: ");
            Square numberOfFirstSum = new Square();
            
            numberOfFirstSum.InputData();
            
            Console.Write("Введiть другу довжину: ");
            Square numberOfSecondSum = new Square();
            
            numberOfSecondSum.InputData();
            
            Square sum = numberOfFirstSum + numberOfSecondSum;
            Console.WriteLine($"\nРезультат: \n{sum}");
            
            Console.Write("\nВіднімання довжин сторон квадрата:\nВведiть першу довжину: ");
            Square numberOfFirstDiff = new Square();
            
            numberOfFirstDiff.InputData();
            
            Console.Write("Введiть другу довжину: ");
            Square numberOfSecondDiff = new Square();
            
            numberOfSecondDiff.InputData();
            
            Square diff = numberOfFirstDiff - numberOfSecondDiff;
            Console.WriteLine($"\nРезультат: \n{diff}");
            
            Console.Write("\nМноження довжини сторони квадрата:\nВведiть довжину: ");
            Square length = new Square();
            
            length.InputData();
            
            Console.Write("Введiть число, на яке ви хочете помножити: ");
            Square multiplier = new Square();
            
            multiplier.InputData();
            
            Square multiply = length * multiplier;
            Console.WriteLine($"\nРезультат: \n{multiply}");
            
            Console.WriteLine("\nПорiвняння двох квадратiв(при додаванні та відніманні):");
            bool result = sum.CompareTo(diff);
            Console.WriteLine($"Результат: {result}");
        }
    }
}