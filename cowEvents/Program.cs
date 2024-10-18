class Cow
{
    private Action mooing;
    public event Action Mooing
    {
        add
        {
            mooing += value;
            Console.WriteLine("Adding");
        }
        remove
        {
            mooing -= value;
            Console.WriteLine("Removing");
        }
    }

    public void PushSleepingCow()
    {
        mooing?.Invoke();
    }
}

class MainClass
{
    static void Main()
    {
        Cow cow = new Cow();
        cow.Mooing += () => Console.WriteLine("Mooing");
        cow.PushSleepingCow();
    }
}