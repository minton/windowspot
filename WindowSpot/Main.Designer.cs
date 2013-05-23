namespace WindowSpot
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblNowPlaying = new System.Windows.Forms.Label();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.pnlSongInfo = new System.Windows.Forms.Panel();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.pnlSay = new System.Windows.Forms.Panel();
            this.txtSay = new System.Windows.Forms.TextBox();
            this.btnSay = new System.Windows.Forms.Button();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.HorriblePollingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.pnlSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.flpControls.SuspendLayout();
            this.pnlSay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 111);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(173, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // lblNowPlaying
            // 
            this.lblNowPlaying.BackColor = System.Drawing.Color.Black;
            this.lblNowPlaying.ForeColor = System.Drawing.Color.White;
            this.lblNowPlaying.Location = new System.Drawing.Point(0, 303);
            this.lblNowPlaying.Name = "lblNowPlaying";
            this.lblNowPlaying.Size = new System.Drawing.Size(300, 38);
            this.lblNowPlaying.TabIndex = 1;
            this.lblNowPlaying.Text = "[...]";
            this.lblNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAlbum
            // 
            this.pbAlbum.BackColor = System.Drawing.Color.Black;
            this.pbAlbum.Location = new System.Drawing.Point(0, 0);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(300, 300);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum.TabIndex = 2;
            this.pbAlbum.TabStop = false;
            // 
            // pnlSongInfo
            // 
            this.pnlSongInfo.Controls.Add(this.tbVolume);
            this.pnlSongInfo.Controls.Add(this.pbAlbum);
            this.pnlSongInfo.Controls.Add(this.lblNowPlaying);
            this.pnlSongInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSongInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlSongInfo.Name = "pnlSongInfo";
            this.pnlSongInfo.Size = new System.Drawing.Size(300, 389);
            this.pnlSongInfo.TabIndex = 1;
            // 
            // tbVolume
            // 
            this.tbVolume.BackColor = System.Drawing.Color.Black;
            this.tbVolume.Location = new System.Drawing.Point(3, 344);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(294, 45);
            this.tbVolume.TabIndex = 3;
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbVolume.Scroll += new System.EventHandler(this.VolumeChanged);
            // 
            // flpControls
            // 
            this.flpControls.BackColor = System.Drawing.Color.DimGray;
            this.flpControls.Controls.Add(this.btnPlay);
            this.flpControls.Controls.Add(this.btnPause);
            this.flpControls.Controls.Add(this.btnNext);
            this.flpControls.Controls.Add(this.btnBack);
            this.flpControls.Controls.Add(this.btnSetup);
            this.flpControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpControls.Location = new System.Drawing.Point(300, 0);
            this.flpControls.Name = "flpControls";
            this.flpControls.Size = new System.Drawing.Size(173, 389);
            this.flpControls.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(173, 37);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.PlayClicked);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(0, 37);
            this.btnPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(173, 37);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.PauseClicked);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(0, 74);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(173, 37);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextClicked);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(0, 148);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(173, 37);
            this.btnSetup.TabIndex = 4;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.SetupClicked);
            // 
            // pnlSay
            // 
            this.pnlSay.Controls.Add(this.txtSay);
            this.pnlSay.Controls.Add(this.btnSay);
            this.pnlSay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSay.Location = new System.Drawing.Point(0, 389);
            this.pnlSay.Name = "pnlSay";
            this.pnlSay.Size = new System.Drawing.Size(473, 23);
            this.pnlSay.TabIndex = 1;
            // 
            // txtSay
            // 
            this.txtSay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSay.Location = new System.Drawing.Point(0, 0);
            this.txtSay.Name = "txtSay";
            this.txtSay.Size = new System.Drawing.Size(398, 22);
            this.txtSay.TabIndex = 0;
            this.txtSay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SayIt);
            // 
            // btnSay
            // 
            this.btnSay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSay.Location = new System.Drawing.Point(398, 0);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(75, 23);
            this.btnSay.TabIndex = 0;
            this.btnSay.Text = "Say";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.SayIt);
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BeginSync);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CompleteSync);
            // 
            // HorriblePollingTimer
            // 
            this.HorriblePollingTimer.Interval = 1000;
            this.HorriblePollingTimer.Tick += new System.EventHandler(this.Poll);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 412);
            this.Controls.Add(this.flpControls);
            this.Controls.Add(this.pnlSongInfo);
            this.Controls.Add(this.pnlSay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Spot";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.pnlSongInfo.ResumeLayout(false);
            this.pnlSongInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.flpControls.ResumeLayout(false);
            this.pnlSay.ResumeLayout(false);
            this.pnlSay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNowPlaying;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.Panel pnlSongInfo;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.FlowLayoutPanel flpControls;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Panel pnlSay;
        private System.Windows.Forms.TextBox txtSay;
        private System.Windows.Forms.Button btnSay;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Timer HorriblePollingTimer;
    }
}