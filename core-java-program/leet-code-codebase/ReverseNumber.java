import java.util.*;
public class ReverseNumber{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int num = sc.nextInt();
		System.out.println("Reversed " + reverse(num));
	}
	public static int reverse(int num){
		int rev = 0;
		while(num != 0){
			int digit = num%10;
			rev = rev*10 + digit;
			num = num/10;
		}
		return rev;
	}
}
