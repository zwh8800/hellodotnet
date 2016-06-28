using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string data = File.ReadAllText(@"./project.json");
            dynamic obj = Json.Json.Parse(data);
            Console.WriteLine("project version is {0}", obj.version);
        }
    }
}
