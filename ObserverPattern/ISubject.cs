// See https://aka.ms/new-console-template for more information

public interface ISubject
{
    void registerObserver(IObserver observer);
    void removeObserver(IObserver observer);
    void notifyObservers();
}
