import java.util.Scanner;
public class ThreeNumAvg{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		System.out.println("Enter the numbers: ");
		int[] arr = new int[3];
		for(int i = 0; i < 3; i++){
			arr[i] = sc.nextInt();
		}
		System.out.println("Average: " + ((arr[0]+arr[1]+arr[2])/3.0));
	}
}

