using DesignPatterns.ObserverPattern.Book.Interface;

namespace DesignPatterns.ObserverPattern.Book.Interface
{
    interface Subject
    {
        void RegisterObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void NotifyObservers();
    }
}
