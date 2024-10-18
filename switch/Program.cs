void ShowCard (int cardNumber)
{
    switch (cardNumber)
    {
        case 13:
            Console.WriteLine ("King");
            break;
        case 12:
            Console.WriteLine ("Queen");
            break;
        case 11:
            Console.WriteLine ("Jack");
            break;
        case -1:                         // Joker is -1
            goto case 12;                  // In this game joker counts as queen
        default:                         // Executes for any other cardNumber
            Console.WriteLine (cardNumber);
            break;
    }
}

ShowCard(-1);

// When more than one value should execute the same code, you can list the common cases sequentially:
// switch (cardNumber)
// {
//     case 13:
//     case 12:
//     case 11:
//         Console.WriteLine ("Face card");
//         break;
//     default:
//         Console.WriteLine ("Plain card");
//         break;
// }


// You can also switch on types (from C# 7):
TellMeTheType (12);
TellMeTheType ("hello");
TellMeTheType (true);
TellMeTheType (11.2);

void TellMeTheType (object x)   // object allows any type.
{
    switch (x)
    {
        case int i:
            Console.WriteLine ("It's an int!");
            Console.WriteLine ($"The square of {i} is {i * i}");
            break;
        case string s:
            Console.WriteLine ("It's a string");
            Console.WriteLine ($"The length of {s} is {s.Length}");
            break;
        case bool y when y == true: // // Fires only when b is true
            Console.WriteLine ("It's a true boolean");
            Console.WriteLine (y);
            break;
        default:
            Console.WriteLine ("I don't know what x is");
            break;
    }
}

// Using a switch statement to assign a variable
var cardNumber = 15;
string cardName = cardNumber switch
{
    13 => "King",
    12 => "Queen",
    11 => "Jack",
    _ => "Pip card"   // equivalent to 'default'
};
Console.WriteLine (cardName); // "Pip card"


// Switching on multiple values
var cardNumberr = 13;
var suite = "clubs";

string cardNamee = (cardNumberr, suite) switch
{
    (13, "spades") => "King of spades",
    (13, "clubs") => "King of clubs",
    _ => "King Chungus"
};

Console.WriteLine (cardNamee); // "King of clubs"