using System;
class UnitConvertorV3{
	static void Main(string[] args){
		Console.WriteLine("32 Farhenheit is equal to " + FarhenheitToCelsius(32) + " celsius");
		Console.WriteLine("32 Celsius is equal to " + CelsiusToFarhenheit(32) + " farhenheit");
		Console.WriteLine("180 pound is equal to " + PoundsToKg(180) + " kg");
		Console.WriteLine("80 kg is equal to " + KgToPounds(80) + " pounds");
		Console.WriteLine("100 gallons is equal to " + GallonsToLiters(100) + " liters");
		Console.WriteLine("100 liters is equal to " + LitersToGallons(100) + " gallons");
	}

	static double FarhenheitToCelsius(double farhenheit){
		return (farhenheit-32) * 5.0/9.0;
	}

	static double CelsiusToFarhenheit(double celsius){
		return (celsius*(9.0/5.0)) + 32;
	}

	static double PoundsToKg(double pounds){
		return pounds*0.453592;
	}

	static double KgToPounds(double kg){
		return kg*2.20462;
	}

	static double GallonsToLiters(double gallons){
		return gallons*3.78541;
	}

	static double LitersToGallons(double liters){
		return liters*0.264172;
	}
}
