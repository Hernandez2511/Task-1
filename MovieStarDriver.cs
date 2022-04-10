using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ejercicio_1
{
    internal class MovieStarDriver
    {
        static void Main(string[] args)
        {
            // used StreamReader to read file content
            StreamReader s = new StreamReader(@"C:\input.txt");
            string jsonString = s.ReadToEnd();

            // objects list of MovieStar class
            List<MovieStar> objs = JsonConvert.DeserializeObject<List<MovieStar>>(jsonString);

            // iterate through the list of objects and display results
            foreach (MovieStar star in objs)
            {
                Console.WriteLine(star.name + " " + star.surname);
                Console.WriteLine(star.sex);
                Console.WriteLine(star.nationality);
                Console.WriteLine(star.calcAge()+ " years old");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
