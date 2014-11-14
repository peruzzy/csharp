using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLenght;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;



        public bool Run()
        {
            //Move forward either 1,2, 3 or 4 spaces at random
            //Update the position of my PictureBox on the form like this:   MyPictureBox.Left = StartingPosition + Location;
            //Return true if I won the race
            if (true)
            {
                return true;
            }
            
        }
        public void TakeStartingPosition()
        {
            //Reset my starting position to 0 and my PictureBox to starting position
        }
    }
}
