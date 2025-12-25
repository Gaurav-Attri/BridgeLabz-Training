using System;
class FactorsFinder{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int[] factors = Factors(num);
		int factorsSum = FactorsSum(factors);
		int factorsProduct = FactorsProduct(factors);
		int factorsSqureSum = FactorsSqureSum(factors);
		Console.WriteLine("Following are the factors of the number " + num);
		for(int i = 0; i < factors.Length; i++) Console.Write(factors[i] + " ");
		Console.WriteLine();
		Console.WriteLine("Factor's sum is " + factorsSum);
		Console.WriteLine("Factor's product is " + factorsProduct);
		Console.WriteLine("Factor's squre sum is " + factorsSqureSum);
	}

	static int[] Factors(int num){
		// Counting the number of factors
		int factorsCount = 0;
		for(int i = 1; i <= num; i++){
			if(num%i == 0) factorsCount++;
		}

		// Finding factors and putting them in the factors array
		int[] factors = new int[factorsCount];
		int index = 0;
		for(int i = 1; i <= num; i++){
			if(num%i == 0) factors[index++] = i;
		}

		return factors;
	}

	static int FactorsSum(int[] factors){
		int sum = 0;
		for(int i = 0; i < factors.Length; i++){
			sum += factors[i];
		}
		return sum;
	}

	static int FactorsProduct(int[] factors){
		int product = 1;
		for(int i = 0; i < factors.Length; i++){
			product *= factors[i];
		}
		return product;
	}

	static int FactorsSqureSum(int[] factors){
		int factorsSqureSum = 0;
		for(int i = 0; i < factors.Length; i++){
			factorsSqureSum += (factors[i]*factors[i]);
		}
		return factorsSqureSum;
	}
}
