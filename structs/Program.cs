// the default constructor performs a bitwise-zeroing of its fields (setting them to their default values)
Point p1 = new Point();       // p1.x and p1.y will be 1
Point p2 = default;           // p2.x and p2.y will be 0
// the implicit parameterless constructor still exists and can be accessed via the default keyword

Console.WriteLine(p1.y);

Console.WriteLine(p2.y);

readonly struct Point
{
    public readonly int y;
    public Point() => y = 1;
}

