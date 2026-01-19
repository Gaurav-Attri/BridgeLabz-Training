class TeacherMenu
{
    private ITeacher teacherUtility;
    public void ShowTeacherMenu()
    {
        teacherUtility = new TeacherUtility();
        int choice;
        do
        {
            Console.WriteLine("\n==== TEACHER MENU ====\n");
            Console.WriteLine("1. Add a Student.");
            Console.WriteLine("2. Display all students");
            Console.WriteLine("3. Add questions");
            Console.WriteLine("4. Display all questions");
            Console.WriteLine("5. Check student navigation.");
            Console.WriteLine("6. Check all students' scores.");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    teacherUtility.AddStudent();
                    break;
                case 2:
                    teacherUtility.DisplayAllStudents();
                    break;
                case 3:
                    teacherUtility.AddQuestions();
                    break;
                case 4:
                    teacherUtility.DisplayAllQuestions();
                    break;
                case 5:
                    teacherUtility.CheckStudentNavigation();
                    break;
                case 6:
                    teacherUtility.CheckAllStudentsScore();
                    break;
            }

        } while (choice != 0);
    }
}