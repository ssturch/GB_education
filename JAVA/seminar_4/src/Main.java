import java.util.ArrayList;
import java.util.Collection;
import java.util.LinkedList;


public class Main {
    public static void main(String[] args) {
        LinkedList<String> data = new LinkedList<>();
        Collection<String> dataColl = new ArrayList<String>();
        dataColl.add("My");
        dataColl.add("Cat");
        dataColl.add("Is");
        dataColl.add("Crazy");
        dataColl.add("Dude");
        data.addAll(dataColl);

        System.out.println("Answer task N1: " + Exercises.Ex1(data));
        System.out.println("Answer task N2: ");
        Exercises.Ex2(data);

        System.out.println("Answer task N3: ");
        Exercises.Ex3(data);
    }
}
