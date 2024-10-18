char[] charArr = { 'H', 'e', 'l', 'l', 'o' };

GenericDelegate<char> charDelegate = Stringify;
string res = charDelegate(charArr);
Console.WriteLine(res);

int[] intArr = { 1, 2, 3 };

GenericDelegate<int> intDelegate = Stringify;
string intRes = intDelegate(intArr);
Console.WriteLine(intRes);

string Stringify<T>(T[] TArray)
{
    var s = "";
    foreach (var t in TArray)
    {
        string res = t.ToString();
        s += res;
    }

    return s;
}

delegate string GenericDelegate<T>(T[] args);