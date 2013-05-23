using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotSharp;
using Timer = System.Threading.Timer;

namespace WindowSpot
{
    public partial class Main : Form
    {
        SpotClient _spot;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Host))
            {
                btnBack.PerformClick();
            }
            else
            {
                Connect();
                HorriblePollingTimer.Start();
            }
        }

        void Connect()
        {
            _spot = new SpotClient(Properties.Settings.Default.Host);
        }

        void Sync()
        {
            if (bgw.IsBusy)
            {
                MessageBox.Show("It's busy!");
                return;
            }
           bgw.RunWorkerAsync();
        }

        private void SetupClicked(object sender, EventArgs e)
        {
            var setup = new Setup();
            setup.ShowDialog(this);
        }

        private void VolumeChanged(object sender, EventArgs e)
        {
            _spot.SetVolume(tbVolume.Value);
        }

        private void PlayClicked(object sender, EventArgs e)
        {
            _spot.Play();
        }

        private void PauseClicked(object sender, EventArgs e)
        {
            _spot.Pause();
        }

        private void NextClicked(object sender, EventArgs e)
        {
            _spot.Next();
        }

        private void BackClicked(object sender, EventArgs e)
        {
            _spot.Back();
        }

        private void SayIt(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSay.PerformClick();
        }

        private void SayIt(object sender, EventArgs e)
        {
            _spot.Say(txtSay.Text);
        }

        private void BeginSync(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var state = new SpotState
                {
                    Playing = _spot.Playing(),
                    Image = _spot.AlbumArt(),
                    Volume = Convert.ToInt16(_spot.Volume())
                };
            e.Result = state;
        }

        private void CompleteSync(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            var state = (SpotState) e.Result;
            lblNowPlaying.Text = state.Playing;
            pbAlbum.Image = state.Image;
            tbVolume.Value = state.Volume;
        }

        private void Poll(object sender, EventArgs e)
        {
            Sync();
        }
    }

    internal class SpotState
    {
        public string Playing { get; set; }
        public Image Image { get; set; }
        public int Volume { get; set; }
    }
}
