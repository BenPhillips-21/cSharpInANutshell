// C# enforces a definite assignment policy...

// int x;
// Console.WriteLine (x);        // Compile-time error



// Arguments are PASSED BY VALUE

using System.Text;

int x = 8;
Foo (x);                    // Make a copy of x
Console.WriteLine (x);      // x will still be 8

static void Foo (int p)
{
    p = p + 1;                // Increment p by 1
    Console.WriteLine (p);    // Prints 9
}


// Explicitly asking the runtime to PASS BY REFERENCE

int y = 8;
Woo(ref y);              // Ask Foo to deal directly with x
Console.WriteLine (y);     // x is now 9

static void Woo (ref int p)
{
    p = p + 1;               // Increment p by 1
    Console.WriteLine (p);   // Write p to screen
}

// Reference types can be mutated but NOT reassigned
StringBuilder sb = new StringBuilder();
Doo (sb);
Console.WriteLine (sb.ToString());    // test

static void Doo (StringBuilder fooSB)
{
    fooSB.Append ("test");
    fooSB = null;
}



// The out modifier
// Need not be assigned before going into the function.
// Must be assigned before coming out.
// most commonly used to get multiple return values back from a method
Split ("Stevie Ray Vaughan", out string a, out string b);
Console.WriteLine (a);                      // Stevie Ray
Console.WriteLine (b);                      // Vaughn

void Split (string name, out string firstNames, out string lastName)
{
    int i = name.LastIndexOf (' ');
    firstNames = name.Substring (0, i);
    lastName = name.Substring (i + 1);
}

// There is also the in modifier which makes the argument READ ONLY

// The Params Modifier
// Allows the method to accept any number of arguments of a particular type
int total = Sum (1, 2, 3, 4);
Console.WriteLine (total);              // 10

int Sum (params int[] ints)
{
    int sum = 0;
    for (int i = 0; i < ints.Length; i++)
        sum += ints [i];                       // Increase sum by ints[i]
    return sum;
}

// Named Arguments
Goo (y:1, x:2);  // 2, 1
void Goo (int x, int y) { Console.WriteLine (x + ", " + y); }

Test.Main ();

class Test
{
    static int q;
    public static void Main()
    {
        Foo (out q);
    }

    static void Foo (out int w)
    {
        Console.WriteLine (q);                // q is 0
        w = 1;                                // Mutate w
        Console.WriteLine (q);                // q is 1
    }
}



