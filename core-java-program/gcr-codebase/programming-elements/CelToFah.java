import java.util.Scanner;
public class CelToFah{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter the temperature in Celsium: ");
		double cel = sc.nextDouble();
		double fah = (cel*9.0/5.0)+32;
		System.out.println("Temperature in Fahrenheit: " + fah);
	}
}
