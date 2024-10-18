var leIndividual = new Individual("Roberto", "Wallace");
leIndividual.Print();

Console.WriteLine (Foo.X);    // 3

Subclass s = new Subclass (123);
Console.WriteLine(s.X);

// Primary Constructors
// C# 12 allows you to include a parameter list after a class declaration
// instructs the compiler to automatically build a primary constructor for the variables...
class Individual (string firstName, string lastName)
{
    // firstName and lastName ARE NOT stored as properties
    public readonly string FullName = $"{firstName} {lastName}";

    private readonly string lastName = (lastName == null)
        ? throw new ArgumentNullException("lastName")
        : lastName;
    public void Print() => Console.WriteLine (FullName);
}

// Static Constructors
class Foo
{
    // Static field initializers run in the order in which the fields are declared.
    public static Foo Instance = new Foo();
    public static int X = 3;
   

    Foo() => Console.WriteLine (X);    // 0
}

// Static field initializers run just before the static constructor is called.
// If a type has no static constructor, static field initializers will execute
// just prior to the type being used—or anytime earlier at the whim of the runtime.


public class Baseclass
{
    public int X;
    public Baseclass () { }
    public Baseclass (int x) => X = x;
}

// subclass calling the base class constructor
public class Subclass(int x) : Baseclass (x)
{

}