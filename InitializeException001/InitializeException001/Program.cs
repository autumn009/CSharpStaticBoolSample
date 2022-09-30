Console.WriteLine(TheClass.X);

static class TheClass
{
    public static int X;
    static TheClass()
    {
        throw new Exception("SampleException");
    }
}
