import java.util.Objects;
import java.util.function.Supplier;
import java.util.stream.Stream;

public class Notebook {
    private String type;
    private String company;
    private String model;
    private Double price;
    private CPU cpu_type;
    private RAM ram_type;
    private HardDisc hd_type;

    public Notebook(String type, String company, String model, Double price, CPU cpu_type, RAM ram_type, HardDisc hd_type) {
        this.type = type;
        this.company = company;
        this.model = model;
        this.price = price;
        this.cpu_type = cpu_type;
        this.ram_type = ram_type;
        this.hd_type = hd_type;
    }

    public String getParam(String par) {
        switch (par) {
            case ("type"):
                return type;
            case ("company"):
                return company;
            case ("model"):
                return model;
            case ("price"):
                return Double.toString(price);
            case ("cpu_type"):
                return cpu_type.outputString();
            case ("ram_type"):
                return ram_type.outputString();
            case ("hd_type"):
                return hd_type.outputString();
            default: return "None";
        }
    }

    public String outputString() {
       String out = "Price: " + price + " Type: " + type + " | " + company + " " + model + " | "
                + cpu_type.outputString() + " | "
                + ram_type.outputString() + " | "
                + hd_type.outputString();
        return out;
    }

    public static void FilterByType(Notebook[] list, String value, String filter) {
        Supplier <Stream<Notebook>> NoteStream = () -> Stream.of(list);
        switch (filter) {
            case "type":
                NoteStream.get().filter(ntb-> Objects.equals(ntb.getParam("type"), value)).forEach(ntb->System.out.println(ntb.outputString()));
            case "company":
                NoteStream.get().filter(ntb-> Objects.equals(ntb.getParam("company"), value)).forEach(ntb->System.out.println(ntb.outputString()));
            case "cpu_company":
                NoteStream.get().filter(ntb-> Objects.equals(ntb.cpu_type.getParam("company"), value)).forEach(ntb->System.out.println(ntb.outputString()));
            case "cpu_type":
                NoteStream.get().filter(ntb-> Objects.equals(ntb.cpu_type.getParam("type"), value)).forEach(ntb->System.out.println(ntb.outputString()));
            case "ram_type":
                NoteStream.get().filter(ntb-> Objects.equals(ntb.ram_type.getParam("type"), value)).forEach(ntb->System.out.println(ntb.outputString()));
            case "rom_type":
                NoteStream.get().filter(ntb-> Objects.equals(ntb.hd_type.getParam("type"), value)).forEach(ntb->System.out.println(ntb.outputString()));
        }
    }
}

class CPU {
    private String company;
    private String type;
    private String model;

    public CPU(String company, String type, String model) {
        this.company = company;
        this.type = type;
        this.model = model;
    }

    public String getParam(String par) {
        switch (par) {
            case ("type"):
                return type;
            case ("company"):
                return company;
            case ("model"):
                return model;
            default:
                return "None";
        }
    }
    public String outputString() {
        String out = "CPU: " + company + " " + type + " " + model;
        return out;
    }
}

class RAM {
    private String type;
    private int capacity;

    public RAM(String type, int capacity) {
        this.type = type;
        this.capacity = capacity;
    }

    public String getParam(String par) {
        switch (par) {
            case ("type"):
                return type;
            case ("capacity"):
                return Integer.toString(capacity);
            default:
                return "None";
        }
    }
    public String outputString() {
        String out = "RAM: " + type + " " + capacity + "Gb";
        return out;
    }
}

class HardDisc {
    private String type;
    private int capacity;

    public HardDisc(String type, int capacity) {
        this.type = type;
        this.capacity = capacity;
    }

    public String getParam(String par) {
        switch (par) {
            case ("type"):
                return type;
            case ("capacity"):
                return Integer.toString(capacity);
            default:
                return "None";
        }
    }

    public String outputString() {
        String out = "ROM: " + type + " " + capacity + "Gb";
        return out;
    }
}




