using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpotSharp.Tests
{
    [TestClass]
    public class SpotSharpTests
    {
        const string Host = "http://192.168.3.175:5051";
        readonly SpotClient _spot = new SpotClient(Host);

        [TestMethod]
        public void CanSayHiToSpot()
        {
            var greeting = _spot.Ping();
            Assert.IsTrue(greeting.Contains("Welcome to Spot!"));
        }

        [TestMethod]
        public void CanAskWhatIsPlaying()
        {
            var playing = _spot.Playing();
            Assert.IsNotNull(playing);
        }

        [TestMethod]
        public void CanGetAlbumnArt()
        {
            var image = _spot.AlbumArt();
            Assert.IsInstanceOfType(image, typeof(System.Drawing.Image));
        }

        [TestMethod]
        public void CanPlayASpecificSong()
        {
            var response =_spot.Find("Raise your weapon");
            Assert.AreEqual("Now playing “Raise Your Weapon” by Deadmau5...", response);
        }

        [TestMethod]
        public void CanPlay()
        {
            var response = _spot.Play();
            Assert.IsTrue(response.Contains("Now playing"));
        }

        [TestMethod]
        public void CanPause()
        {
            var response = _spot.Pause();
            Assert.AreEqual("Everything is paused.", response);
        }

        [TestMethod]
        public void CanMute()
        {
            var response = _spot.Mute();
            Assert.AreEqual("Shhh...", response);
        }

        [TestMethod]
        public void CanAskVolume()
        {
            var response = _spot.Volume();
            int iResult;
            Assert.IsNotNull(response);
            Assert.IsTrue(int.TryParse(response, out iResult));
        }
    
        [TestMethod]
        public void CanSetVolume()
        {
            var response = _spot.SetVolume(80);
            int iResult;
            Assert.IsNotNull(response);
            Assert.IsTrue(int.TryParse(response, out iResult));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FailsWithInvalidVolume()  
        {
            try
            {
                _spot.SetVolume(-129);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("volume", ex.ParamName);
                throw;
            }
        }

        [TestMethod]
        public void CanSkipTrack()
        {
            var response = _spot.Next();
            Assert.IsTrue(response.Contains("Onwards!"));
        }

        [TestMethod]
        public void CanGoBack()
        {
            var response = _spot.Back();
            Assert.IsTrue(response.Contains("Let's hear it again!"));
        }

        [TestMethod]
        public void CanSayStuff()
        {
            var what = "Hi there bud!";
            var response = _spot.Say(what);
            Assert.AreEqual(what, response);
        }
    }
}
