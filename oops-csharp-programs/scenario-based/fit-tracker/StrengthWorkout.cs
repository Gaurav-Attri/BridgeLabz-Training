internal class StrengthWorkout : Workout
{
    private int sets;

    public int Sets
    {
        get { return sets; }
        set { sets = value; }
    }

    public StrengthWorkout(string name, int duration, int sets)
        : base(name, duration)
    {
        this.sets = sets;
    }

    public override string ToString()
    {
        return base.ToString() + ", Sets: " + sets;
    }
}
