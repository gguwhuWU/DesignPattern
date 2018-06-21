namespace designPatterns.Mediator.Players
{
    public class BluePlayer : Player
    {
        public BluePlayer(string name, Host host) : base(name, host)
        {
            _allBloodNumber = MaxBloodNumber;
        }

        private int _allBloodNumber;
        public override int allBloodNumber
        {
            get
            {
                return _allBloodNumber;
            }

            internal set
            {
                _allBloodNumber = value;
            }
        }

        protected override int attackNumber
        {
            get
            {
                return 10;
            }
        }

        protected override int magicNumber
        {
            get
            {
                return 10;
            }
        }

        protected override int MaxBloodNumber
        {
            get
            {
                return 100;
            }
        }
    }
}
