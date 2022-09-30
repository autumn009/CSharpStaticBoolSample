Console.WriteLine(TheClass.X);

static class TheClass
{
    public static int X;
    public static void sub()
    {
        Console.WriteLine(X);
    }
    static TheClass()
    {
        sub();
        X = 123;
    }
}
