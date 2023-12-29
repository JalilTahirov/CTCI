using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics
{

    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();

        private Logger() { }

        public static Logger Instance
        {
            get { return _instance; }
        }

        public void LogMessage(string message)
        {
            // Implement logging logic here
            Console.WriteLine(message);
        }
    }


    internal class Singleton
    {
        private Singleton()
        {
        }

        private static readonly Singleton _instance = new Singleton();


        public Singleton CreateOne()
        {
            return _instance;
        }
    }
}
