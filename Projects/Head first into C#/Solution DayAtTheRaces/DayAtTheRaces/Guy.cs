using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DayAtTheRaces
{
    public class Guy
    {
        public string Name; // the guy's name
        public Bet MyBet; // An instance of Bet that has his bet
        public int Cash; //how much cash he has

        //the last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton; // My RadioButton
        public Label MyLabel; //My Label

        public void UpdateLabels()
        {
            //set my label to to my bet's description, and the label on my radio button     to show my cash ("Joe has 43 bucks")
        }
        public void ClearBet() { }
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
        }

        public void Collect(int Winner)
        {
            //Ask my bet to pay out, clear my bet, and update my labels
        }
    }
}
