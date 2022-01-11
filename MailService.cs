using System;
using DelegatesDemo.Models;

namespace DelegatesDemo
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"--> MailService: Sending mail notification: {args.Video.Title}");
        }
    }
}