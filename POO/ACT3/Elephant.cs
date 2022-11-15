namespace ACT3
{
    class Elephant
    {
        private string _name;
        private uint _sizeEars;

        public Elephant(string name, uint sizeEars)
        {
            this._name = name;
            this._sizeEars = sizeEars;
        }

        public string GetName()
        {
            return _name;
        }
        public uint GetSizeEars()
        {
            return _sizeEars;
        }
        public string GetAttributes()
        {
            return "Nom de l'éléphant : " + _name + " | Taille oreilles : " + _sizeEars;
        }

        public string ReadMessage(string message, Elephant elephant)
        {
            return _name + " a lu un message de " + elephant._name + " qui dit : " + message;
        }

        public string SendMessage(string message, Elephant elephant)
        {
            return _name + " a envoyé un message à " + elephant._name + " qui dit : " + message;
        }
    }
}