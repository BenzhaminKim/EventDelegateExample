using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegeEventDemo
{
    public class Text
    {
        public string Content { get; set; }

        public Text(string aContent)
        {
            Content = aContent;
        }
        public override string ToString()
        {
            return $"{Content}";
        }
    }
}
