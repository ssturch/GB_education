import java.io.*;
public class Exercises {
    //Напишите метод, который принимает на вход строку (String) и определяет является ли строка палиндромом
    // (возвращает boolean значение).
    static boolean Ex1(String input) {
        String temp = input.replace(" ", "");
        temp = temp.toLowerCase();
        char[] tempArr = temp.toCharArray();
        for (var i = 0; i < tempArr.length-1 / 2; i++) {
            if (tempArr[i] == tempArr[tempArr.length - i -1]) {
                continue;
            } else return false;
        }
        return true;
    }
    //Напишите метод, который составит строку, состоящую из 100 повторений слова TEST и метод,
    // который запишет эту строку в простой текстовый файл, обработайте исключения.
    static boolean Ex2(String input) {
        try(FileWriter wrt = new FileWriter("test.txt", true))
        {
            int i = 1;
            do {
                wrt.append("TEST");
                i++;
            }
            while (i <= 100);
            wrt.flush();
        }
        catch(IOException expt){
            System.out.println(expt.getMessage());
            return false;
        }
        return true;
    }
}
    /*
    //Написать метод, которому в качестве параметра передается целое число,
    //метод должен напечатать в консоль, положительное ли число передали или отрицательное.
    //Замечание: ноль считаем положительным числом.
    static String Ex2(int a) {
        if (a >= 0) return "positive";
        else return "negative";
    }
    //Написать метод, которому в качестве параметра передается целое число.
    //Метод должен вернуть true, если число отрицательное, и вернуть false если положительное.
    static boolean Ex3(int a) {
        if (a > 0) return true;
        else return false;
    }
    //Написать метод, которому в качестве аргументов передается строка и число,
    //метод должен отпечатать в консоль указанную строку, указанное количество раз;
    static String Ex4(String str, int count) {
        String res = "\n";
        if (count <= 0) return null;
        do {
            if (count != 1) res = res + str + "\n";
            else res = res + str;
            count--;
        }
        while (count > 0);
        return res;
    }
    //* Написать метод, который определяет, является ли год високосным,
    //и возвращает boolean (високосный - true, не високосный - false).
    // Каждый 4-й год является високосным, кроме каждого 100-го, при этом каждый 400-й – високосный. .
    static boolean Ex5(int year) {
        return (year % 4 == 0 & year % 100 != 0 | year % 400 == 0);
    }
    //Задать целочисленный массив, состоящий из элементов 0 и 1.
    //Например: [ 1, 1, 0, 0, 1, 0, 1, 1, 0, 0 ]. С помощью цикла и условия заменить 0 на 1, 1 на 0;
    static int[] Ex6(int[] arr) {
        for (var i = 0; i < arr.length; i++) {
            switch (arr[i]) {
                case 0:
                    arr[i] = 1;
                    break;
                case 1:
                    arr[i] = 0;
                    break;
            }
        }
        return arr;
    }
    //Задать пустой целочисленный массив длиной 100. С помощью цикла заполнить его значениями 1 2 3 4 5 6 7 8 … 100;
    static int[] Ex7(int[] arr) {
        for (var i = 0; i < arr.length; i++) {
            arr[i] = i+1;
            }
        return arr;
    }
    //Задать массив [ 1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1 ] пройти по нему циклом, и числа меньшие 6 умножить на 2;
    static int[] Ex8(int[] arr) {
        for (var i = 0; i < arr.length; i++) {
            if (arr[i] < 6) arr[i] = arr[i] * 2;
        }
        return arr;
    }
    //Создать квадратный двумерный целочисленный массив (количество строк и столбцов одинаковое),
    //и с помощью цикла(-ов) заполнить его диагональные элементы единицами.
    static int[][] Ex9(int[][] arr) {
        for (var i = 0; i < arr[0].length; i++) {
            for (var j = 0; j < arr[0].length; j++){
                if (j == i || j == arr[0].length - 1 - i)
                    arr[i][j] = 1;
            }
        }

        for (var i = 0; i < arr[0].length; i++){
            System.out.println(Arrays.toString(arr[i]));
        }
        return arr;
    }
    //Написать метод, принимающий на вход два аргумента: len и initialValue,
    //возвращающий одномерный массив типа int длиной len, каждая ячейка которого равна initialValue;
    static int[] Ex10(int len, int initialValue) {
        var arr = new int [len];
        for (var i = 0; i < arr.length; i++){
            arr[i] = initialValue;
        }
        return arr;
    }
    //* Задать одномерный массив и найти в нем минимальный и максимальный элементы ;
    static String Ex11(int[] arr) {
        var max = Arrays.stream(arr).max();
        var min = Arrays.stream(arr).min();
        return ("MAX = " + max.getAsInt() + " | " + "MIN = " + min.getAsInt());
    }
}
     */