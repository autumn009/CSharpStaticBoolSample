// case 1
Console.WriteLine(Case1.LuckyNumbers.GetLuckyNumber());

// case 2
Console.WriteLine(Case2.LuckyNumbers.GetNumber());

// case 3
Console.WriteLine(Case3.LuckyNumbers.Get());

namespace Case1
{
    class LuckyNumbers
    {
        public static int GetLuckyNumber() => 7;
    }
}

namespace Case2
{
    class LuckyNumbers
    {
        public static int GetNumber() => 7;
    }
}

namespace Case3
{
    class LuckyNumbers
    {
        public static int Get() => 7;
    }
}
