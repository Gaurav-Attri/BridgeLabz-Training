internal class FitTrackUtility : ITrackable
{
    public void AddWorkout(UserProfile user, Workout workout)
    {
        if (user.Index < user.Workouts.Length)
        {
            user.Workouts[user.Index++] = workout;
            Console.WriteLine("Workout added for " + user.UserName);
        }
        else
        {
            Console.WriteLine("Workout limit reached.");
        }
    }

    public void DisplayWorkouts(UserProfile user)
    {
        if (user.Index == 0)
        {
            Console.WriteLine("No workouts found.");
            return;
        }

        Console.WriteLine("\nWorkouts for " + user.UserName + ":");
        for (int i = 0; i < user.Index; i++)
        {
            Console.WriteLine(user.Workouts[i]);
        }
    }
}
