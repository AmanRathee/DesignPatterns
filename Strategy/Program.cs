using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        //Source :- https://www.dofactory.com/net/strategy-design-pattern

        //Define a family of algorithms, encapsulate each one, and make them interchangeable.
        //Strategy lets the algorithm vary independently from clients that use it.

        static void Main(string[] args)
        {
            string log = "MyLog";
            Logging logging = new Logging();


            Console.WriteLine("----Set Strategy to SEQ----");
            logging.SetLoggingStrategy(new SEQ());
            logging.Log(log);

            Console.WriteLine("----Set Strategy to NLog----");
            logging.SetLoggingStrategy(new NLog());
            logging.Log(log);


            Console.ReadLine();
        }
    }

    abstract class LoggingStrategy
    {
        public abstract void Logging(string log);
    }
    class SEQ : LoggingStrategy
    {
        public override void Logging(string log)
        {
            Console.WriteLine($"Logging of {log} done using {this.GetType().Name} logger.");
        }
    }
    class NLog : LoggingStrategy
    {
        public override void Logging(string log)
        {
            Console.WriteLine($"Logging of {log} done using {this.GetType().Name} logger.");
        }
    }

    class Logging
    {
        private LoggingStrategy _loggingStrategy;
        public void SetLoggingStrategy(LoggingStrategy loggingStrategy)
        {
            _loggingStrategy = loggingStrategy;
        }
        public void Log(string log)
        {
            _loggingStrategy.Logging(log);
        }
    }
}
