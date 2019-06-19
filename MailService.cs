using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegeEventDemo
{
    public class MailService
    {
        public MailService()
        {

        }
        public MailService(Mail mail)
        {

        }

        public void Send(Mail mail)
        {
            Console.WriteLine($"Sending {mail}");
            Thread.Sleep(1000);
            Console.WriteLine($"Sending {mail} Success!");
        }

        public void OnVideoEncoded(object sender, EventArgs args)
        {
            Console.WriteLine($"Sending {sender}");
            Thread.Sleep(1000);
            Console.WriteLine($"Sending {sender} Success!");
        }
    }
}
