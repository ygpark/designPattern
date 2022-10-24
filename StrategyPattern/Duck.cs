// See https://aka.ms/new-console-template for more information

class Duck
{
    public IQuackBehavior _quackBehavior = new Quack();
    public IFlyBehavior _flyBehavior = new Fly();

    public void setQuackBehavior(IQuackBehavior quackBehavior)
    {
        _quackBehavior = quackBehavior;
    }

    public void setFlyBehavior(IFlyBehavior flyBehavior)
    {
        _flyBehavior = flyBehavior;
    }

    public void performQuack()
    {
        _quackBehavior.quack();
    }

    public void performFly()
    {
        _flyBehavior.fly();
    }

    public virtual void display()
    {
        Console.WriteLine("원시 오리모양 표시");
    }
}
