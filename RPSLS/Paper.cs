using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Paper : Gesture
    {
        public Paper()
        {
            name = "paper";
        }
        public override int WillBeat(Gesture gesture)
        {
            throw new NotImplementedException();
        }
    }
}
