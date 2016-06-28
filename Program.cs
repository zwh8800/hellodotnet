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
            Console.WriteLine("project dependencies is {0}", obj.dependencies);
            Console.WriteLine("project frameworks['netcoreapp1.0'].imports is {0}", 
                obj.frameworks["netcoreapp1.0"].imports);
            Console.WriteLine(obj);
        }
    }
}
