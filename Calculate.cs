using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SomeClassLibrary
{
    //Some class, which will be subject to unit testing
    public class Calculate
    {
        public Calculate() { }

        public double Add(double x, double y) { return x + y; }
        public double Subtract(double x, double y) { return x - y; }
    }
}
