public class Program
{
    public static void Main()
    {
        // Create an instance of FooDeezNuts by injecting dependencies
        IFooDeezNuts obj = new FooDeezNuts(new Foo(), new Deez(), new Nuts());

        // Use the object
        Console.WriteLine(obj.GetDeez());
        Console.WriteLine(obj.GetNuts());
        Console.WriteLine(obj.GetFoo());
    }
}

public interface IFooDeezNuts : IFoo, IDeez, INuts
{
}

public class Deez : IDeez
{
    public string GetDeez() => "deez";
}

public interface IDeez
{
    string GetDeez();
}

public class Nuts : INuts
{
    public string GetNuts() => "nuts";
}

public interface INuts
{
    string GetNuts();
}

public class Foo : IFoo
{
    public string GetFoo() => "foo";
}

public interface IFoo
{
    string GetFoo();
}

public class FooDeezNuts : IFooDeezNuts
{
    private readonly IFoo _foo;
    private readonly IDeez _deez;
    private readonly INuts _nuts;

    // Constructor with dependency injection
    public FooDeezNuts(IFoo foo, IDeez deez, INuts nuts)
    {
        _foo = foo;
        _deez = deez;
        _nuts = nuts;
    }

    public string GetFoo() => _foo.GetFoo();

    public string GetDeez() => _deez.GetDeez();

    public string GetNuts() => _nuts.GetNuts();
}
