public class Plain {
    int speed = 100;
    boolean isMoving = true;
    String color = "blue";
    int passengers = 122;

    public void accelerate(int amount) {
        speed += amount;
        isMoving = speed != 0;
    }

    public void printSpeed() {
        System.out.print("The speed of plane is " + speed + "km/h");
    }

    public void modifyPassengers(int amount) {
        passengers += amount;
    }

    public void printNumberPassengers() {
        System.out.println("There are " + passengers + " on the plane");
    }

    public void printInTheAir() {
        if (isMoving) {
            System.out.println("The plane is in the air");
        } else {
            System.out.println("The plane has landed");
        }
    }
}
