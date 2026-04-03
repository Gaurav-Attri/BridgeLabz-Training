using System;
class FactorsFinder{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());

		// Creating an array of size 10 initilially
		int[] factors = new int[10];
		int ind = 0;
		for(int i = 1; i <= num; i++){
			if(num%i == 0){
				if(ind == factors.Length){
					// Creating a temporary array of double size
                                        int[] temp = new int[factors.Length*2];
                                        // Copying the elements of the factors array in it
                                        for(int j = 0; j < factors.Length; j++){
                                                temp[j] = factors[j];
                                        }
                                        // assigning temp to factors
                                        factors = temp;
					factors[ind] = i;
				}
				else{
					factors[ind] = i;
				}
				ind++;
			}
		}


		Console.WriteLine("Factors of " + num + " are:");
		for(int i = 0; i < factors.Length; i++){
			Console.WriteLine(factors[i]);
			if(factors[i] == num) break;
		}
	}
}
