using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObjectAdapterPattern
{
    public class Adaptor : ITarget
    {
        public Adaptee Adaptee = new Adaptee();
        public int SampleMethod(int y)
        {
            return Adaptee.MyMethod(y);
        }
    }
}
