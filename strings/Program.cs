using System.Xml;

string a = "Heat";
string b = "Heat";
Console.WriteLine(a == b);
// String is a reference type rather than a value type. Its equality operators follow value type semantics though.


// Verbatim string literal allows you to use literal backslashes
string a2 = @"\\server\fileshare\helloworld.cs";
Console.WriteLine(a2);

// Interpolated strings can include any valid C# expression enclosed in braces.
int x = 4;
Console.WriteLine($"A square has {x} sides");
// Prints: A square has 4 sides


// Raw string literals can contain almost any character sequence. Useful for representing JSON, XML, HTML literals.
string raw = """<file path="c:\temp\test.txt"></file>""";
Console.WriteLine(raw);


string s = "a" + "b";
Console.WriteLine(s);
// prints: ab

string ss = "a" + 9;
Console.WriteLine(ss);
// prints: a9