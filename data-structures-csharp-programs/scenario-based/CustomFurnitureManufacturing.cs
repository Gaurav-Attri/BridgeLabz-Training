using System;

class CustomFurnitureManufacturing{
    private static int RodLength = 12;
    private static int[] prices;

    private static int optimalPrice;
    private static string optimalSequence;

    private static int wasteAwarePrice;
    private static string wasteAwareSequence;
    private static int bestWaste;

    static CustomFurnitureManufacturing(){
        prices = new int[] { 0, 2, 5, 7, 8, 10, 13, 17, 18, 20, 24, 25, 30 };
    }

    static void Main(string[] args){
        CustomFurnitureManufacturing app = new CustomFurnitureManufacturing();
        app.StartApplication();
    }

    void StartApplication(){
        int choice;
        do{
            Console.WriteLine("\n==== CUSTOM FURNITURE MANUFACTURING ====");
            Console.WriteLine("1. Scenario A: Maximize earnings (no waste concern)");
            Console.WriteLine("2. Scenario B: Maximize earnings with fixed waste constraint");
            Console.WriteLine("3. Scenario C: Maximize earnings + minimize waste");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    ScenarioA();
                    break;
                case 2:
                    ScenarioB();
                    break;
                case 3:
                    ScenarioC();
                    break;
            }

        } while (choice != 0);
    }

    void ScenarioA(){
        optimalPrice = 0;
        optimalSequence = "";

        FindOptimalRecursively(RodLength, 0, "");

        Console.WriteLine("\n[Scenario A] Best Cut (Max Revenue)");
        Console.WriteLine("Cut Sequence: " + optimalSequence);
        Console.WriteLine("Total Price: " + optimalPrice);
    }

    void FindOptimalRecursively(int remaining, int currentPrice, string sequence){
        if (remaining == 0){
            if (currentPrice > optimalPrice){
                optimalPrice = currentPrice;
                optimalSequence = sequence;
            }
            return;
        }

        for (int cut = 1; cut <= remaining; cut++){
            FindOptimalRecursively(remaining - cut, currentPrice + prices[cut], sequence + cut);
        }
    }

    void ScenarioB(){
        Console.Write("\nEnter max allowed waste (ft): ");
        int maxWaste = int.Parse(Console.ReadLine());

        wasteAwarePrice = 0;
        wasteAwareSequence = "";
        bestWaste = int.MaxValue;

        FindWithWasteConstraint(0, 0, "", maxWaste);

        Console.WriteLine("\n[Scenario B] Best Cut (With Waste Constraint)");
        Console.WriteLine("Cut Sequence: " + wasteAwareSequence);
        Console.WriteLine("Total Price: " + wasteAwarePrice);
        Console.WriteLine("Waste: " + bestWaste + " ft");
    }

    void FindWithWasteConstraint(int usedLength, int price, string sequence, int maxWaste){
        int waste = RodLength - usedLength;

        if (waste < 0) return;

        if (waste <= maxWaste){
            if (price > wasteAwarePrice){
                wasteAwarePrice = price;
                wasteAwareSequence = sequence;
                bestWaste = waste;
            }
        }

        for (int cut = 1; cut <= RodLength; cut++){
            FindWithWasteConstraint(usedLength + cut, price + prices[cut], sequence + cut, maxWaste);
        }
    }

    void ScenarioC(){
        wasteAwarePrice = 0;
        wasteAwareSequence = "";
        bestWaste = int.MaxValue;

        FindRevenuePlusWaste(0, 0, "");

        Console.WriteLine("\n[Scenario C] Best Cut (Max Revenue + Min Waste)");
        Console.WriteLine("Cut Sequence: " + wasteAwareSequence);
        Console.WriteLine("Total Price: " + wasteAwarePrice);
        Console.WriteLine("Waste: " + bestWaste + " ft");
    }

    void FindRevenuePlusWaste(int usedLength, int price, string sequence){
        int waste = RodLength - usedLength;

        if (waste < 0) return;

        if (price > wasteAwarePrice || (price == wasteAwarePrice && waste < bestWaste)){
            wasteAwarePrice = price;
            wasteAwareSequence = sequence;
            bestWaste = waste;
        }

        for (int cut = 1; cut <= RodLength; cut++){
            FindRevenuePlusWaste(usedLength + cut, price + prices[cut], sequence + cut);
        }
    }
}

