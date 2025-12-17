import java.util.*;
public class StringCharFreq{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		String s = sc.next();
		Map<Character, Integer> map = new HashMap<>();
		for(char c : s.toCharArray()){
			map.put(c, map.getOrDefault(c, 0)+1);
		}
		for(Map.Entry<Character, Integer> entry : map.entrySet()){
			System.out.println(entry.getKey() + " " + entry.getValue());
		}
	}
}
