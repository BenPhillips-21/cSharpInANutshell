// A delegate type defines the kind of method that delegate instances can call.
    // Specifically, it defines the method’s return type and its parameter types

Transformer t = Square;          // Create delegate instance
int result = t(3);               // Invoke delegate
Console.WriteLine (result);      // 9

int[] values = { 1, 2, 3 };
Transform (values, Cube);      // Hook in the Cube method

foreach (int i in values)
    Console.Write (i + "  ");      // 1   4   9

void Transform (int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
        values[i] = t (values[i]);
}

int Square (int x) => x * x;
int Cube (int x) => x * x * x;

delegate int Transformer (int x);   // Delegate type declaration

