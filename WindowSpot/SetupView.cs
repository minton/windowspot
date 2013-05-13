using System;
using System.Windows.Forms;
using WindowSpot.Core;
using WindowSpot.Views;

namespace WindowSpot
{
    public partial class SetupView : Form, ISetupView
    {
        public SetupView()
        {
            InitializeComponent();
            WireEvents();
        }

        void WireEvents()
        {
            btnCancel.Click += (sender, args) => OnCancel.Raise();
            btnOk.Click += (sender, args) => OnOk.Raise(txtAddress.Text);
        }

        public event Action<string> OnOk;
        public event Action OnCancel;
    }
}
