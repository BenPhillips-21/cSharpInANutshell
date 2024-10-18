ProgressReporter p = WriteProgressToConsole;
p += WriteBello;
Util.HardWork (p);

void WriteProgressToConsole(int percentComplete)
    => Console.WriteLine (percentComplete);

void WriteBello(int percentComplete)
    => Console.WriteLine("Bello!");

public delegate void ProgressReporter (int percentComplete);

public class Util
{
    public static void HardWork (ProgressReporter p)
    {
        for (int i = 0; i < 10; i++)
        {
            p (i * 10);                           // Invoke delegate
            System.Threading.Thread.Sleep (100);  // Simulate hard work
        }
    }
}