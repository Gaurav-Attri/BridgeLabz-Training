class TeacherUtility: ITeacher
{
    public static StudentLinkedList _students;
    public static Question[] _questions;
    public static int _questionsCount = 0;

    static TeacherUtility()
    {
        _students = ExamProctorUtility._students;
    }

    public void AddStudent()
    {
        Console.WriteLine("\n==== STUDENT ADDING WINDOW ====\n");
        Console.Write("Enter student roll no: ");
        int studentRollNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();
        Console.Write("Enter student password: ");
        string studentPassword = Console.ReadLine();

        Student student = new Student(studentRollNumber, studentName, studentPassword);

        _students.InsertAtEnd(student);
        Console.WriteLine("\nStudent added successfully.\n");
    }

    public void DisplayAllStudents()
    {
        Console.WriteLine("\n==== STUDENTS DISPLAY MENU ====\n");
        _students.PrintList();
        Console.WriteLine("\n");
    }

    public void AddQuestions()
    {
        Console.WriteLine("\n==== QUESTION ADDING WINDOW ====\n");
        Console.Write("Enter total number of questions: ");
        int questionCount = int.Parse(Console.ReadLine());
        _questionsCount = questionCount;
        _questions = new Question[questionCount];
        Console.WriteLine("\n");

        for(int i = 0; i < questionCount; i++)
        {
            Console.WriteLine($"Questions Number {i+1}:");
            Console.Write("\tEnter Question statement: ");
            string questionStatement = Console.ReadLine();
            Console.Write("\tEnter Question solution: ");
            string questionSolution = Console.ReadLine();

            Question question = new Question(questionStatement, questionSolution);
            _questions[i] = question;
            Console.WriteLine("Question added successfully...\n");

            // Side effect: When the teacher adds questions, then _questionsResponses array for each 
            // student is initalized with _questionsCount size;
            _students.InitializeQuestionsResponsesArray(_questionsCount);
        }
    }

    public void DisplayAllQuestions()
    {
        Console.WriteLine("\n==== QUESTIONS DISPLAY ====\n");
        for(int i = 0; i < _questionsCount; i++)
        {
            Console.WriteLine(_questions[i]);
        }
        Console.WriteLine("\n");
    }

    public void CheckStudentNavigation()
    {
        Console.WriteLine("\n==== STUDENT NAVIGATION CHECK ====\n");
        Console.Write("Enter student id: ");
        int studentId = int.Parse(Console.ReadLine());
        Student student = _students.FindStudentById(studentId);

        if(student == null)
        {
            Console.WriteLine("\nStudent not found...\n");
            return;
        }
        Console.WriteLine("\nHere is the navigation history across all attempts: ");

        NavigationStack studentStack = student.GetNavigationStack();
        NavigationStack stackCopy = new NavigationStack();

        while (!studentStack.IsEmpty())
        {
            int questionNumber = studentStack.Pop();
            stackCopy.Push(questionNumber);
        }

        while (!stackCopy.IsEmpty())
        {
            int questionNumber = stackCopy.Pop();
            Console.Write(questionNumber + " ");
            studentStack.Push(questionNumber);
        }

        Console.WriteLine("\n");
    }
    
    public void CheckAllStudentsScore()
    {
        Console.WriteLine("\n==== All Students Scores ====\n");
        _students.PrintScores();
        Console.WriteLine("\n");
    }
}