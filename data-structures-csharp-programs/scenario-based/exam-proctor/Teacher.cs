class Teacher
{
    private static string _teacherId;
    private static string _teacherPassword;

    static Teacher()
    {
        _teacherId = "teacher";
        _teacherPassword = "teacher";
    }

    public static bool AuthenticateTeacher(string teacherId, string teacherPassword)
    {
        if (teacherId.Equals(_teacherId) && teacherPassword.Equals(_teacherPassword))
        {
            Console.WriteLine("\nAuthentication Successfully...\n");
            return true;
        }
        Console.WriteLine("\nAuthentication Failed...\n");
        return false;
    }
}