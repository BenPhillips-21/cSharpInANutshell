// While loop
// Expression is tested for truthiness BEFORE the body of the loop is executed
int i = 0;
while (i < 3)
{
    Console.Write (i);
    i++;
}

// Do while loop. Expression is tested for truthiness AFTER the body of the loop is executed
// Ensures the loop runs at least once.
int x = 0;
do
{
    Console.WriteLine (x);
    x++;
}
while (x < 3);

// For loop (Initialization clause, condition clause, iteration clause)
for (int y = 0, prevFib = 1, curFib = 1; y < 10; y++)
{
    Console.WriteLine (prevFib);
    int newFib = prevFib + curFib;
    prevFib = curFib; curFib = newFib;
}

// Foreach loops allow us to loop over enumerable objects
foreach (char c in "Chungus")
{
    Console.WriteLine(c);
}