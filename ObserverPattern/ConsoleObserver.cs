// See https://aka.ms/new-console-template for more information


public class ConsoleObserver : IObserver
{
    private readonly ISubject _subject;

    public ConsoleObserver(ISubject subject)
    {
        if (subject == null)
        {
            throw new NullReferenceException();
        }

        _subject = subject;
        _subject.registerObserver(this);
    }

    public void Update(int temperature)
    {
        Console.WriteLine($"Console... Current Temperature: {temperature}");
    }
}
