class Test
{
    static void Main (string[] args)
    {
        try
        {
            byte b = byte.Parse(args[0]);
            Console.WriteLine(b);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Please provide at least one argument");
        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("You've given me more than a byte!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}