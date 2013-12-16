using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotSharp;
using System.Runtime.InteropServices;
using Timer = System.Threading.Timer;

namespace WindowSpot
{
    public partial class Main : Form
    {
        SpotClient _spot;
        private const int SnapInDistance = 50;


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
                return;

           bgw.RunWorkerAsync();
        }

        private void SetupClicked(object sender, EventArgs e)
        {
            HorriblePollingTimer.Stop();
            var setup = new Setup();
            if (setup.ShowDialog(this) == DialogResult.OK)
                Connect();

            HorriblePollingTimer.Start();
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
                    Volume = string.IsNullOrEmpty(_spot.Volume()) ? 0 : Convert.ToInt16(_spot.Volume())
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


        public struct WindowPos
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public uint flags;
        }

        private const int WM_WINDOWPOSCHANGING = 0x46;

        protected override void WndProc(ref Message m)
        {
            bool Snapped = false;
            if ((m.Msg == WM_WINDOWPOSCHANGING) && (Properties.Settings.Default.SnapToEdge))
                {
                 Screen scn = Screen.FromPoint(this.Location);
                WindowPos mwp;
                mwp = (WindowPos)Marshal.PtrToStructure(m.LParam, typeof(WindowPos));
                if (mwp.x != 0)
                {
                    // Left
                    if (mwp.x <= (scn.WorkingArea.Left + SnapInDistance))
                    {
                        mwp.x = scn.WorkingArea.Left;
                        Snapped = true;
                    }
                    // Right
                    if ((mwp.x + mwp.cx) >= (scn.WorkingArea.Right - SnapInDistance))
                    {
                        mwp.x = scn.WorkingArea.Right - mwp.cx;
                        Snapped = true;
                    }
                    // Top
                    if (mwp.y <= (scn.WorkingArea.Top + SnapInDistance))
                    {
                        mwp.y = scn.WorkingArea.Top;
                        Snapped = true;
                    }
                    // Bottom
                    if ((mwp.y + mwp.cy) >= (scn.WorkingArea.Bottom - SnapInDistance))
                    {
                        mwp.y = scn.WorkingArea.Bottom - mwp.cy;
                        Snapped = true;
                    }
                    // Keep from moving off the screen
                    if (mwp.x < scn.WorkingArea.Left) mwp.x = scn.WorkingArea.Left;
                    if ((mwp.x + mwp.cx) > scn.WorkingArea.Right) mwp.x = scn.WorkingArea.Right - mwp.cx;
                    if (mwp.y < scn.WorkingArea.Top) mwp.y = scn.WorkingArea.Top;
                    if ((mwp.y + mwp.cy) > scn.WorkingArea.Bottom) mwp.y = scn.WorkingArea.Bottom - mwp.cy;
                    Marshal.StructureToPtr(mwp, (IntPtr)m.LParam,false);
                }
                m.Result = (IntPtr)0;
                }
            base.WndProc(ref m);
            }
    }

    internal class SpotState
    {
        public string Playing { get; set; }
        public Image Image { get; set; }
        public int Volume { get; set; }
    }
}
