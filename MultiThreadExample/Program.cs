namespace MultiThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name= "main";

            var thread1 = new Thread(CountDown);
            var thread2 = new Thread(CountUp);

            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is done!");
        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
        }
    }
}