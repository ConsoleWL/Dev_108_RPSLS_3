using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Rock : Gesture
    {
        public Rock()
        {
            name = "rock";
        }
        public override int WillWLT(Gesture gesture)
        {
            // -1 lost
            //  0 tie
            //  1 win
            
            if(gesture.name == "scissors" || gesture.name == "lizard")
            {
                // win
                return 1;
            }
            else if(gesture.name == "spoke" || gesture.name == "paper")
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
