class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int nmbMinutes)
    {
        return ExpectedMinutesInOven() - nmbMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int nmbLayers)
    {
        return nmbLayers * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int nmbLayersAdded, int nmbMinutesOven)
    {
        return PreparationTimeInMinutes(nmbLayersAdded) + nmbMinutesOven;
    }
}
