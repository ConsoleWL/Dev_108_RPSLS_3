using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Lizard : Gesture
    {
        public Lizard()
        {
            name = "lizard";
        }
        public override int WillWLT(Gesture gesture)
        {
            // -1 lost
            //  0 tie
            //  1 win

            if (gesture.name == "spoke" || gesture.name == "paper")
            {
                // win
                return 1;
            }
            else if (gesture.name == "rock" || gesture.name == "scissors")
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
