internal class UserProfile
{
    private string userName;
    private int age;
    private Workout[] workouts;
    private int index;

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Workout[] Workouts
    {
        get { return workouts; }
    }

    public int Index
    {
        get { return index; }
        set { index = value; }
    }

    public UserProfile(string userName, int age)
    {
        this.userName = userName;
        this.age = age;
        workouts = new Workout[5];
        index = 0;
    }

    public override string ToString()
    {
        return "User Name: " + userName + ", Age: " + age;
    }
}
