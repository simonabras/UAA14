namespace Ex4
{
    class SandwichMaker
    {
        // Private attributes
        private string[] _pain = { "pain blanc", "pain gris", "pain complet", "pain multicéréales" };
        private string[] _proteine = { "jambon", "poulet", "fromage", "oeuf" };
        private string[] _crudité = { "salade", "carottes", "tomates", "concombres" };
        private string[] _condiment = { "mayo", "ketchup", "barbecue", "andalouse" };

        // Constructor
        public SandwichMaker()
        {
            _pain = _pain;
            _proteine = _proteine;
            _crudité = _crudité;
            _condiment = _condiment;
        }

        // Properties
        public string[] Pain
        {
            get { return _pain; }
            //set { _pain = value; }
        }
        public string[] Proteine
        {
            get { return _proteine; }
            //set { _proteine = value; }
        }
        public string[] Crudité
        {
            get { return _crudité; }
            //set { _crudité = value; }
        }
        public string[] Condiment
        {
            get { return _condiment; }
            //set { _condiment = value; }
        }
        // Methods
        public string ComposeSandwish()
        {
            Random random = new Random();
            string pain = _pain[random.Next(0, 4)];
            string proteine = _proteine[random.Next(0, 4)];
            string crudité = _crudité[random.Next(0, 4)];
            string condiment = _condiment[random.Next(0, 4)];
            return $"Voici votre sandwish : {pain}, {proteine}, {crudité}, {condiment}";
        }
    }
}