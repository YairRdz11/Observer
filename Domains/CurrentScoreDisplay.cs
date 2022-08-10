public class CurrentScoreDisplay:IObserver
{
    private int _runs;
    private int _wickets;
    private float _overs;

    public void Update(int runs, int wickets, float overs)
    {
        _runs = runs;
        _wickets = wickets;
        _overs = overs;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"\nCurrent Score Display: \nRuns: {_runs} \nWicket: {_wickets} \nOvers: {_overs}");
    }
}