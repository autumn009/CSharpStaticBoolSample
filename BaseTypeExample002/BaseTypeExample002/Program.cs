int x = 1;
Sub1();
TheClass.Sub2(()=>x);

void Sub1()
{
    Console.WriteLine(x);
}

static class TheClass
{
    public static void Sub2(Func<int> peekValue)
    {
        Console.WriteLine(peekValue());
    }
}

