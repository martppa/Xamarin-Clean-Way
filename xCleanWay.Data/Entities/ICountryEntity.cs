namespace xCleanWay.Data.Entities
{
    /// <summary>
    /// Country model in data layer. This class must be implemented
    /// according to the framework.
    /// </summary>
    public interface ICountryEntity
    {
        string Name { get; }
        string IsoCode { get; }
        string FlagUrl { get; }
    }
}
