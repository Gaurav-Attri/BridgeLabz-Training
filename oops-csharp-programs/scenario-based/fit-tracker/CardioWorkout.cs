internal class CardioWorkout : Workout
{
    private int caloriesBurned;

    public int CaloriesBurned
    {
        get { return caloriesBurned; }
        set { caloriesBurned = value; }
    }

    public CardioWorkout(string name, int duration, int calories)
        : base(name, duration)
    {
        caloriesBurned = calories;
    }

    public override string ToString()
    {
        return base.ToString() + ", Calories Burned: " + caloriesBurned;
    }
}
