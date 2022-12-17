import java.util.ArrayList;
import java.util.Collections;

public class Main {
    public static void main(String[] args) {
        ArrayList<Integer> digits = new ArrayList<Integer>();
        Collections.addAll(digits, 40,1,2,65,76,32,89,23,4,8,5,2);
        System.out.println("Answer task N1: " + Exercises.Ex1(digits));
        System.out.println("Answer task N2: " + Exercises.Ex2(digits));
    }
}
