using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppSettings
{
    class Program
    {
        private const string HelloWorldMessage = "HelloWorldMessage";

        static void Main(string[] args)
        {
            AppSettingsReader reader = new AppSettingsReader();
            string message = (string)reader.GetValue(HelloWorldMessage, typeof(string));
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
