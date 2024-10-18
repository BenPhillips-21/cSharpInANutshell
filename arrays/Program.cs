char[] vowels = ['a', 'e', 'i', 'o', 'u'];

for (int i = 0; i < vowels.Length; i++)
{
    Console.WriteLine(vowels[i]);
}

// Indices
char lastElement = vowels[^1];
char secondLastElement = vowels[^2];
Console.WriteLine("Second Last Element: {0}", secondLastElement);
Console.WriteLine("Last Element: {0}", lastElement);

Index first = 0;
char firstElem = vowels[first];
Console.WriteLine("First Element: {0}", firstElem);

// Ranges

// The second number in  the range is exclusive, so ..2 returns the elements before vowels[2]
char[] firstTwo = vowels[..2];
Console.WriteLine("First Two: {0} {1}", firstTwo[0], firstTwo[1]);

char[] middle = vowels[2..3];
Console.WriteLine("Middle: {0}", middle[0]);