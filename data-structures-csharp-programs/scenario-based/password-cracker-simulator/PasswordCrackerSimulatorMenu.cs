class PasswordCrackerSimulatorMenu
{
    private IPasswordCrackerSimulator passwordCrackerSimulatorUtility;
    public void ShowPasswordCrackerSimulatorMenu()
    {
        passwordCrackerSimulatorUtility = new PasswordCrackerSimulatorUtility();
        int choice;
        do
        {
            Console.WriteLine("\n==== PASSWORD CRACKER SIMULATOR ====\n");
            Console.WriteLine("1. Enter Password.");
            Console.WriteLine("2. Simulate Password Cracking.");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    passwordCrackerSimulatorUtility.AcceptPassword();
                    break;
                case 2:
                    passwordCrackerSimulatorUtility.SimulatePasswordCracking();
                    break;
            }

        } while (choice != 0);
    }
}