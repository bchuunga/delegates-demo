using System;
using System.Threading;
using DelegatesDemo.Models;

namespace DelegatesDemo
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(5000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                var videoEventArgs = new VideoEventArgs();
                videoEventArgs.Video = video;
                VideoEncoded(this, videoEventArgs);
            }
        }
    }
}
