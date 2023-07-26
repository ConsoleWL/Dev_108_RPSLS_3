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
        public override int WillWLT(Gesture gesture)
        {
            // -1 lost
            //  0 tie
            //  1 win

            if (gesture.name == "rock" || gesture.name == "spoke")
            {
                // win
                return 1;
            }
            else if (gesture.name == "scissors" || gesture.name == "lizard")
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
