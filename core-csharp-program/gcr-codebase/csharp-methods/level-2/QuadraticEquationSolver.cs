using System;

class QuadraticEquationSolver{
    static void Main(string[] args){
        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0){
            Console.WriteLine("No real roots exist");
        }
        else if (roots.Length == 1){
            Console.WriteLine("Only one root exists: ");
            Console.WriteLine("Root = " + roots[0]);
        }
        else{
            Console.WriteLine("Two roots exist:");
            Console.WriteLine("Root 1 = " + roots[0]);
            Console.WriteLine("Root 2 = " + roots[1]);
        }
    }

    static double[] FindRoots(double a, double b, double c){
        double delta = Math.Pow(b, 2) - (4 * a * c);

        // If delta is negative → no real roots
        if (delta < 0){
            return new double[0]; // Returning an empty array
        }

        // If delta is zero → one root
        if (delta == 0){
            double root = -b / (2 * a);
            return new double[] { root };
        }

        // If delta is positive → two roots
        double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

        return new double[] { root1, root2 };
    }
}
