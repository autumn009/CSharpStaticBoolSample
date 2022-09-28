int x = 100;

// case 1
Console.WriteLine($"{x} to {tenPercentUp(x)}");

int tenPercentUp(int x)
{
    return x * 11 / 10;
}

// case 2
var calc = new MyCalculation();
Console.WriteLine($"{x} to {calc.TenPercentUp(x)}");

class MyCalculation
{
    public int TenPercentUp(int x)
    {
        return x * 11 / 10;
    }
}
