namespace P01.Stream_Progress
{
    using System;

    using P01.Stream_Progress.Contracts;

    public class Video : IStreamable
    {
        private string resolution;

        public Video(string resolution, int length, int bytesSent)
        {
            this.resolution = resolution;
            this.Length= length;
            this.BytesSent= bytesSent;
        }

        public int Length { get; set; }
        public int BytesSent { get; set; }
    }
}
