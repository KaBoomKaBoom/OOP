public class Main {
    public static void main(String[] args) {
       Plain plain=new Plain();
       plain.printSpeed();
       plain.accelerate(300);
       plain.printSpeed();
       plain.printNumberPassengers();
       plain.modifyPassengers(111);
       plain.printNumberPassengers();
       plain.printInTheAir();
       System.out.println("The plane is: "+plain.color);
    }
}