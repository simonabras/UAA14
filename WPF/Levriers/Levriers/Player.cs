using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levriers
{
    internal class Player
    {
        // Private attributes
        private int _number; // Numéro du joueur
        private string _name; // Nom du joueur
        private int _wallet; // Portefeuille du joueur
        private int _betNumber; // Numéro du pari du joueur
        private int _betAmount; // Montant du pari du joueur

        // Constructor
        public Player(int number, string name, int wallet, int betNumber, int betAmount)
        {
            this._number = number;
            this._name = name;
            this._wallet = wallet;
            this._betNumber = betNumber;
            this._betAmount = betAmount;
        }
        
        // Properties
        public int Number
        {
            get { return _number; }
            //set { _number = value; }
        }
        public string Name
        {
            get { return _name; }
            //set { _name = value; }
        }
        public int Wallet
        {
            get { return _wallet; }
            //set { _wallet = value; }
        }
        public int BetNumber
        {
            get { return _betNumber; }
            //set { _bet = value; }
        }
        public int BetAmount
        {
            get { return _betAmount; }
            //set { _bet = value; }
        }

        // Methods
        public bool MakeBet(int number, int amount, int betMin) // Parier
        {
            if(_wallet >= amount && amount >= betMin)
            {
                _wallet -= amount;
                _betNumber = number;
                _betAmount = amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
