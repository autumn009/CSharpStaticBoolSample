List<long> list = new List<long>();

foreach (var fullpath in Directory.EnumerateFiles(args[0], "*.jpg", SearchOption.AllDirectories))
{
    list.Add(new FileInfo(fullpath).Length);
    if ((list.Count & 4095) == 1)
    {
        Console.Write(list.Count);
        Console.Write('\r');
    }
}

Console.WriteLine($"Total Count of files: {list.Count}");
Console.WriteLine($"Sum of files: {list.Sum()}");
Console.WriteLine($"Min size: {list.Min()}");
Console.WriteLine($"Max size: {list.Max()}");
Console.WriteLine($"Average: {list.Average()}");
