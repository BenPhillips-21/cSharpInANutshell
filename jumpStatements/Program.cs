// Break statement
// ends execution of the body of an iteration
int x = 0;
while (true)
{
    if (x++ > 5)
        break;      // break from the loop
}
// execution continues here after break



// Continue statement
for (int i = 0; i < 10; i++)
{
    if ((i % 2) == 0)       // If y is even,
        continue;             // continue with next iteration

    Console.Write (i + " ");
}


// Go To Statement
int y = 1;
startLoop: // statement label
if (y <= 5)
{
    Console.Write (y + " ");
    y++;
    goto startLoop;
}


// Return statement
decimal AsPercentage (decimal d)
{
    decimal p = d * 100m;
    return p;             // Return to the calling method with value
}