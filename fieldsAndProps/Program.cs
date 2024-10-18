Panda p = new Panda ("Petey");   // Call constructor
Panda p2 = new Panda ("Panda");
p2.Marry (p);
Console.WriteLine (p.name);
Console.WriteLine (p.Mate);


var rect = new Rectangle (3, 4);
(float width, float height) = rect;          // Deconstruction
Console.WriteLine (width + " " + height);    // 3 4

var person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    Age = 21
};

Console.WriteLine(person.LastName);
Console.WriteLine(person.Age);

// Instance constructors
public class Panda
{
    public string name;                   // Define field
    public Panda Mate;
    public Panda (string n)        // Define constructor
    {
        name = n;                    // Initialization code (set up field)
    }

    public void Marry(Panda partner)
    {
        Mate = partner;
        partner.Mate = this; // this refers to this instance 
    }
}

// Deconstructors
class Rectangle
{
    public readonly float Width, Height;
  
    public Rectangle (float width, float height)
    {
        Width = width;
        Height = height;
    }
  
    public void Deconstruct (out float width, out float height)
    {
        width = Width;
        height = Height;
    }
}


public class Stock
{
    public decimal currentPrice { get; set; } = 123;          
    private decimal sharesOwned;
    public int maximum { get; } = 999;
    // Only specifying the get makes this READ-ONLY
    
    public decimal Worth
    {
        get => currentPrice * sharesOwned;
        set => sharesOwned = value / currentPrice;
    }
}


// With object initializers, there's no need for a constructor to set properties!
public class Person
{
    public string FirstName { get; set; }

    // Backing field for LastName
    private string _lastName;
    
    private int _age;

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(LastName), "LastName cannot be null.");
            }
            _lastName = value; // Assign the value to the backing field
        }
    }
    
    public int Age 
    {
        get { return _age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be less than zero.");
            }
            _age = value;
        }
    }
}

