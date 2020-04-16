using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {

        private int[] _rolls = new int[21];
        private int _turn = 0;

        public void Roll(int pins)
        {
            _rolls[_turn] = pins;
            _turn++;
        }

        public int Score()
        {
            int score = 0;
            int roll = 0;
            for(int frame = 0; frame < 10; frame++)
            {
                if(IsStrike(roll))
                {
                    score += 10 + _rolls[roll + 1] + _rolls[roll + 2];
                    roll += 1;
                }
                else if(IsSpare(roll))
                {
                    score += 10 + _rolls[roll + 2];
                    roll += 2;
                } else
                {
                    score += _rolls[roll] + _rolls[roll + 1];
                    roll += 2;
                }
            }

            return score;
        }

        private bool IsSpare(int roll)
        {
            return _rolls[roll] + _rolls[roll + 1] == 10;
        }

        private bool IsStrike(int roll)
        {
            return _rolls[roll] == 10;
        }
    }
}
