int a = 2, b=3, c=5, d=7, e=11;

sub1(a,b,c,d,e);
sub2();

// Case1
void sub1(int a1, int a2, int a3, int a4, int a5)
{
    Console.WriteLine(a1 + a2 + a3 + a4 + a5);
}

// Case2
void sub2()
{
    Console.WriteLine(a + b + c + d + e);
}