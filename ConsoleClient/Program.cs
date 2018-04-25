using NoSQLinCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IService1 service1 = new Service1();
            Console.Out.WriteLineAsync(service1.GetData(10)).Wait();
        }
    }
}
