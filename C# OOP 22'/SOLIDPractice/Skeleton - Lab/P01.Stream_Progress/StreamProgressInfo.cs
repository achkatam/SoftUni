namespace P01.Stream_Progress
{
    using P01.Stream_Progress.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StreamProgressInfo
    {
        private IStreamable stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamable stream)
        {
            this.stream = stream;
        }

        public int CalculateCurrentPercent()
        {
            return (this.stream.BytesSent * 100) / this.stream.Length;
        }
    }
}
