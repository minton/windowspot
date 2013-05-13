using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowSpot.Presenters;
using WindowSpot.Properties;
using WindowSpot.Views;

namespace WindowSpot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISetupView view = new SetupView();
            var presenter = new SetupPresenter(view);
            presenter.Show();
            MessageBox.Show(string.Format("Spot is configured at this address: {0}.", Settings.Default.Host));
        }
    }
}
