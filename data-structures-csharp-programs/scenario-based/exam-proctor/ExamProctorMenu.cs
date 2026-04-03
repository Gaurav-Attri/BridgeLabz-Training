class ExamProctorMenu
{
    private IExamProctor examProctorUtility;
    private TeacherMenu teacherMenu;
    private StudentMenu studentMenu;
    public void ShowExamProctorMenu()
    {
        examProctorUtility = new ExamProctorUtility();
        teacherMenu = new TeacherMenu();
        studentMenu = new StudentMenu();
        int choice;
        do
        {
            Console.WriteLine("\n==== EXAM PROCTOR SYSTEM ====\n");
            Console.WriteLine("1. Teacher Login");
            Console.WriteLine("2. Student Login");
            Console.WriteLine("0. Exit");
            Console.Write("Please enter your choice number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    if (examProctorUtility.TeacherLogin())
                    {
                        teacherMenu.ShowTeacherMenu();
                    }
                    break;
                case 2:
                    Student student = examProctorUtility.StudentLogin();
                    if(student != null)
                    {
                        studentMenu.ShowStudentMenu(student);
                    }
                    break;
            }
        } while (choice != 0);
    }
}