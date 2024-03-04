public class BirdCount
{
    
    int [] _birds = {};

    public BirdCount(int[] birds)
    {
        _birds = birds;
    }
    public void LastWeek()
    {
        foreach (var item in _birds)
        {
            System.Console.Write(item + " ");
        }
    }

    public int Today()
    {
        return _birds[_birds.Length-1];
    }

    public void IncrementTodaysCount()
    {
        _birds[_birds.Length-1] = _birds[_birds.Length-1]+1;
    }

    public bool HasDayWithoutBirds()
    {
       return _birds.Contains(0);
    }

    public void CountForFirstDays(int days)
    {
        int b = 0;
        for (int i = 0; i < days; i++)
        {
            b=b+_birds[i];
        }
        System.Console.WriteLine(b);
    }

    public void BusyDays()
    {
        int b=0;
        for (int i = 0; i < _birds.Length-1; i++)
        {
            if(_birds[i]>4)b++;
        }
        System.Console.WriteLine(b);
    }
}