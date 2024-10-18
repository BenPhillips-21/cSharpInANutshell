static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}

var stack = new Stack<int>();
stack.Push(5);
stack.Push(10);

int x = stack.Pop();  // x is 10
int y = stack.Pop();  // y is 5

Console.WriteLine(x);  // 10
Console.WriteLine(y);  // 5

Swap(ref x, ref y);    // Calling Swap method

Console.WriteLine(x);  // 5
Console.WriteLine(y);  // 10

var myDict = new Dictionary<int,string>();

bool equal = Calculator<int>.AreEqual(2, 2);
Console.WriteLine(equal);

// Stack class definition
public class Stack<T>
{
    int position;
    T[] data = new T[100];

    public void Push(T obj) => data[position++] = obj;

    public T Pop() => data[--position];
}

class Dictionary<TKey, TValue> {}

public class Calculator<T>
{
    public static bool AreEqual(T a, T b)
    {
        return a.Equals(b);
    }
}

// public class 
// {
//     int position;
//     int[] data = new int[100];
//     public void Push (int obj)  => data[position++] = obj;
//     public int Pop()            => data[--position];
// }