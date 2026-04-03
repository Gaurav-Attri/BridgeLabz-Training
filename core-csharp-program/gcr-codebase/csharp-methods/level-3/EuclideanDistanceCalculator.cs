using System;
class EuclideanDistanceCalculator{
    static void Main(string[] args){
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double distance = FindDistance(x1, y1, x2, y2);
        Console.WriteLine("Distance between points = " + distance);

        double[] result = FindLineEquation(x1, y1, x2, y2);
        Console.WriteLine("Slope (m) = " + (result[0]));
        Console.WriteLine("Y-intercept (b) = " + (result[1]));
        Console.WriteLine("Equation of line: y = " + (result[0]) + "x + " + (result[1]));
    }

    static double FindDistance(double x1, double y1, double x2, double y2){
        return Math.Sqrt(
            Math.Pow(x2 - x1, 2) +
            Math.Pow(y2 - y1, 2)
        );
    }

    static double[] FindLineEquation(double x1, double y1, double x2, double y2){
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - (m * x1);

        return new double[] { m, b };
    }
}

