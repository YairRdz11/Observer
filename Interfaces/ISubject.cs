public interface ISubject
{
    void RegisterObserver(IObserver o);
    void UnRegisterObject(IObserver o);
    void NotifyObserver();
}