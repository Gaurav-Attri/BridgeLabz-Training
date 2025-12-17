import java.util.*;
public class PrimalityCheck{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		if(prime(n)){
			System.out.println("Prime");
		}
		else{
			System.out.println("Not Prime");
		}
	}
	public static boolean prime(int n){
		if(n == 1) return false;
		if(n == 2) return true;
		for(int i = 2; i < n; i++){
			if(n%i == 0) return false;
		}
		return true;
	}
}
