import java.util.LinkedList;

public class Exercises {
    // Пусть дан произвольный список целых чисел,
    // удалить из него четные числа (в языке уже есть что-то готовое для этого)
    static LinkedList Ex1(LinkedList<String> input) {
        LinkedList<String> output = new LinkedList<String>();
        for (int i = input.size() - 1; i >= 0; i--) {
            output.add(input.get(i));
        }
        return output;
    }
    //Задан целочисленный список ArrayList.
    // Найти минимальное, максимальное и среднее арифметическое из этого списка.
    static void Ex2(LinkedList<String> input) {
        MyStack.push(input, "Stop Him Please!");
        System.out.print("method MyStack_push: ");System.out.println(input);
        String res = MyStack.peek(input);
        System.out.println("method MyStack_peek: " + res);
        res = MyStack.pop(input);
        System.out.print("method MyStack_pop: " + res); System.out.println(" | Popped LinkedList: " + input);
    }

    static void Ex3(LinkedList<String> input){
        MyQueue.add(input, "His name Dusty");
        System.out.print("method MyQueue_add: ");System.out.println(input);
        String res = MyQueue.top(input);
        System.out.println("method MyQueue_top: " + res);
        res = MyQueue.remove(input);
        System.out.print("method MyQueue_remove: " + res); System.out.println(" | Resulted LinkedList: " + input);

    }
}