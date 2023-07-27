using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public List<Gesture> gestures = new List<Gesture>();
        public Gesture chosenGesture;
        public int score;

        //Constructor
        public Player(string name)
        {
            this.name = name;
            gestures.Add(new Rock());
            gestures.Add(new Paper());
            gestures.Add(new Scissors());
            gestures.Add(new Lizard());
            gestures.Add(new Spoke());
            score = 0;
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();
    }
}
