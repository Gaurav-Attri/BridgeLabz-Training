internal class Menu
{
    public void ShowMenu()
    {
        Console.Write("Enter User Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        UserProfile user = new UserProfile(name, age);
        FitTrackUtility utility = new FitTrackUtility();

        int choice;

        do
        {
            Console.WriteLine("\n--- FitTrack Menu ---");
            Console.WriteLine("1. Add Cardio Workout");
            Console.WriteLine("2. Add Strength Workout");
            Console.WriteLine("3. View Workouts");
            Console.WriteLine("4. View User Profile");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Workout Name: ");
                    string cName = Console.ReadLine();
                    Console.Write("Duration: ");
                    int cDur = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Calories Burned: ");
                    int cal = Convert.ToInt32(Console.ReadLine());

                    utility.AddWorkout(user, new CardioWorkout(cName, cDur, cal));
                    break;

                case 2:
                    Console.Write("Workout Name: ");
                    string sName = Console.ReadLine();
                    Console.Write("Duration: ");
                    int sDur = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sets: ");
                    int sets = Convert.ToInt32(Console.ReadLine());

                    utility.AddWorkout(user, new StrengthWorkout(sName, sDur, sets));
                    break;

                case 3:
                    utility.DisplayWorkouts(user);
                    break;

                case 4:
                    Console.WriteLine(user);
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}
