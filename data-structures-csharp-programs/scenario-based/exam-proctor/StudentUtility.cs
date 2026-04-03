using System.Security.Cryptography.X509Certificates;

class StudentUtility: IStudent
{
    public static Question[] _questions;
    public static int _questionsCount;
    public static StudentLinkedList _students;

    static StudentUtility()
    {
        _questions = TeacherUtility._questions;
        _questionsCount = TeacherUtility._questionsCount;
        _students = ExamProctorUtility._students;
    }

    public void AcceptStudentResponses(Student student)
    {
        Console.WriteLine("\n==== STUDENT RESPONSES WINDOW ====\n");
        string[] studentResponsesArray = student.GetQuestionsResponsesArray();
        int userResponse;
        while (true) 
        { 
            Console.Write($"Enter the question number between 1 and {_questionsCount} (press 0 to quit): ");
            userResponse = int.Parse(Console.ReadLine());
            if (userResponse == 0) break;

            if (userResponse < 1 || userResponse > _questionsCount)
            {
                Console.WriteLine("\nPlease enter a valid question number");
                continue;
            }
            Console.WriteLine($"Here is questions statement: {_questions[userResponse-1].GetQuestionStatement()}");
            Console.Write("Enter your answer: ");
            string answer = Console.ReadLine();
            studentResponsesArray[userResponse - 1] = answer;
            student.GetNavigationStack().Push(userResponse);
            Console.WriteLine("\nAnswer read successfully...\n");
        }
    }

    public void CheckYourScore(Student student)
    {
        string[] responses = student.GetQuestionsResponsesArray();
        Console.WriteLine("\n==== SCORE ====\n");
        int score = 0;

        for(int i = 0; i < _questionsCount; i++)
        {
            if (responses[i] != null && _questions[i].GetQuestionSolution().Equals(responses[i])) score++; 
        }

        student.SetScore(score);
        Console.WriteLine($"\nYour score is: {score}\n");
    }
}