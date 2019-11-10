using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4
{
    public class Smartphone : ICall, IBrowser
    {
        public string Browse(string url)
        {
           return $"Browse {url}!";
        }

        public string Call(string number)
        {
            return $"Call {number}";
        }
    }
}