say("猫",Cat);
say("犬",Dog);

string Cat() => "にゃあ";
string Dog() => "わん";

void say(string label, Func<string> func)
{
    Console.WriteLine($"{label}は{func()}");
}
