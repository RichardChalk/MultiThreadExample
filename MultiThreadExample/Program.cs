namespace MultiThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name= "main";

            var thread1 = new Thread(() => CountDown("Timer #1"));
            var thread2 = new Thread(() => CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is done!");
        }

        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(name + " " + i + " seconds");
                Thread.Sleep(1000);
            }
        }
        public static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(name + " " + i + " seconds");
                Thread.Sleep(1000);
            }
        }
    }
}