using System;
using System.Collections.Generic;
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

            // Opgave 5-6 ?
            File.WriteAllText(@".\Movies.txt", "Finding Nemo\nFinding Dory\nCars\nCars 2\nCars 3\nMulan");
            using (var file = new FileStream(@".\Movies.txt", FileMode.Open))
            {
                using (var reader = new StreamReader(file))
                {
                    while (!reader.EndOfStream)
                    {
                        var movie = reader.ReadLine();
                        Console.WriteLine(movie);
                    }
                }
            }
            List<string> actors = new List<string>()
            {
                "Hale Appleman",
                "Wentworth Miller",
                "Benedict Cumberbatch"
            };
            using (var file = new FileStream(@".\Actors.txt", FileMode.Create))
            using (var writer = new StreamWriter(file))
                foreach (var actor in actors)
                    writer.WriteLine(actor);

            
        }
    }
}
