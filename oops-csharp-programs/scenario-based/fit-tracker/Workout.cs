internal class Workout
{
    private string workoutName;
    private int duration;

    public string WorkoutName
    {
        get { return workoutName; }
        set { workoutName = value; }
    }

    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    public Workout(string workoutName, int duration)
    {
        this.workoutName = workoutName;
        this.duration = duration;
    }

    public override string ToString()
    {
        return "Workout: " + workoutName + ", Duration: " + duration + " mins";
    }
}
