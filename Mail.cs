using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegeEventDemo
{
    public class Mail
    {
        public string Title { get; set; }
        public string To { get; set; }
        
        public Mail(string aTitle, string aTo)
        {
            Title = aTitle;
            To = aTo;
        }
        public override string ToString()
        {
            return $"{Title} To {To}";
        }
    }
}
