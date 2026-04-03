using System;
class PalindromeChecker{
    static void Main(string[] args){
        string input = GetInput();

        // Checking whether the string is a palindrome
        bool isPalindrome = CheckPalindrome(input);

        // Displaying result
        DisplayResult(input, isPalindrome);

    }

    // Method to get input string from user
    static string GetInput(){
        Console.Write("Enter a word or phrase: ");
        string input = Console.ReadLine();
        return input;
    }

    // Method to check palindrome
    static bool CheckPalindrome(string str){
        // Remove spaces and convert to lowercase for accurate checking
        str = str.Replace(" ", "").ToLower();

        int left = 0;
        int right = str.Length - 1;

        while (left < right){
            if (str[left] != str[right]){
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    // Method to display the result
    static void DisplayResult(string str, bool isPalindrome){
        if (isPalindrome){
            Console.WriteLine("\n\"" + str + "\" is a Palindrome.");
        }
        else{
            Console.WriteLine("\n\"" + str + "\" is NOT a Palindrome.");
        }
    }
}

