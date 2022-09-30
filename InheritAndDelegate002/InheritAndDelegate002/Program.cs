Action[] acts = { subA, subB };

foreach (var act in acts) act();

void subA() => Console.WriteLine("I'm in A");
void subB() => Console.WriteLine("I'm in B");
