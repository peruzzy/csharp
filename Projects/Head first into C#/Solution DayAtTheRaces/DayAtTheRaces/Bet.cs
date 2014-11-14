using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            //Return a string that says who placed the bet, how much cash was bet, and which dog he bet on ("Joe bets 8$ on dog #4")
            //If the amount is 0, no bet was placed
            //(Joe hasn't placed a bet yet)
        }
        public int PayOut(int Winner)
        {
            //the paramenter is the winner of the race. If the dog won, return the amount bet. Otherwise, return the negative of the amount bet.
        }
    }
}
