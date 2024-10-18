// VALUE TYPES

ValPoint p1 = new ValPoint();
p1.X = 7;

ValPoint p2 = p1;             // Assignment causes copy

Console.WriteLine (p1.X);  // 7
Console.WriteLine (p2.X);  // 7

p1.X = 9;                  // Change p1.X

Console.WriteLine (p1.X);  // 9
Console.WriteLine (p2.X);  // 7

// REFERENCE TYPES

RefPoint pp1 = new RefPoint();
pp1.X = 7;

RefPoint pp2 = pp1;             // Copies pp1 reference

Console.WriteLine (pp1.X);  // 7
Console.WriteLine (pp2.X);  // 7

pp1.X = 9;                  // Change pp1.X

Console.WriteLine (pp1.X);  // 9
Console.WriteLine (pp2.X);  // 9


// VALUE TYPE
public struct ValPoint { public int X, Y; }

// REFERENCE TYPE
public class RefPoint { public int X, Y; }