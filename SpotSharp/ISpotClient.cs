using System.Drawing;

namespace SpotSharp
{
    public interface ISpotClient
    {
        string Ping();
        string Playing();
        Image AlbumArt();
        string Find(string songName);
        string Play();
        string Pause();
        string Mute();
        string Volume();
        string SetVolume(int volume);
        string Next();
        string Back();
        string Say(string what);
    }
}