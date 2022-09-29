recur(1);

void recur(int i)
{
    if (i > 3) return;
    Console.WriteLine($"Count={i}");
    recur(i + 1);
}
