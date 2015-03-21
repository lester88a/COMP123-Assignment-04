using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment04_Rolling_Dice
{
    class DiceRolling
    {
        //Instance variables++++++++++++++++++++++++++
        private int[] _diceType;
        private int[] _sum;
        private Random _rnd;

        //public properties+++++++++++++++++++++++++++
        public int[] totalOfSum 
        { 
            get
            {
                return this._sum;
            } 
        
        }

        //constructor++++++++++++++++++++++++++++++++
        public DiceRolling()
        {
            this._diceType = new int[2];
            this._sum = new int[11];
            this._rnd = new Random();
        }

        //public method+++++++++++++++++++++++++++++++
        public void RollDice(int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                this._diceType[0] = this._rnd.Next(1, 7);
                this._diceType[1] = this._rnd.Next(1, 7);
                this._sum[(this._diceType[0] + this._diceType[1]) - 2]++;
            }
        }
    }
}
