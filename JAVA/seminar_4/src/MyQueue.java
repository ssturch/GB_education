import java.util.LinkedList;

public class MyQueue {

    public static void add(LinkedList<String> ll, String str) {
        ll.add(ll.size(), str);
    }

    public static String top(LinkedList<String> ll) {
        return ll.getFirst();
    }

    public static String remove(LinkedList<String> ll) {
        String res = ll.getFirst();
        ll.remove(0);
        return res;
    }
}
