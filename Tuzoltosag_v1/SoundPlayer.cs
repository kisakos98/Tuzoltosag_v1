using NAudio.Wave;
using System.Threading;
using System.Windows.Forms;

namespace Tuzoltosag_v1
{
    internal static class SoundPlayer
    {
        private static bool setdelay = false;
        public static bool SetDelay {
            get
            {
                return setdelay;
            }
            set
            {
                setdelay = value;
            }
        }
        static Thread SoundPlaying = null;
        static System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public static void Stop()
        {
            if(player != null)
                player.Stop();
            if (SoundPlaying != null)
                if (SoundPlaying.IsAlive)
                {
                    SoundPlaying.Abort();
                    while (SoundPlaying.IsAlive) ;
                }
        }

        public static void Play(string[] sounds, bool WithDelay)
        {
            if (SoundPlaying != null)
                if (SoundPlaying.IsAlive)
                {
                    SoundPlaying.Abort();
                    while (SoundPlaying.IsAlive) ;
                }
            SoundPlaying = new Thread(() => Player(sounds, WithDelay));
            SoundPlaying.IsBackground = true;
            SoundPlaying.Start();
        }

        private static void Player(string[] sounds, bool WithDelay)
        {
            try
            {
                int ts;
                
                if(WithDelay)
                {
                    Thread.Sleep(Properties.Settings.Default.SoundDelay*1000);
                }

                foreach (string sound in sounds)
                {
                    using (WaveFileReader wf = new WaveFileReader("sound/" + sound))
                    {
                        ts = (int)wf.TotalTime.TotalMilliseconds;
                    }
                    player.Stop();
                    player.SoundLocation = "sound/" + sound;
                    player.Play();
                    Thread.Sleep(ts + 10);
                }
                player.Stop();
            }
            catch (ThreadAbortException ex)
            { 
                Stop();
            }
            catch
            {
                MessageBox.Show("Hiba a hang lejátszása közben.", "Hang hiba!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                player.Stop();
            }
        }
    }
}
