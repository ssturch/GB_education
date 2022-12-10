import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        System.out.println("Answer task N1: " + Exercises.Ex1(5, 14));
        System.out.println("Answer task N2: " + Exercises.Ex2(314));
        System.out.println("Answer task N3: " + Exercises.Ex3(5));
        System.out.println("Answer task N4: " + Exercises.Ex4("test", 4));
        System.out.println("Answer task N5: " + Exercises.Ex5(2001));
        System.out.println("Answer task N6: " + Arrays.toString(Exercises.Ex6(new int[]{1, 1, 0, 0})));
        System.out.println("Answer task N7: " + Arrays.toString(Exercises.Ex7(new int[100])));
        System.out.println("Answer task N8: " + Arrays.toString(Exercises.Ex8(new int[]{1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1})));
        System.out.println("Answer task N9: ");
        Exercises.Ex9(new int[4][4]);
        System.out.println("Answer task N10: " + Arrays.toString(Exercises.Ex10(5, 1)));
        System.out.println("Answer task N11: " + Exercises.Ex11(new int[]{-1, 5, 32, 0, -22}));
        ;
    }
}