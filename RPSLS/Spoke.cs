using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Spoke : Gesture
    {
        public Spoke()
        {
            name = "spoke";
        }
        public override int WillBeat(Gesture gesture)
        {
            throw new NotImplementedException();
        }
    }
}
