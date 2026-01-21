class EduResultsMenu
{
    private IEduResults eduResultsUtility;
    public void ShowEduResultsMenu()
    {
        eduResultsUtility = new EduResultsUtility();
        int choice;
        do
        {
            Console.WriteLine("\n==== EDU RESULTS MENU ====\n");
            Console.WriteLine("1. Add district data.");
            Console.WriteLine("2. Display district data.");
            Console.WriteLine("3. Get state-wise ranking.");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    eduResultsUtility.AddDistrictData();
                    break;
                case 2:
                    eduResultsUtility.DisplayDistrictData();
                    break;
                case 3:
                    eduResultsUtility.ShowStudentRanking();
                    break;
            }

        } while (choice != 0);
    }
}