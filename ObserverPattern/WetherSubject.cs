// See https://aka.ms/new-console-template for more information


public class WetherSubject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private int _temperature;

    public void notifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_temperature);
        }
    }

    public void registerObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void removeObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }


    public void temperatureChanged()
    {
        _temperature++;
        notifyObservers();
    }
}