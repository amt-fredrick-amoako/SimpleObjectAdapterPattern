﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObjectAdapterPattern
{
    public class Adaptee
    {
        public Adaptee() { }

        public int MyMethod(int y)
        {
            return y * y;
        }
    }
}
