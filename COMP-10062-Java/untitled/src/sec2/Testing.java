package sec2;

public class Testing {
    public static void main(String[] args) throws InterruptedException {
        StopWatch time = new StopWatch();

        time.start();
        Thread.sleep(1000);

        long stopWatchTime = time.getElapsedTime();

        System.out.println(stopWatchTime);


    }
}
