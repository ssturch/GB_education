import java.util.*;

public class Phonebook {

    public Map<String, String []> phonebook;

    public Phonebook() {
        phonebook = new HashMap<>();
        phonebook.put("Nikolay", new String[]{"+7-495-343-51-32", "+7-343-25-673-41", "+7-926-543-12-71"});
        phonebook.put("Ivan", new String[]{"+7-999-432-23-11"});
        phonebook.put("Maria", new String[]{"+7-915-487-43-52", "+7-925-775-33-72"});
    }
}