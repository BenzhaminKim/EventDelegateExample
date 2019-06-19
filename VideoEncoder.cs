using System;
using System.Threading;
using System.Threading.Tasks;

namespace DelegeEventDemo
{
    internal class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object sender, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler VideoEncoding;

        MailService _mailService;
        MessageService _messageService;
        public VideoEncoder()
        {
        }

        public void Encode(Video video)
        {
            Console.WriteLine("video encoding...");
            Thread.Sleep(1000);
            // _mailService = new MailService();
            // _mailService.Send(new Mail("First Email", "Young"));
            //_messageService = new MessageService();
            // _messageService.Send(new Text("heelllo"));
            OnVideoEncoded(video);
            Console.WriteLine("Encoding Complete");
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoArgs() { Video = video});
        }
    }

    public class VideoArgs: EventArgs
    {
        public Video Video { get; set; }
    }
}