// If the operand to the left is non-null, give it to me; otherwise, give me another value.
string s1 = null;
string s2 = s1 ?? "nothing";  

Console.WriteLine(s1);
Console.WriteLine(s2); // "nothing"


// If the operand to the left is null, assign the right operand to the left operand.
string myValue = "Hello World";
myValue ??= "defaultValue";
Console.WriteLine(myValue);

// Above is equivalent to:
// if (myVariable == null) myVariable = someDefault;


// if the operand on the left is null, the expression evaluates to null instead of throwing a NullReferenceException
System.Text.StringBuilder sb = null;
string s = sb?.ToString();  // No error; s instead evaluates to null

// Above is equivalent to the following:
// string s = (sb == null ? null : sb.ToString());