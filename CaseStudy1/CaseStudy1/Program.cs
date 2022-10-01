long count = 0;
long sum = 0;
long min = long.MaxValue;
long max = long.MinValue;
string minpath = "";
string maxpath = "";

foreach (var fullpath in Directory.EnumerateFiles(args[0], "*.jpg", SearchOption.AllDirectories))
{
    count++;
    long size = new FileInfo(fullpath).Length;
    sum += size;
    if (size < min)
    {
        min = size;
        minpath = fullpath;
    }
    if (size > max)
    {
        max = size;
        maxpath = fullpath;
    }
    if ((count & 4095) == 1)
    {
        Console.Write(count);
        Console.Write('\r');
    }
}

Console.WriteLine($"Total Count of files: {count}");
Console.WriteLine($"Sum of files: {sum}");
Console.WriteLine($"Min size: {min}");
Console.WriteLine($"Min path: {minpath}");
Console.WriteLine($"Max size: {max}");
Console.WriteLine($"Max path: {maxpath}");
