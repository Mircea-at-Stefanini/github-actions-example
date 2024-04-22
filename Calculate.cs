using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SomeClassLibrary
{
    public class Calculate
    {
        public Calculate() { }

        public double Add(double x, double y) { return x + y; }
        public double Subtract(double x, double y) { return x - y; }
    }
}
