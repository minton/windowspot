using Machine.Specifications;
using WindowSpot.Presenters;
using WindowSpot.Views;
using NSubstitute;

namespace WindowSpot.Tests
{
    [Subject(typeof(SetupPresenter))]
    public class When_display_the_setup_presenter
    {
        static SetupPresenter _presenter;
        static ISetupView _view;
        
        Establish context = () =>
            {
                _view = NSubstitute.Substitute.For<ISetupView>();
                _presenter = new SetupPresenter(_view);
            };

        Because of = () => { _presenter.Show(); };

        It should_display_the_view = () => { _view.ReceivedWithAnyArgs().ShowDialog(); };        
    }
}