using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProb
{
    internal class GenericClassProb<T>
    {
        T box;
        public GenericClassProb(T box)
        {
            this.box = box;
        }
        public T GetBox()
        {
            return box;
        }

    }
}
