using WindowSpot.Core;
using WindowSpot.Properties;
using WindowSpot.Views;

namespace WindowSpot.Presenters
{
    public class SetupPresenter: Presenter<ISetupView>
    {
        readonly ISetupView _view;

        public SetupPresenter(ISetupView view) : base(view)
        {
            _view = view;
        }

        public void Show()
        {
            _view.ShowDialog();
        }
        public void Ok(string address)
        {
            Settings.Default.Host = address;
            Settings.Default.Save();
            _view.Close();
        }
        public void Cancel()
        {
           _view.Close();
        }
    }
}