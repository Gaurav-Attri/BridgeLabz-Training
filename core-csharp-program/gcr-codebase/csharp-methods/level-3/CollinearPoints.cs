using System;
class CollinearPoints{
    static void Main(string[] args){
        Console.WriteLine("Enter x1 y1:");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter x2 y2:");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter x3 y3:");
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        bool slopeResult = AreCollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool areaResult = AreCollinearByArea(x1, y1, x2, y2, x3, y3);

        if (slopeResult && areaResult){
            Console.WriteLine("Points are collinear by both slope and area methods.");
        }
        else{
            Console.WriteLine("Points are not collinear.");
        }
    }

    static bool AreCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3){
        double leftProduct = (y3 - y2) * (x2 - x1);
        double rightProduct = (y2 - y1) * (x3 - x2);
        return leftProduct == rightProduct;
    }

    static bool AreCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3){
        double value = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
        double area = 0.5 * Math.Abs(value);
        return area == 0;
    }
}

