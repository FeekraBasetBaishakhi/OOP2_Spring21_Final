using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface3
{
    class MusicFile
    {
        private string Title { get; set; }
        private string Artist { get; set; }
        private int YearOfRelease { get; set; }
        private int DurationInSeconds { get; set; }

        public MusicFile()
        {
           
        }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSeconds = durationInSeconds; 
        }
        void changeTitle(string title)
        {
            this.Title = title;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Title is: " + Title);
            Console.WriteLine("Artist is: " + Artist);
            Console.WriteLine("Release Year: " + YearOfRelease);
            Console.WriteLine("Duration (sec): " + DurationInSeconds);


        }
    }
}
