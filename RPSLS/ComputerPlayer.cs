using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {
        Random rnd = new Random();
        int number;
        public ComputerPlayer(string name) : base(name)
        {
        }
        public override void ChooseGesture()
        {
            number = rnd.Next(0, 5);

            chosenGesture = gestures[number];
            Console.WriteLine($"{name} chooses {chosenGesture.name}");
        }
    }
}
