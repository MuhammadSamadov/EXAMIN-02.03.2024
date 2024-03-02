namespace task6;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {}

    public override void Greets()
    {
        System.Console.WriteLine("Woof");
    }
    public virtual void Grets()
    {
        System.Console.WriteLine("Woooooof");
    }
}
