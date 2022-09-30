new A().sub();
new B().sub();

class A
{
    public virtual void sub() => Console.WriteLine("I'm in A");
}
class B : A
{
    public override void sub() => Console.WriteLine("I'm in B");
}
