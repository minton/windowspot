using System;
using WindowSpot.Core;

namespace WindowSpot.Views
{
    public interface ISetupView : IView
    {
        event Action<string> OnOk;
        event Action OnCancel;
    }
}