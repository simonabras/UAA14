namespace I1P622_Simon
{
    class Light
    {
        // Attributs privés
        private string _id;
        private int _color;

        // Constructeur
        public Light(string id, int color)
        {
            this._id = id;
            this._color = color;
        }

        // Changer la couleur
        public void ChangeColor(int color)
        {
            this._color = color;
        }

        // Afficher la couleur du feu
        public string ShowColor()
        {
            string color;
            if(this._color == 1)
            {
                color = "Vert";
            }
            else if(this._color == 2)
            {
                color = "Orange";
            }
            else
            {
                color = "Rouge";
            }
            return $"Le feu {this._id} est {color}";
        }
        
        // Afficher l'état du feu
        public string ShowStatus()
        {
            string status;
            if(this._color == 0)
            {
                status = "Éteint";
            }
            else
            {
                status = "Allumé";
            }
            return $"Le feu {this._id} est {status}";
        }
    }
}