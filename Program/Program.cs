﻿using System;

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

            Console.Write("\nВведiть першу довжину сторони квадрата: ");
            TSquare squareOfFirst = new TSquare();
            
            squareOfFirst.InputData();
            
            Console.Write("Введiть другу довжину сторони квадрата: ");
            TSquare squareOfSecond = new TSquare();
            
            squareOfFirst.InputData();

            Console.WriteLine("\nПорiвняння двох квадратiв на рiвнiсть їхнiх розмiрiв:");
            bool result = squareOfFirst.CompareTo(squareOfSecond);
            
            Console.WriteLine($"Результат: {result}");
            
            Console.WriteLine("\nСума двох квадратів:");
            TSquare sum = squareOfFirst + squareOfSecond;
            
            sum.DisplayData();
            
            Console.WriteLine("\nРізниця двох квадратів:");
            TSquare diff = squareOfFirst - squareOfSecond;
            
            diff.DisplayData();
            
            Console.WriteLine("\nМноження сторін на 2:");
            TSquare multiplied = squareOfFirst * 2.0;
            
            multiplied.DisplayData();
        }
    }
}