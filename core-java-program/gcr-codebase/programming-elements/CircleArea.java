import java.util.Scanner;
public class CircleArea{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter the radius of the circle: ");
		float rad = sc.nextFloat();
		float area = 3.14f*rad*rad;
		System.out.println("Area of the circle is: " + area);
	}
}
