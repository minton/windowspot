using System;
using System.Windows.Forms;

namespace WindowSpot.Core
{
    public interface IView : IDisposable
    {
        DialogResult ShowDialog();
        void Close();
    }
}