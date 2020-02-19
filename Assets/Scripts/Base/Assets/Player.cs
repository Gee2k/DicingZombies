namespace Base.Assets
{
    public class Player
    {
        protected string _name;

        public string name
        {
            get => _name;
            set => _name = value;
        }

        public Player(string name)
        {
            this._name = name;
        }
    }
}