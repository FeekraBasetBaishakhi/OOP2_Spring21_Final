using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface3
{
    class Ipod:IRadioPlayer
    {
        public int Volume { get; set; }
        public int MusicCount;
        MusicFile[] musicfile;

        public Ipod() 
        { 

        }
        public Ipod(int volume)
        {
            this.Volume = volume;
            musicfile = new MusicFile[50];
        }

        public void Switch(bool on)
        {
            if (on)
            {
                Console.WriteLine("Ipod is ON");

            }
            else
            {
                Console.WriteLine("Ipod is OFF");
            }
        }
        public void AddMusicFile(params MusicFile[] musicfiles)
        {
            foreach (MusicFile music in musicfiles)
            {
                this.musicfile[MusicCount++] = music;
            }
        }
        public void retune(double frequency)
        {
            Console.WriteLine("Radio Frequency: " + frequency);
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
            if (loudness > Volume)
            {
                int change = loudness - Volume;
                Console.WriteLine("Volume Decrease " + change);
            }
            else if (loudness < Volume )
            {
                int change =  loudness+10;
                Console.WriteLine("Volume Increase: " + change);
            }
        }
        public void changeChannel()
            {
                Console.WriteLine("Channel Changed");
            }
        }
    }

