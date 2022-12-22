import java.util.LinkedList;

public class MyStack {

    static void push(LinkedList<String> ll, String str) {
        ll.add(ll.size(), str);
    }

    static String peek(LinkedList<String> ll) {
        return ll.getLast();
    }

     static String pop(LinkedList<String> ll) {
        String res = ll.getLast();
        ll.remove(ll.size()-1);
        return res;
    }
}
