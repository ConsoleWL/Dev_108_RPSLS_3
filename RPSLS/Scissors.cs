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
        public override int WillWLT(Gesture gesture)
        {
            // -1 lost
            //  0 tie
            //  1 win

            if (gesture.name == "paper" || gesture.name == "lizard")
            {
                // win
                return 1;
            }
            else if (gesture.name == "rock" || gesture.name == "spoke")
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
