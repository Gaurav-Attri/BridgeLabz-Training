using System;
class DigitsInArray{
        static void Main(string[] args){
                Console.WriteLine("Please enter a number: ");
                long num = long.Parse(Console.ReadLine());
                int[] digits = new int[10];
                int index = 0;

                while(num != 0){
                        int digit = Convert.ToInt32(num%10);
                        // If the digits array is full
			if(index == digits.Length){
				// Creating a temp array of size digits.Length + 10
				int[] temp = new int[digits.Length + 10];
				// Copying digits elements in temp
				for(int i = 0; i < index; i++){
					temp[i] = digits[i];
				}
				// Assigning the new array (temp) to digits to increase digits capacity
				digits = temp;
			}
			digits[index++] = digit;
			num = num/10;
                }

                // finding the largest and second largest digit in the digits array
                int largest = int.MinValue;
                int secondLargest = int.MinValue;

                for(int i = 0; i < index; i++){
                        if(digits[i] > largest){
                                secondLargest = largest;
                                largest = digits[i];
                        }
                        else if(digits[i] > secondLargest && digits[i] != largest){
                                secondLargest = digits[i];
                        }
                }

                Console.WriteLine("Largest digit is: " + largest);
                Console.WriteLine("Second Largest digit is: " + secondLargest);
        }
}
