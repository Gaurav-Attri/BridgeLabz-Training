class Student
{
    private string _studentName;
    private int _studentScore;
    private string _studentDistrictName;

    public Student(string studentName, int studentScore, string studentDistrictName)
    {
        _studentName = studentName;
        _studentScore = studentScore;
        _studentDistrictName = studentDistrictName;
    }

    public int GetStudentScore()
    {
        return _studentScore;
    }

    public override string ToString()
    {
        return $"\n{_studentName}\t|\t{_studentScore}\t|\t{_studentDistrictName}\n";
    }
}