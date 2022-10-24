// See https://aka.ms/new-console-template for more information

class MallardDuck : Duck
{
    public MallardDuck()
    {
        _quackBehavior = new Quack();
        _flyBehavior = new Fly();
    }

    public override void display()
    {
        Console.WriteLine("[ Display 청둥오리(MallardDuck) ]");
    }
}
