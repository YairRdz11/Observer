public class AverageScoreDisplay:IObserver
{
    private float _runRate;
    private int _predictedScore;

    public void Update(int runs, int wickets, float overs)
    {
        _runRate = (float)runs/overs;
        _predictedScore = (int)(_runRate * 50);
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"\nAverage Score Display: \nRun rate: {_runRate} \nPredictedScore: {_predictedScore}");
    }
}