class Student
{
    private static int _idCounter = 0;
    private int _studentId;
    private string _studentPassword;
    private int _studentRollNo;
    private string _studentName;
    private NavigationStack _questionNavigationStack;
    private string[] _questionsResponses;
    private int _score;

    public Student(int studentRollNo, string studentName, string studentPassword)
    {
        _studentId = ++_idCounter;
        _studentRollNo = studentRollNo;
        _studentName = studentName;
        _questionNavigationStack = new NavigationStack();
        _studentPassword = studentPassword;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public int GetStudentId()
    {
        return _studentId;
    }

    public NavigationStack GetNavigationStack()
    {
        return _questionNavigationStack;
    }

    public void SetQuestionsResponsesArraySize(int size)
    {
        _questionsResponses = new string[size];
    }

    public string[] GetQuestionsResponsesArray()
    {
        return _questionsResponses;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public bool AuthenticateStudent(int studentId, string studentPassword)
    {
        if(studentId == _studentId && studentPassword.Equals(_studentPassword))
        {
            Console.WriteLine("\nAuthentication Successfully...\n");
            return true;
        }
        Console.WriteLine("\nAuthentication Failed...\n");
        return false;
    }

    public override string ToString()
    {
        return $"\nStudent Id: {_studentId}\t|\tStudent Roll No.: {_studentRollNo}\t|\tStudent Name: {_studentName}\n";
    }
}