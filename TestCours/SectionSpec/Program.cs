using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionSpec
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomConfigurationSection customConfig = CustomConfigurationSection.GetSection();
            string message = customConfig.HelloWorldMessage;
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
