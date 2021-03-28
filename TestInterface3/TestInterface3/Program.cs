using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new MusicFile("Believer", "Imgine Dragons", 2015, 355);
            MusicFile m2 = new MusicFile("Sugar", "Maroon 5", 2015, 560);
           
            Console.WriteLine("***IPHONE***");
 
            Iphone i1 = new Iphone(50);
            i1.Switch(true);
            i1.play(true);
            i1.playNext();
            i1.setVolume(60);
            i1.playPrevious();
            i1.retune(88.4);
            i1.changeChannel();

            Console.WriteLine("***IPOD***");

            Ipod i2 = new Ipod(55);
            i2.Switch(true);
            i2.retune(89.6);
            i2.setVolume(50);
            i2.changeChannel();

        }
    }
}
