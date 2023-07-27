using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {

        }

        public override void ChooseGesture()
        {
            Console.WriteLine($"\n{name}, chooses an options: ");

            while (true)
            {
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine($"Press: {i + 1} for {gestures[i].name}");
                }

                string tempGesture = Console.ReadLine();
                int intTempGesture = int.Parse(tempGesture) - 1;

                if (intTempGesture >= 0)
                {
                    chosenGesture = gestures[intTempGesture];
                    Console.WriteLine($"{name} chooses {chosenGesture.name}");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                }
            }
        }
    }
}
