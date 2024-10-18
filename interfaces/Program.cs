Widget w = new Widget();
w.Foo();                      // Widget's implementation of I1.Foo  (DEFAULT)
((I2)w).Foo();                // Widget's implementation of I2.Foo  (MUST BE EXPLICITLY CAST)

Midget m = new Midget();
m.Foo();
((Widget)m).Foo();
((I1)m).Foo();     // All call subclass Foo due to override

Fidget f = new Fidget();
f.Foo(); // Calls subclass Foo
((Widget)f).Foo(); // Widget I1 Foo
((I2)f).Foo(); // Widget I2 Foo

TextBox t = new TextBox();
RichTextBox r = new RichTextBox();

t.Undo();
r.Undo();

ILogger.Prefix = "File log: ";
ILogger logger = new Logger();
logger.Log("Chungus");

interface I1 { void Foo(); }
interface I2 { int Foo(); }

public class Widget : I1, I2
{
    public virtual void Foo()
    {
        Console.WriteLine ("Widget's implementation of I1.Foo");
    }

    int I2.Foo()
    {
        Console.WriteLine ("Widget's implementation of I2.Foo");
        return 42;
    }
}

public class Midget : Widget
{
    public override void Foo()
    {
        Console.WriteLine ("I AM A DWARF FOO");
    }
}

public class Fidget : Widget, I2
{
    public int Foo()
    {
        Console.WriteLine ("FIDGET SPINNER FOO");
        return 69;
    }
}

// Best pattern for interface reimplementation
public interface IUndoable { void Undo(); }
public class TextBox : IUndoable
{
    void IUndoable.Undo()         => Undo();    // Calls method below
    public virtual void Undo() => Console.WriteLine ("TextBox.Undo");
}

public class RichTextBox : TextBox
{
    public override void Undo() => Console.WriteLine("RichTextBox.Undo");
}


// Static nonvirtual interface members exist mainly to help with writing default interface members.
interface ILogger
{
    void Log (string text) => 
        Console.WriteLine (Prefix + text);

    static string Prefix = ""; 
}

public class Logger : ILogger{}
