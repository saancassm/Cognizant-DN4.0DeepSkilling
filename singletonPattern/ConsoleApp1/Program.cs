using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();

        // Prevent outside instantiation
        private Logger()
        {
            Console.WriteLine("Logger initialized.");
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[Log]: {message}");
        }
    }
}


namespace SingletonPatternExample
{
    class TestLogger
    {
        static void Main(string[] args)
        {
            var logger1 = Logger.GetInstance();
            logger1.Log("Hello World");

            var logger2 = Logger.GetInstance();
            logger2.Log("Hello Cognizant.");

            Console.WriteLine($"Are both loggers same? {object.ReferenceEquals(logger1, logger2)}");
        }
    }
}