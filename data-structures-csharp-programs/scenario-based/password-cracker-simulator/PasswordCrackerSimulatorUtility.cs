class PasswordCrackerSimulatorUtility: IPasswordCrackerSimulator
{
    private static string _password;
    private static int _passwordTried;
    private static readonly string _characterSpace;
    private static readonly int _characterSpaceLength;

    static PasswordCrackerSimulatorUtility()
    {
        _characterSpace = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\`~";
        _characterSpaceLength = _characterSpace.Length;
        _passwordTried = 0;
    }

    public void AcceptPassword()
    {
        Console.WriteLine("\n==== ACCEPT PASSWORD ====\n");
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        _password = password;
        Console.WriteLine("\nPassword accepted successfully.\n");
    }

    public void SimulatePasswordCracking()
    {
        _passwordTried = 0;
        Console.WriteLine("\n==== PASSWORD CRACKING SIMULATOR ====\n");
        if(_password == null)
        {
            Console.WriteLine("\nPlease enter a password first.\n");
            return;
        }

        CrackPassword("", _password.Length);
    }

    private bool CrackPassword(string generatedPassword, int passwordLength)
    {
        if(generatedPassword.Length == passwordLength)
        {
            _passwordTried++;
            Console.WriteLine($"\nGenereated Password: {generatedPassword}");
            if (generatedPassword.Equals(_password))
            {
                Console.WriteLine($"Password matches with original password. Passwords tried: {_passwordTried}\n");
                return true;
            }
            else
            {
                Console.WriteLine("Password doesn't match with original password. Searching more...\n");
                return false;
            }
        }

        foreach(char c in _characterSpace)
        {
            if (CrackPassword(generatedPassword + c, passwordLength)) return true;
        }

        return false;
    }
}