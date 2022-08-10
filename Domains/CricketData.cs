public class CricketData : ISubject
{
    private int _runs;
    private int _wickets;
    private float _overs;
    List<IObserver> observerList;

    public CricketData(){
        observerList = new List<IObserver>();
    }

    public void RegisterObserver(IObserver o)
    {
        observerList.Add(o);
    }

    public void UnRegisterObject(IObserver o)
    {
        observerList.Remove(o);
    }

    public void NotifyObserver()
    {
        foreach(var observer in observerList)
        {
            observer.Update(_runs, _wickets, _overs);
        }
    }

    private int GetLatestRuns()
    {
        return 90;
    }

    private int GetLatestWickets()
    {
        return 2;
    }

    private float GetLatestOvers()
    {
        return (float)10.2;
    }
    //This method is used update displays
    //when data changes
    public void DataChanged()
    {
        //Get latest data
        _runs = GetLatestRuns();
        _wickets = GetLatestWickets();
        _overs = GetLatestOvers();

        NotifyObserver();
    }
}