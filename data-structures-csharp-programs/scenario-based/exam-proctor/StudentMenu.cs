class StudentMenu
{
    private IStudent studentUtility;
    public void ShowStudentMenu(Student student)
    {
        studentUtility = new StudentUtility();
        int choice;
        do
        {
            Console.WriteLine("\n==== STUDENT MENU ====\n");
            Console.WriteLine("1. Enter responses for answers.");
            Console.WriteLine("2. Check your score.");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    studentUtility.AcceptStudentResponses(student);
                    break;
                case 2:
                    studentUtility.CheckYourScore(student);
                    break;
            }

        } while (choice != 0);
    }
}