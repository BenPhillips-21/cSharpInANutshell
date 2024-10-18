foreach (char c in "beer")
    Console.WriteLine (c);

using (var enumerator = "beer".GetEnumerator())
    while (enumerator.MoveNext())
    {
        var element = enumerator.Current;
        Console.WriteLine (element);
    }

// Iterator
    
foreach (int fib in Fibs(6))
{
    Console.Write (fib + "  ");
    Console.WriteLine("bello");
}

IEnumerable<int> Fibs (int fibCount)
{
    for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
    {
        yield return prevFib;
        int newFib = prevFib+curFib;
        prevFib = curFib;
        curFib = newFib;
    }
}

foreach (string s in Foo(true))
    Console.WriteLine(s);         // Prints "One","Two","Three"

IEnumerable<string> Foo (bool breakEarly)
{
    yield return "One";
    yield return "Two";

    if (breakEarly)
        yield break;

    yield return "Three";
}