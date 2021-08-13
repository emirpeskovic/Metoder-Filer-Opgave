using System;
using System.IO;

namespace Metoder_Filer_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1-3
            File.WriteAllText(@".\StarWars.txt", "Han shot first");
            var content = File.ReadAllText(@".\StarWars.txt");
            Console.WriteLine(content);
            File.Delete(@".\StarWars.txt");
        }
    }
}
