namespace EmtechActions
{
    internal interface IConfigReader<TConfig>
    {
        TConfig Read();
    }
}