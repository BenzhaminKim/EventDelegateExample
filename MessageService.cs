using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegeEventDemo
{
    public class MessageService
    {
        public MessageService()
        {

        }

        public void Send(Text text)
        {
            Console.WriteLine($"Sending {text}");
            Thread.Sleep(1000);
            Console.WriteLine($"Sending {text} Success!");
        }
        public void OnVideoEncoded(object sender, EventArgs args)
        {
            Console.WriteLine($"Sending {sender}");
            Thread.Sleep(1000);
            Console.WriteLine($"Sending {sender} Success!");
        }
    }
}
