﻿using System.Formats.Asn1;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;
            var addition = a + b;
            var subtraction = a - b;
            var multiplication = a * b;
            Console.WriteLine($"{a}+{b} is {addition}. {a}-{b} is {subtraction}. {a}x{b} is {multiplication}.");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.");


        }
    }
}
