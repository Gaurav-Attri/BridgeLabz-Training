import java.util.Scanner;
public class CylinderVol{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter Radius: ");
		double radius = sc.nextDouble();
		System.out.print("Enter Height: ");
		double height = sc.nextDouble();
		double volume = 3.14*radius*radius*height;
		System.out.println("Volume is: " + volume);
	}
}
