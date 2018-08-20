namespace xCleanWay.Ui.Views
{
    public interface IView
    {
        void ShowInfoMessage(string message);
        void ShowWarningMessage(string message);
        void ShowErrorMessage(string message);
    }
}