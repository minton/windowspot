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
            DialogResult = DialogResult.OK;
            Properties.Settings.Default.Host = txtHost.Text;
            Properties.Settings.Default.SnapToEdge = cboxSnapToEdge.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            txtHost.Text = Properties.Settings.Default.Host;
            cboxSnapToEdge.Checked = Properties.Settings.Default.SnapToEdge;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
