using Animals;

Panda p1 = new Panda ("Pan Dee");
Panda p2 = new Panda ("Pan Dah");
Panda p3 = new Panda ("Po Po");

Console.WriteLine (p1.Name);      // Pan Dee
Console.WriteLine (p2.Name);      // Pan Dah
Console.WriteLine (p3.Name);      // Po Po

Console.WriteLine (Panda.Population);   // 3

namespace Animals
{
    public class Panda
    {
        public string Name;             // Instance field
        public static int Population;   // Static field

        public Panda (string n)         // Constructor
        {
            Name = n;                     // Assign the instance field
            Population = Population + 1;  // Increment the static Population field
        }
    }
}
