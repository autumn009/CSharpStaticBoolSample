foreach (var item in Enum.GetValues(typeof(X)))
{
    Console.WriteLine($"X.{item}");
}

enum X
{
    Wing, Bomber
}
