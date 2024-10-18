Stack stack = new Stack();
stack.Push ("sausage");
string s = (string) stack.Pop();   // Downcast, so explicit cast is needed
Console.WriteLine (s);             // sausage

stack.Push (5);
stack.Push (1.2);
double d = (double) stack.Pop();
int i = (int) stack.Pop();
Console.WriteLine (i); // 5
Console.WriteLine (d); // 1.2

// Boxing and Unboxing
int x = 9;
object obj = x;           // Box the int
int y = (int)obj;         // Unbox the int
// Unboxing requires an explicit cast. The runtime checks that the stated value type matches
// the actual object type, and throws an InvalidCastException if the check fails

// Boxing copies the value-type instance into the new object, and unboxing 
// copies the contents of the object back into a value-type instance
int z = 3;
object boxed = z;
z = 5;
Console.WriteLine (boxed);    // 3
public class Stack
{
    int position;
    object[] data = new object[10];
    public void Push (object obj)   { data[position++] = obj;  }
    public object Pop()             { return data[--position]; }
}