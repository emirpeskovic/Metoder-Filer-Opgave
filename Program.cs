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

            // Opgave 4-6
            Directory.CreateDirectory(@".\Droids");
            Directory.Delete(@".\Droids", true);
            Directory.CreateDirectory(@".\Droids\StarWarsSpoilers");
            File.WriteAllText(@".\Droids\StarWarsSpoilers\JegHarAldrigSetStarWars.txt", "Men jeg tror at Han ikke skød først");
            var files = Directory.GetFiles(@".\Droids", "*.txt", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);
        }
    }
}
