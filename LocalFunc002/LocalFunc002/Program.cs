add(2, 1);
sub(2, 1);

void add(int x, int y)
{
    report(x, y, '+', x + y);
}

void sub(int x, int y)
{
    report(x, y, '-', x - y);
}

void report(int x, int y, char opr, int r)
{
    Console.WriteLine($"{x}{opr}{y}={r}");
}
