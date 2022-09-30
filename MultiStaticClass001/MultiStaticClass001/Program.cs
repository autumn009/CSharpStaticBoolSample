Console.WriteLine($"X<short>.TheMember={X<short>.TheMember}");
Console.WriteLine($"X<int>.TheMember={X<int>.TheMember}");
Console.WriteLine($"X<long>.TheMember={X<long>.TheMember}");

static class X<T> where T : struct
{
	public static string TheMember;
	static X()
	{
		TheMember = default(T).GetType().Name;
	}
}
