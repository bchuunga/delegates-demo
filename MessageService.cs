using System;
using DelegatesDemo.Models;

namespace DelegatesDemo
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"--> MessageSerevice: Sending a text message {args.Video.Title}");
        }
    }
}