using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Gesture
    {
        public string name;

        //will return value: win 1, loss 2, tie 0
        public abstract int WillWLT(Gesture gesture);
    }
}
