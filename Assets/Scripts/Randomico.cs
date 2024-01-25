using System;

public class Randomico
{
    private Random randomic;

    public Randomico()
    {
        randomic = new Random();
    }

    public int GeraRandomic(int minValue, int maxValue)
    {
        return randomic.Next(minValue, maxValue);
    }
}