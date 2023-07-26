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
        public override int WillWLT(Gesture gesture)
        {
            // -1 lost
            //  0 tie
            //  1 win

            if (gesture.name == "scissors" || gesture.name == "rock")
            {
                // win
                return 1;
            }
            else if (gesture.name == "paper" || gesture.name == "lizard")
            {
                // loss
                return -1;
            }
            else
            {   // tie
                return 0;
            }
        }
    }
}
