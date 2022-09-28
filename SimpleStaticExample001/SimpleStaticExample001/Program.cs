Console.WriteLine("実行を開始します");

for (int i = 0; i < 12; i++)
{
	Console.Write($"{new A()}, ");
}
Console.WriteLine($"クラスAは{A.Count}回作成されました");

class A
{
	private static int count;
	public static int Count => count;
	public A()
	{
		count++;
	}
	static A()
	{
		Console.WriteLine("クラスAが初期化されました");
		count = 0;
	}
}