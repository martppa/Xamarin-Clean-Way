namespace xCleanWay.Ui.Presenters.Settings
{
    public interface ISettingsPresenter : IPresenter
    {
        void RequestSettings();
        void SetCountryCacheLifeTime(long value);
    }
}