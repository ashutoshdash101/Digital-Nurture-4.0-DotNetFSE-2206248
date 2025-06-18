public class Main {
    public static void main(String[] args) {
        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        logger1.log("Hello, this is Ashutosh Dash from KIIT-DU.");
        logger2.log("I am testing Singleton Pattern in Java.");

        if (logger1 == logger2) {
            System.out.println("Verified: Both instances are the same!.");
        } else {
            System.out.println("Error: Different instances");
        }
    }
}
