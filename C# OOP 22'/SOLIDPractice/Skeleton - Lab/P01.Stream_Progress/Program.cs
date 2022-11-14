namespace P01.Stream_Progress
{
    using P01.Stream_Progress.Contracts;
    using System;

    public class Program
    {
        static void Main()
        {
            IStreamable music = new Music("ArtistName", "AlbumName", 111, 1024);

            StreamProgressInfo musicStream = new StreamProgressInfo(music);
            Console.WriteLine( musicStream.CalculateCurrentPercent());

            IStreamable video = new Video("1092x218", 214, 2048);

            StreamProgressInfo videoStream = new StreamProgressInfo(video);
            Console.WriteLine(videoStream.CalculateCurrentPercent());
        }
    }
}
