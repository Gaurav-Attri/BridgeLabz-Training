class ExamProctorUtility: IExamProctor
{
    public static StudentLinkedList _students;

    static ExamProctorUtility()
    {
        _students = new StudentLinkedList();
    }

    public bool TeacherLogin()
    {
        Console.WriteLine("\n==== TEACHER AUTHENTICATION WINDOW ====\n");
        Console.Write("Enter teacher id: ");
        string teacherId = Console.ReadLine();
        Console.Write("Enter teacher password: ");
        string teacherPassword = Console.ReadLine();
        Console.WriteLine("\n");

        return Teacher.AuthenticateTeacher(teacherId, teacherPassword);
    }

    public Student StudentLogin()
    {
        Console.WriteLine("\n==== STUDENT AUTHENTICATION WINDOW ====\n");
        Console.Write("Enter student id: ");
        int studentId = int.Parse(Console.ReadLine());
        Console.Write("Enter student password: ");
        string studentPassword = Console.ReadLine();
        Console.WriteLine("\n");

        Student student = _students.FindStudentById(studentId);
        if(student == null)
        {
            Console.WriteLine("\nStudent doesn't exist");
            return null;
        }

        if (student.AuthenticateStudent(studentId, studentPassword)) return student;
        return null;
    }
}