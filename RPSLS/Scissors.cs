using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Scissors : Gesture
    {
        public Scissors()
        {
            name = "scissors";
        }
        public override int WillBeat(Gesture gesture)
        {
            throw new NotImplementedException();
        }
    }
}
