package com.maddevskilz;

public class Main {
    public static int variadicExample(int... list){
        int total = 0;
        for(int i = 0; i < list.length; i++){
            total += list[i];
        }
        System.out.println("The total is " + total);
        return total;
    }

    public static void helloWorld(String name){
        System.out.println("Hello world!  But more specifically, hello " + name);
    }

    public static void main(String[] args) {

        // You can send a comma-separated list of arguments of the
        // specified type.  There is no limit to the number other than practical
        // considerations for memory and processor speed.

        variadicExample(1, 2, 3, 4);
        variadicExample(100, 213, 432, 123, 234, 123, 643, 785, 934);

        // You can send a comma-separated list of arguments of the
        // specified type.  There is no limit to the number other than practical
        // considerations for memory and processor speed.
        variadicExample();
    }
}
