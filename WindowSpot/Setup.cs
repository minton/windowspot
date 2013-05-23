using System;
using System.Windows.Forms;
using SpotSharp;

namespace WindowSpot
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var spot = new SpotClient(txtHost.Text);
            MessageBox.Show(spot.Ping().Contains("Welcome") ? "worked" : "failed");
        }

        private void SaveClicked(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = txtHost.Text;
            Properties.Settings.Default.Save();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            txtHost.Text = Properties.Settings.Default.Host;
        }
    }
}
