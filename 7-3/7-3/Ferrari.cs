using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    public class Ferrari : IDrive
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public string Model { get; private set; }

        public string Driver { get; private set; }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{Model}/{UseBrakes()}/{PushGas()}/{Driver}";
        }
    }
}