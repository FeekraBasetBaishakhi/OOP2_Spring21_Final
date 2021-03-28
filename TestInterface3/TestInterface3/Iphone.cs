using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface3
{
    class Iphone : IMusicPlayer, IRadioPlayer
    {

        public int volume;
        public int musicCount;
        MusicFile[] musicfile;

        public Iphone() 
        {
            
        }
        public Iphone(int volume)
        {
            this.volume = volume;
            musicfile = new MusicFile[500];
        }


        public void Switch(bool on)
        {
            if (on)
            {
                Console.WriteLine("Iphone ON");

            }
            else
            {
                Console.WriteLine("Iphone OFF");
            }
        }
        public void play(bool on)
        {
            if (on)
            {
                Console.WriteLine("Play");

            }
            else
            {
                Console.WriteLine("Stop");
            }
        }
        public void setVolume(int loudness)
        {
            if (loudness > volume)
            {
                int change = loudness - volume;
                Console.WriteLine("Decrease Volume " + change);
            }
            else if (loudness < volume)
            {
                int change = volume + loudness;
                Console.WriteLine("Increase Volume: " + change);
            }
        }
        
        public void retune(double frequency)
        {
            Console.WriteLine("Radio Frequency: " + frequency );
        }
        public void changeChannel()
        {
            Console.WriteLine("Radio Channel Change");
        }

        public void AddMusicFile(params MusicFile[] musicfiles)
        {
            foreach (MusicFile music in musicfiles)
            {
                this.musicfile[musicCount++] = music;
            }
        }
        virtual public void MusicInfo()
        {

            for (int i = 0; i < musicCount; i++)
            {
                musicfile[i].ShowDetails();
            }
        }
        public void playNext()
        {
            Console.WriteLine("NEXT MUSIC");
        }
        public void playPrevious()
        {
            Console.WriteLine("PREVIOUS MUSIC");
        }
    }
}
