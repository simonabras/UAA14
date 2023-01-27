namespace I623_Simon
{
    class PaintBallGun
    {
        // Private attributes
        private int _playerBalls; // Balles dans la poche du joueur
        private int _clipBalls; // Balles dans le chargeur de son arme

        // Constructor
        public PaintBallGun(int balls, int clipBalls)
        {
            this._playerBalls = balls;
            this._clipBalls = clipBalls;
        }

        // Properties
        public int PlayerBalls
        {
            get { return _playerBalls; }
            //set { _playerBalls = value; }
        }
        public int ClipBalls
        {
            get { return _clipBalls; }
            //set { _clipBalls = value; }
        }
        // Methods
        public bool Shoot() // Tirer
        {
            if(_clipBalls > 0)
            {
                _clipBalls -= 1;
                return true;
            }
            else {
                return false;
            }
        }
        public int ReloadClip() // Recharger le chargeur de son arme
        {
            int clipCapacity = 16; // Capacité du chargeur
            int balls = Math.Min(_playerBalls, clipCapacity - _clipBalls); // Nombre de balles à recharger (j'ai utilisé un Math.Min pour ne pas recharger + de balles par rapport au nombre de balles dans la poche du joueur et pour pouvoir vider les dernières balles dans la poche joueur)
            _playerBalls -= balls;
            _clipBalls += balls;
            return balls;
        }
        public void ReloadPlayer() // Recharger la poche du joueur
        {
            int balls = 30; // Nombre de balles à recharger
            _playerBalls += balls;
        }
    }
}