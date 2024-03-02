namespace task6;

public class BigDog : Dog
{
    public BigDog(string name) : base(name)
    {}
    public override void Greets()
    {
        System.Console.WriteLine("Wooow");
    }
    public override void Grets()
    {
        System.Console.WriteLine("Woooooooow");
    }
    public void Greets(string bigdog)
    {
        System.Console.WriteLine("Wooooooooooooow");
    }

}
