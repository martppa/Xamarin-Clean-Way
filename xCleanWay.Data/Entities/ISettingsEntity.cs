namespace xCleanWay.Data.Entities
{
    /// <summary>
    /// Settings model in data layer. This class must be implemented
    /// according to the framework used.
    /// </summary>
    public interface ISettingsEntity
    {
        long CountryCacheInMillis { get; set; }
    }
}