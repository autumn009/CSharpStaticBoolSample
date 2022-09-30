int x = 1, y = 2;
sub(x, y);

static void sub(int a, int b)
{
    Console.WriteLine(a + b);
    // ↓できない
    // Console.WriteLine(x + y);
}
