namespace EmTech.Actions
{
    internal interface IConfigReader<TConfig>
    {
        TConfig Read();
    }
}