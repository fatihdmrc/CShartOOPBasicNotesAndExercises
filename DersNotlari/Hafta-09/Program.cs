Console.WriteLine("Hafta 9 - Field ve Property Ozeti");

Foo foo1 = new Foo();
Console.WriteLine($"foo1.I: {foo1.I} foo1.S: {Foo.S}");

Foo foo2 = new Foo();
Console.WriteLine($"foo2.I: {foo2.I} foo2.S: {Foo.S}");

public class Foo
{
    public int I;
    public static int S;

    public Foo()
    {
        I++;
        S++;
    }
}

// public int degisken; --> field
// public int Degisken { get; set; } --> property
