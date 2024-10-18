Stock msft = new Stock { Name="MSFT", SharesOwned=1000 };

Display(msft);         // MSFT
Console.WriteLine (msft.SharesOwned);  // 1000

House mansion = new House { Name="Mansion", Mortgage=250000 };

Display(msft);     // Mansion
Console.WriteLine (mansion.Mortgage);  // 250000

static void Display (Asset asset)
{
    Console.WriteLine (asset.Name);
}
// References are polymorphic. This means a variable of type x can refer to an object that subclasses x
// Polymorphism works on the basis that subclasses (Stock and House) have all the features of their base class (Asset).
// The converse, however, is not true.


Stock foo = new Stock();
foo.Name = "foo";
Asset a = foo;              // Upcast
Console.WriteLine (a == foo);        // True
Console.WriteLine (a.Name);
// Console.WriteLine(a.StocksOwned); // Compile Error

Stock b = (Stock)a;        // Downcast
b.SharesOwned = 1000;
Console.WriteLine (b.SharesOwned);   // 1000
Console.WriteLine (b == a);          // True
Console.WriteLine (b == msft);       // True
if (b is Stock c && c.SharesOwned == 1000)
    Console.WriteLine ("1000 shares owned");

House house = new House();
house.Mortgage = 250000;
Console.WriteLine (house.Liability);

Asset A = new Asset();
// The as operator performs a downcast that evaluates to null (rather than throwing an exception) if the downcast fails
Stock S = A as Stock;       // s is null; no exception thrown
if (S != null) Console.WriteLine (S.Name);

// Upcasting (safe): When you treat a derived class (e.g., Stock)
// as its base class (e.g., Asset), this always works because a Stock is an Asset.

// Downcasting (risky): When you try to treat a base class (e.g., Asset) as a derived class (e.g., Stock),
// it only works if the object was originally instantiated as the derived type (Stock), which isn't the case here.

Equity equity = new Equity
{
    UnitsOwned = 100,
    MarketPrice = 50.25m
};

// Output the total market value of the equity
Console.WriteLine($"Total Value: {equity.TotalValue:C}");

public class Asset
{
    public string Name;
    public virtual decimal Liability => 5;
}

public class Stock : Asset   // inherits from Asset
{
    public long SharesOwned;
}

public class House : Asset   // inherits from Asset
{
    public decimal Mortgage;
    public sealed override decimal Liability => base.Liability + Mortgage;
    // sealed keyword prevents it from being overridden by further subclasses
    // base keywork accesses the implementation of liability in base class
}

// Abstract Classes
public abstract class Investment
{
    // Abstract property
    public abstract decimal TotalValue { get; }
}

public class Equity : Investment
{
    public long UnitsOwned;
    public decimal MarketPrice;

    // Calculate the total value of the equity
    public override decimal TotalValue => MarketPrice * UnitsOwned;
}

public class A { public int Counter = 1; }
public class B : A { public new int Counter = 2; }
// The Counter field in class B is said to hide the Counter field in class A

