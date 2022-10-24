// See https://aka.ms/new-console-template for more information

class RubberDuck : Duck
{
    public RubberDuck()
    {
        _quackBehavior = new Squack();
        _flyBehavior = new FlyNoWay();
    }

    public override void display()
    {
        Console.WriteLine("[ Display 고무오리(RubberDuck) ]");
    }
}
