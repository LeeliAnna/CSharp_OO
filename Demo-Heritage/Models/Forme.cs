namespace Demo_Heritage.Models
{
    internal class Forme
    {
        private string _color;
        private int _borderWidth;

        public string Color 
        {
            get { return _color; }
            set { _color = value; } 
        }

        public int BorderWidth
        {
            protected get
            {
                return _borderWidth;
            }

            set
            {
                _borderWidth = (value < 0) ? -value : value;
            }
        }


        public Forme(string color, int borderWidth)
        {
            Color = color;
            BorderWidth = borderWidth;
        }

    }
}
