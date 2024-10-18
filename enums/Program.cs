BorderSide topSide = BorderSide.Top;
Console.WriteLine(topSide);
bool isTop = (topSide == BorderSide.Top);   // True
Console.WriteLine(isTop);

// Explicitly casting enum's underlying integral value
int i = (int) BorderSide.Left;
Console.WriteLine(i);
BorderSide side = (BorderSide) i;
bool leftOrRight = (int) side <= 2;
Console.WriteLine(leftOrRight);
public enum BorderSide { Left, Right, Top, Bottom }

