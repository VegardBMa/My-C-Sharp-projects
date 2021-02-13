namespace Classes
{
    class Color
    {


        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public int Red { get; private set; }

        public int Green { get; private set; }

        public int Blue { get; private set; }

        public int Alpha { get; private set; }

        public int Grayscale => (Red + Green + Blue) / 3;

    }
}



