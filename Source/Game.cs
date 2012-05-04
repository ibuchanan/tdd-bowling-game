using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{

    public class Game
    {

        private readonly IList<int> _pinLog = new List<int>();
        private int _score;


        public Game(IEnumerable<int> initialGameState)
        {
            _pinLog = new List<int>(initialGameState);
        }

        public Game(){}

        public void Roll(int pins)
        {
            if (IsSpare())
            {
                _score += pins*2;
            }
            else
            {
                _score += pins;
            }
            _pinLog.Add(pins);
        }

        private bool IsSpare()
        {
            var lastItem = (_pinLog.Count - 1);
            var secondToLastItem = (_pinLog.Count - 2);
            return (_pinLog[lastItem] + _pinLog[secondToLastItem]) == 10;
        }

        public int Score()
        {
            if (IsSpare())
            return _pinLog.Sum();
        }

    }
}
