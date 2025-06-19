using System;

namespace SingletonPatternExample
{
    public sealed class Logger
    {
        private static Logger instance = null;
        private static readonly object lockObj = new object();

        private Logger()
        {
            Console.WriteLine("Logger created by Ashutosh Dash from KIIT DU");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("Started application.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Accessed user module.");

            Console.WriteLine("Yes, both instances are same.");
        }
    }
}
