using System;

namespace Program
{
    internal static class Program
    {
        public static void Main()
        {
            Console.Write("Введiть довжину сторони квадрата: ");
            TSquare square = new TSquare();
            
            square.InputData();
            square.DisplayData();
            
            Console.Write("\nВведiть довжину сторони куба: ");
            TCube cube = new TCube();
            
            cube.InputData();
            cube.DisplayData();
            
            Console.Write("\nДодавання довжин сторон квадрата:\nВведiть першу довжину: ");
            TSquare numberOfFirstSum = new TSquare();
            
            numberOfFirstSum.InputData();
            
            Console.Write("Введiть другу довжину: ");
            TSquare numberOfSecondSum = new TSquare();
            
            numberOfSecondSum.InputData();
            
            TSquare sum = numberOfFirstSum + numberOfSecondSum;
            Console.WriteLine($"\nРезультат: \n{sum}");
            
            Console.Write("\nВіднімання довжин сторон квадрата:\nВведiть першу довжину: ");
            TSquare numberOfFirstDiff = new TSquare();
            
            numberOfFirstDiff.InputData();
            
            Console.Write("Введiть другу довжину: ");
            TSquare numberOfSecondDiff = new TSquare();
            
            numberOfSecondDiff.InputData();
            
            TSquare diff = numberOfFirstDiff - numberOfSecondDiff;
            Console.WriteLine($"\nРезультат: \n{diff}");
            
            Console.Write("\nМноження довжини сторони квадрата на 1.5:\nВведiть довжину: ");
            TSquare length = new TSquare();
            
            length.InputData();
            
            TSquare multiply = length * 1.5;
            Console.WriteLine($"\nРезультат: \n{multiply}");
            
            Console.WriteLine("\nПорiвняння двох квадратiв(при додаванні та відніманні):");
            bool result = sum.CompareTo(diff);
            Console.WriteLine($"Результат: {result}");
        }
    }
}