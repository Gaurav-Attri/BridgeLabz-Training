using System.Net.Http.Headers;

class AdharNumberUtility: IAdharNumberSystem
{
    private static string[] _adharNumbers;
    private static int _capacity;
    private static int _index;

    static AdharNumberUtility()
    {
        _capacity = 20;
        _adharNumbers = new string[_capacity];
        _index = 0;
    }

    public void DisplayAllAdharNumbers()
    {
        Console.WriteLine("\n==== ALL ADHAR NUMBERS ====\n");
        if(_index == 0)
        {
            Console.WriteLine("\nZero adhar numbers available.\n");
            return;
        }

        for(int i = 0; i < _index; i++)
        {
            Console.WriteLine($"{i+1}. {_adharNumbers[i]}");
        }
        Console.WriteLine("\n");
    }

    public void AddAdharNumber()
    {
        Console.WriteLine("\n==== ADHAR NUMBER ADDING WINDOW ====\n");
        if (_index >= _capacity)
        {
            Console.WriteLine("\nAdhar array is full.\n");
            return;
        }

        Console.Write("Enter 12-digit adhar number: ");
        string adharNumber = Console.ReadLine();
        if (IsInvalidAdharNumber(adharNumber))
        {
            Console.WriteLine("\nInvalid Adhar Number.\n");
            return;
        }
        _adharNumbers[_index++] = adharNumber;
        RadixSort();
        Console.WriteLine("\nAdhar number added successfully.\n");
    }

    public void SearchAdharNumber()
    {
        Console.WriteLine("\n==== ADHAR NUMBER SEARCH WINDOW ====\n");
        Console.Write("Enter adhar number to search: ");
        string adharNumber = Console.ReadLine();

        int low = 0, high = _index - 1;
        while(low <= high)
        {
            int mid = (low + high) / 2;
            if (_adharNumbers[mid].Equals(adharNumber))
            {
                Console.WriteLine($"\nAdhar Number Found at searial number {mid + 1}\n");
                return;
            }
            else if (String.Compare(_adharNumbers[mid], adharNumber) < 0) low = mid + 1;
            else high = mid - 1;
        }
        Console.WriteLine("\nAdhar Number not found.\n");
    }

    private void RadixSort()
    {
        for(int i = 11; i >= 0; i--)
        {
            CountingSort(i);
        }
    }

    private void CountingSort(int ind)
    {
        string[] output = new string[_index];
        int[] count = new int[10];

        for(int i = 0; i < _index; i++)
        {
            int digit = _adharNumbers[i][ind] - '0';
            count[digit]++;
        }

        for(int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        for(int i = _index-1; i >= 0; i--)
        {
            int digit = _adharNumbers[i][ind] - '0';
            output[count[digit] - 1] = _adharNumbers[i];
            count[digit]--;
        }

        for(int i = 0; i < _index; i++)
        {
            _adharNumbers[i] = output[i];
        }
    }

    private bool IsInvalidAdharNumber(string adharNumber)
    {
        if (adharNumber.Length != 12) return true;
        foreach(char digit in adharNumber)
        {
            if (!Char.IsDigit(digit)) return true;
        }
        return false;
    }
}