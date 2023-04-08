using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levriers
{
    internal class Game
    {
        // Private attributes
        private TimeSpan _timeSpent; // Temps écoulé
        private int _betMin; // Pari minimum

        // Constructor
        public Game(TimeSpan timeSpent, int betMin)
        {
            this._timeSpent = timeSpent;
            this._betMin = betMin;
        }

        // Properties
        public TimeSpan TimeSpent
        {
            get { return _timeSpent; }
            //set { _timeSpent = value; }
        }
        public int BetMin
        {
            get { return _betMin; }
            //set { _betMin = value; }
        }

        // Methods
        public bool Start() // Commencer le jeu
        {
            return true;
        }
        public bool Reset() // Réinitialser le jeu
        {
            return true;
        }
    }
}
