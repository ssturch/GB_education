import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        Phonebook Test = new Phonebook();
        System.out.println("KeySet: " + Test.phonebook.keySet());
        System.out.println("Tel by Nikolay: " + Arrays.stream(Test.phonebook.get("Nikolay")).toList());

        Test.phonebook.put("Sergey", new String[]{"+7-999-659-00-21"});
        System.out.println("NewKeySet: " + Test.phonebook.keySet());
        System.out.println("Tel by Sergey: " + Arrays.stream(Test.phonebook.get("Sergey")).toList());
        //System.out.println("Answer task N2: " + Exercises.Ex2(digits));
    }
}
